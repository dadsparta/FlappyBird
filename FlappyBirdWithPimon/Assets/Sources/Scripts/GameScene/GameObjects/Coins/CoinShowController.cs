using System;
using TMPro;
using UnityEngine;

namespace Sources.Scripts.GameScene.GameObjects.Coins
{
    public class CoinShowController : MonoBehaviour
    {
        public static CoinShowController instance;

        [SerializeField] private TMP_Text _counterOfCoins;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        private void Start()
        {
            _counterOfCoins.text = ":" + CoinDataBase.CoinCount;
        }


        public void UpdateCoinCount()
        {
            _counterOfCoins.text = ":" + CoinDataBase.CoinCount;
        }
    }
}
