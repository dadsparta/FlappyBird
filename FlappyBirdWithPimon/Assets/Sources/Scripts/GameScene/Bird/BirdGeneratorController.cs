using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGeneratorController : MonoBehaviour
{
    [SerializeField] private GameObject _bird;

    private void Start()
    {
        Instantiate(_bird);
    }
}
