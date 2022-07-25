using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BirdController))]
public class BirdModel : MonoBehaviour
{
    [SerializeField] private TMP_Text _counter;
    
    private BirdController _birdController;
    private int _score;
    

    private void Start()
    {
        _birdController = GetComponent<BirdController>();
    }

    public void IncreaseScore()
    {
        _score++;
        _counter.text = _score.ToString();
    }

    private void ResetPlayer()
    {
        _score = 0;
        _birdController.ResetBird();
    }

    public void Die()
    {
        Debug.Log("Вы умерли");
        SceneManager.LoadScene(0); 
        ResetPlayer();
    }
}
