using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{
    [SerializeField] private GameObject _shop;
    [SerializeField] private GameObject _menu;

    public void OpenMenu()
    {
        _menu.SetActive(false);
        _shop.SetActive(true);
    }

    public void ReturnToMenu()
    {
        _shop.SetActive(false);
        _menu.SetActive(true);
    }
}
