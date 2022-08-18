using System;
using Sources.Scripts.GameScene.DataBase;
using Sources.Scripts.Menu.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sources.Scripts.menu.UI
{
    public class ButtonController : MonoBehaviour
    {
        private SettingMenuController _menuController;

        private void Start()
        { 
            _menuController = gameObject.AddComponent<SettingMenuController>();
        }

        public void StartGame()
        {
            SceneManager.LoadScene(1);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
        
        public void OpenOptions()
        {
            _menuController.OptionsSetActive();
        }

        public void ReturnToMainMenu()
        {
            _menuController.ReturnToMainMenu();
        }
        
        public void OpenShop()
        {
            
        }

        private void PlayerPrefsSaver()
        {
            if (PlayerPrefs.HasKey("_recordScore"))
            {
                ScoreRecordDatabase.ScoreRecord = PlayerPrefs.GetInt("_recordScore");
            }

            if (PlayerPrefs.HasKey("CoinCount"))
            {
                CoinDataBase.CoinCount = PlayerPrefs.GetInt("CoinCount");
            }
        }

    }
}
