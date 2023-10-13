using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryManager : MonoBehaviour
{
    public event EventHandler OnRecipeSpawned;
    public event EventHandler OnRecipeCompleted;
    public event EventHandler OnRecipeSuccess;
    public event EventHandler OnRecipeFailed;

    public static DeliveryManager Instance { get; private set; }

    [SerializeField] private RecipeListSO recipeListSO;


    private List<RecipeSO> waitingRecipeSOList;
    private float recipeTimerSpawn;
    private float recipeTimerSpawnMax = 4f;
    private int maxRecipeCount = 4;
    private int successfulRecipesAmount;

    private void Awake()
    {
        Instance = this;
        waitingRecipeSOList = new List<RecipeSO>();
    }


    private void Update()
    {
        recipeTimerSpawn -= Time.deltaTime;
        if(recipeTimerSpawn <= 0f)
        {
            recipeTimerSpawn = recipeTimerSpawnMax;

            if(waitingRecipeSOList.Count < maxRecipeCount) {
                RecipeSO waitingRecipeSO = recipeListSO.recipeSOList[UnityEngine.Random.Range(0, recipeListSO.recipeSOList.Count)];
                waitingRecipeSOList.Add(waitingRecipeSO);

                OnRecipeSpawned?.Invoke(this, EventArgs.Empty);
            }
            
        }
    }



    public void DeliverRecipe(PlateKitchenObject plateKitchenObject)
    {
        for (int i = 0; i < waitingRecipeSOList.Count; i++)
        {
            RecipeSO waitingRecipeSO = waitingRecipeSOList[i];

            if(waitingRecipeSO.kitchenObjectSOList.Count == plateKitchenObject.GetKitchenObjectSOList().Count)
            {
                // HAs the same number of ingredients
                bool plateMatchesRecipe = true;
                foreach(KitchenObjectSO recipeKitchenObjectSO in waitingRecipeSO.kitchenObjectSOList)
                {
                    // cycling through all ingredients in the recipe
                    bool isIngredientFound = false;
                    foreach (KitchenObjectSO plateKitchenObjectSO in plateKitchenObject.GetKitchenObjectSOList())
                    {
                        // cycling through all ingredients in the plate
                        if(plateKitchenObjectSO == recipeKitchenObjectSO)
                        {
                            //ingredient matches
                            isIngredientFound = true;
                            break;
                        }

                    }
                    if (!isIngredientFound)
                    {
                        //This recipe ingredient was not found on the plate
                        plateMatchesRecipe = false;
                    }

                }
                if(plateMatchesRecipe)
                {
                    //player delivered the correct recipe!
                    successfulRecipesAmount++;
                    waitingRecipeSOList.RemoveAt(i);
                    OnRecipeCompleted?.Invoke(this, EventArgs.Empty);
                    OnRecipeSuccess?.Invoke(this, EventArgs.Empty);
                    
                    return;
                }

            }
        }

        //no matches found
        //player did not deliver correct recipe
        OnRecipeFailed?.Invoke(this, EventArgs.Empty);
    }




    public List<RecipeSO> GetWaitingRecipeSOList()
    {
        return waitingRecipeSOList;
    }


    public int GetSuccessfulRecipesAmount()
    {
        return successfulRecipesAmount;
    }
}
