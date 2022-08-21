using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Sources.Scripts.GameScene.GameObjects.Coins
{
    public class CoinController : MonoBehaviour
    {

        [SerializeField] private GameObject _coin;

        private CoinShowController _coinShowController;

        private int _nextCoinSpawn = 3;

        private void Start()
        {
            _coin.SetActive(false);
        
            CoinGenerator();
        }
        

        public void CoinGenerator()
        {
            CoinDataBase.CoinSpawnerController++; 
            if (CoinDataBase.CoinSpawnerController == _nextCoinSpawn) 
            { 
                _coin.SetActive(true); 
                CoinDataBase.CoinSpawnerController = 0;
                _nextCoinSpawn = Random.Range(1,5);
            }
            else 
            { 
                _coin.SetActive(false);
            }
        }

        private void OnTriggerEnter2D(Collider2D collider2D)
        {
            if (collider2D.gameObject.CompareTag("Player"))
            {
                IncreaseCoins();
            }
        }

        private void IncreaseCoins()
        {
            _coin.SetActive(false);
            CoinDataBase.CoinCount++;
            PlayerPrefs.SetInt("CoinCount",CoinDataBase.CoinCount);
            PlayerPrefs.Save();
            CoinShowController.instance.UpdateCoinCount();
        }
    }
}
