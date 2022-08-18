using UnityEngine;

namespace Sources.Scripts.GameScene.GameObjects.Coins
{
    public class CoinController : MonoBehaviour
    {

        [SerializeField] private GameObject _coin;

        private void Start()
        {
            _coin.SetActive(false);
        
            CoinGenerator();
        }

        public void CoinGenerator()
        {
            CoinDataBase.CoinSpawnerController++; 
            if (CoinDataBase.CoinSpawnerController == 3) 
            { 
                _coin.SetActive(true); 
                CoinDataBase.CoinSpawnerController = 0;
            }
            else 
            { 
                _coin.SetActive(false);
            }
        }

    }
}
