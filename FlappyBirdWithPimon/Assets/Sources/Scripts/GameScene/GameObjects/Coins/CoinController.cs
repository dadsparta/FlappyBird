using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public void CoinGenerator()
    {
        CoinDataBase.CoinSpawnerController++; 
        if (CoinDataBase.CoinSpawnerController == 3) 
        { 
            gameObject.SetActive(true); 
            CoinDataBase.CoinSpawnerController = 0;
        }
        else 
        { 
            gameObject.SetActive(false);
        }
    }

}
