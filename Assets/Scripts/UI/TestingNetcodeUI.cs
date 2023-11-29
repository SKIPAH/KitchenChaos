using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class TestingNetcodeUI : MonoBehaviour
{

    [SerializeField] private Button startHostBtn;
    [SerializeField] private Button startClientBtn;
    [SerializeField] private Button startServerBtn;



    private void Awake()
    {
        startHostBtn.onClick.AddListener(() =>
        {
            Debug.Log("HOST");
            NetworkManager.Singleton.StartHost();
            Hide();
        });
        startClientBtn.onClick.AddListener(() =>
        {
            Debug.Log("CLIENT");
            NetworkManager.Singleton.StartClient();
            Hide();
        });
    }



    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
