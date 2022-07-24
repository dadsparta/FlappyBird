using System;
using UnityEngine;
using UnityEngine.Pool;
using Random = UnityEngine.Random;

public class PipeGenerator : PipeController
{
    #region Parameters

    [SerializeField] private GameObject _template;
    [SerializeField] private float _secondBetweenSpawn;
    [SerializeField] private float _maxSpawnPositionY;
    [SerializeField] private float _minSpawnPositionY;

    private float _elapsedTime = 0;
    
    #endregion

    #region Methods

    private void Start()
    {
        Initialize(_template);
    }

    private void Update()
    {
        _elapsedTime += Time.deltaTime;

        if (_elapsedTime > _secondBetweenSpawn)
        {
            if (TryGetObject(out GameObject pipe))
            {
                _elapsedTime = 0;

                float spawnPointY = Random.Range(_minSpawnPositionY, _maxSpawnPositionY);
                Vector3 spawnPoint = new Vector3(transform.position.x , spawnPointY, transform.position.z);
                pipe.SetActive(true);
                pipe.transform.position = spawnPoint;
                
                DisablePoolNear();
                DisableObjectsAbroadScreen();
            }
        }
    }

    #endregion
}
