using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    #region Parametrs

    [SerializeField] private float _speed;
    [SerializeField] private float _JumpForce;
    [SerializeField] private float _minQuaretionZ;
    [SerializeField] private float _maxQuaretionZ;
    [SerializeField] private float _rotationSpeed;
    
    
    private Vector2 _startPosition;
    private Rigidbody2D _rigidbody2D;
    private Quaternion _minQuaternion;
    private Quaternion _maxQuaternion;
    #endregion

    #region Methods

    
    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _startPosition = transform.position;
        _minQuaternion = Quaternion.Euler(0, 0, _minQuaretionZ);
        _maxQuaternion = Quaternion.Euler(0,0, _maxQuaretionZ);
        
        
        ResetBird();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.velocity = new Vector2(_speed,0);
            transform.rotation = _maxQuaternion;
            _rigidbody2D.AddForce(Vector2.up * _JumpForce , ForceMode2D.Impulse);
        }
        transform.rotation = Quaternion.Lerp(transform.rotation, _minQuaternion, _rotationSpeed * Time.deltaTime);
    }

    public void ResetBird()
    {
        transform.position = _startPosition;
        transform.rotation = Quaternion.Euler(0,0,0);
        _rigidbody2D.velocity = Vector2.zero;
    }

    #endregion
}
