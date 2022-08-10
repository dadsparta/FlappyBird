using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGeneratorController : MonoBehaviour
{
    [SerializeField] private Transform _playerPos;
    [SerializeField] private GameObject[] _bird;
    [SerializeField] private GameObject _touchControllerGameObject;
    
    private TouchController _touchController;

    private void Start()
    {
        _touchController = _touchControllerGameObject.GetComponent<TouchController>();

        if (PlayerPrefs.HasKey("PlayerSkin"))
        {
            GameObject bird = Instantiate(_bird[PlayerPrefs.GetInt("PlayerSkin")],
                _playerPos.position,Quaternion.identity);
            _touchController.GetBirdGameObject(bird);
        }
        else
        {
            PlayerPrefs.SetInt("PlayerSkin",0);
            GameObject bird = Instantiate(_bird[PlayerPrefs.GetInt("PlayerSkin")],
                _playerPos.position,Quaternion.identity);
            _touchController.GetBirdGameObject(bird);
            PlayerPrefs.Save();
        }
    }
}
