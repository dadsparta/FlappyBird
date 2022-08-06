using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGeneratorController : MonoBehaviour
{
    [SerializeField] private Transform _playerPos;
    [SerializeField] private GameObject[] _bird;

    private void Start()
    {
        if (PlayerPrefs.HasKey("PlayerSkin"))
        {
            Instantiate(_bird[PlayerPrefs.GetInt("PlayerSkin")],_playerPos.position,Quaternion.identity);
        }
        else
        {
            PlayerPrefs.SetInt("PlayerSkin",0);
            Instantiate(_bird[PlayerPrefs.GetInt("PlayerSkin")],_playerPos.position,Quaternion.identity);
            PlayerPrefs.Save();
        }
    }
}
