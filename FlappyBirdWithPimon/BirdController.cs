using System.Collections;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    #region Parametrs


    [SerializeField] private float _xOffSet;

    private GameObject _camera;
    #endregion

    #region Methods

    
    private void Start()
    {
        _camera = GameObject.FindWithTag("MainCamera");
        if (_camera != null)
        {
            StartCoroutine(CameraController());
        }
    }

    IEnumerator CameraController()
    {
        _camera.transform.position = new Vector3(gameObject.transform.position.x - _xOffSet,
            _camera.transform.position.y, _camera.transform.position.z);
        yield return null;
    }

    #endregion
}
