using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [RequireComponent(typeof(BirdController))]
public class BirdModel : MonoBehaviour
{
    private BirdController _birdController;
    private float _score;

    private void Start()
    {
        _birdController = GetComponent<BirdController>();
    }

    private void ResetPlayer()
    {
        _score = 0;
        _birdController.ResetBird();
        Die();
    }

    private void Die()
    {
        Debug.Log("Вы умерли");
        Time.timeScale = 0;
    }
}
