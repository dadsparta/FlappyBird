using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
public class PipeController : MonoBehaviour

{
    #region parameters

    [SerializeField] private GameObject _container;
    [SerializeField] private int _capacity;
    [SerializeField]private Camera _camera;
    
    private List<GameObject> _pool = new List<GameObject>();

    #endregion

    #region Methods

    private void Start()
    {
        _camera = Camera.main;
    }

    protected void Initialize(GameObject prefab)
    {
        for (int i = 0; i < _capacity; i++)
        {
            GameObject spawned = Instantiate(prefab, _container.transform);
            spawned.SetActive(false);
                
            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject result)
    {
        result = _pool.FirstOrDefault(p => p.activeSelf == false);
        return result != null;
    }

    protected void DisableObjectsAbroadScreen()
    {
        Vector3 disablePoint = _camera.ViewportToWorldPoint(new Vector3(-0.5f,-0.5f));
        
        foreach (var item in _pool)
        {
            if (item.activeSelf == true)
            {
                if (item.transform.position.x < disablePoint.x)
                {
                    item.SetActive(false);
                }
            }
        }
    }

    protected void DisablePoolNear()
    {
        for (int i = 0; i < _pool.Count; i++)
        {
            for (int j = 0; j < _pool.Count; j++)
            {
                if (i!=j)
                {
                    if (_pool[i].transform.position.x == _pool[j].transform.position.x)
                        _pool[j].IsDestroyed();
                }
            }
        }
    }

    public void ResetPool()
    {
        foreach (var item in _pool)
        {
            item.SetActive(false);
        }
    }

    #endregion
}
