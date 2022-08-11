using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllers : MonoBehaviour
{  
    #region Parameters
    
    [SerializeField] private float _xOffSet;
    
    private GameObject _camera;
    
    #endregion

    #region Methods
    
    private void Start()
    {
        _camera = GameObject.FindWithTag("MainCamera");
    }

    private void Update()
    {
        CameraController();
    }

    private void CameraController()
    {
        _camera.transform.position = new Vector3(gameObject.transform.position.x - _xOffSet,
            _camera.transform.position.y, _camera.transform.position.z);
    }

    #endregion
}
