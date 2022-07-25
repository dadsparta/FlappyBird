using System;
using System.Collections;
using System.Collections.Generic;
using Sources.Scripts.GameScene.Bird;
using UnityEngine;

[RequireComponent(typeof(BirdModel))]
public class BirdCollisionController : MonoBehaviour
{
    private BirdModel _birdModel;

    private void Start()
    {
        _birdModel = GetComponent<BirdModel>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.TryGetComponent(out ScoreZone scoreZone))
            _birdModel.IncreaseScore();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
            _birdModel.Die();
    }
}
