using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float _xOffSet;
    [SerializeField] public GameObject _bird;
    

    private void Start()
    {
        _bird = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        transform.position = new Vector3(_bird.transform.position.x - _xOffSet,
            transform.position.y, transform.position.z);
    }
}
