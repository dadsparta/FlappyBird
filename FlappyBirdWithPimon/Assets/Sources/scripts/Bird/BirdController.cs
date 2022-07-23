using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _JumpForce;
    [SerializeField] private Vector2 _vector2;

    private Rigidbody2D _rigidbody2D;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = new Vector2(_speed,0);
            
            _rigidbody2D.AddForce(Vector2.up * _JumpForce , ForceMode2D.Impulse);
        }  
    }
}
