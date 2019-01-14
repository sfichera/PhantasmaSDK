﻿using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button adminButton;

    // Start is called before the first frame update
    void Start()
    {
        adminButton.gameObject.SetActive(true); //PhantasmaDemo.Instance.IsTokenOwner());
    }

    public void AccountClicked()
    {
        CanvasManager.Instance.OpenAccount();
    }

    public void MyAssetsClicked()
    {
        CanvasManager.Instance.OpenMyAssets();
    }

    public void MarketClicked()
    {
        CanvasManager.Instance.OpenMarket();
    }

    public void AdminClicked()
    {
        CanvasManager.Instance.OpenAdmin();
    }

    public void LogoutClicked()
    {
        PhantasmaDemo.Instance.LogOut();
    }

}
