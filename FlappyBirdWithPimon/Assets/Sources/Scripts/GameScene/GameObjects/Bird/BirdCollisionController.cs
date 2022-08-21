using System;
using System.Collections;
using System.Collections.Generic;
using Sources.Scripts.GameScene.Bird;
using Sources.Scripts.GameScene.GameObjects.Coins;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(BirdModel))]
public class BirdCollisionController : MonoBehaviour
{
    [SerializeField] private UnityEvent _crashToWall;

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
        if (col.gameObject.tag == "Roof")
        {
        }
        else
        {
            _crashToWall?.Invoke();
            _birdModel.Die();
        }
    }
}
