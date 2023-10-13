using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BaseCounter : MonoBehaviour, IKitchenObjectParent
{


    public static event EventHandler OnAnyObjectPlacedHere;
    [SerializeField] private Transform spawnPoint;

   

    private KitchenObject kitchenObject;


    public virtual void Interact(Player player)
    {
        Debug.LogError("Basecounter.interact()");
    }
    public virtual void InteractAlternate(Player player)
    {
      //  Debug.LogError("Basecounter.InteractAlternate()");
    }


    public Transform GetKitchenObjectFollowTransform()
    {
        return spawnPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;

        if(kitchenObject != null)
        {
            OnAnyObjectPlacedHere?.Invoke(this, EventArgs.Empty);
        }
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}
