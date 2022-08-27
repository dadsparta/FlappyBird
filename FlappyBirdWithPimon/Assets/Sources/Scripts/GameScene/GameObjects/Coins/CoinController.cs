using System;
using UnityEngine;
using Random = UnityEngine.Random;
namespace Sources.Scripts.GameScene.GameObjects.Coins
{
    public class CoinController : MonoBehaviour
    {
        public static CoinController CoinControl;

        [SerializeField] private GameObject _coin;

        private CoinShowController _coinShowController;
        private void Start()
        {
            CoinDataBase.NextCoinSpawn = 3;
            _coin.SetActive(false);
            CoinGenerator();
        }
        

        public void CoinGenerator()
        {
            CoinDataBase.CoinSpawnerController++; 
            if (CoinDataBase.CoinSpawnerController == CoinDataBase.NextCoinSpawn) 
            { 
                _coin.SetActive(true); 
                CoinDataBase.CoinSpawnerController = 0;
                CoinDataBase.NextCoinSpawn = Random.Range(1,5);
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
