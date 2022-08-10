using System;
using System.Collections;
using System.Collections.Generic;
using Sources.Scripts.GameScene.DataBase;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class TouchController : MonoBehaviour
{
    #region Parametrs

    [SerializeField] private float _speed;
    [SerializeField] private float _JumpForce;
    [SerializeField] private float _minQuaretionZ;
    [SerializeField] private float _maxQuaretionZ;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private UnityEvent _reached;

    private GameObject _bird;
    private Vector2 _startPosition;
    private Rigidbody2D _rigidbody2D;
    private Quaternion _minQuaternion;
    private Quaternion _maxQuaternion;
    #endregion

    #region Methods

    
    private void Start()
    {
        _minQuaternion = Quaternion.Euler(0, 0, _minQuaretionZ);
        _maxQuaternion = Quaternion.Euler(0,0, _maxQuaretionZ);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        _bird.transform.rotation = Quaternion.Lerp(_bird.transform.rotation, _minQuaternion, _rotationSpeed * Time.deltaTime);
    }

    private void OnMouseDown()
    {
        Jump();
    }

    public void GetBirdGameObject(GameObject gameObject)
    {
        _bird = gameObject;
        _rigidbody2D = _bird.GetComponent<Rigidbody2D>();
        _startPosition = _bird.transform.position;
    }

    public void Jump()
    {
        _reached?.Invoke();
        _rigidbody2D.velocity = new Vector2(_speed,0);
        _bird.transform.rotation = _maxQuaternion;
        _rigidbody2D.AddForce(Vector2.up * _JumpForce , ForceMode2D.Impulse);
        _bird.transform.rotation = Quaternion.Lerp(_bird.transform.rotation, _minQuaternion,
            _rotationSpeed * Time.deltaTime);
    }

    #endregion
}
