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
        Instantiate(_bird[0],_playerPos.position,Quaternion.identity);
    }
}
