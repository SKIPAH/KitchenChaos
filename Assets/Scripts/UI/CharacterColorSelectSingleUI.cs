using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterColorSelectSingleUI : MonoBehaviour
{
    [SerializeField] private int colorId;
    [SerializeField] private Image image;
    [SerializeField] private GameObject selectedGameObject;


    private void Start()
    {
        image.color = KitchenGameMultiplayer.Instance.GetPlayerColor(colorId);
    }


    private void UpdateIsSelected()
    {

    }
}
