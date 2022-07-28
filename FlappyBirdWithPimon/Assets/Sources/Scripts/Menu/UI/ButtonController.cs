using System;
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
        
        public void Options()
        {
            _menuController.OptionsSetActive();
        }

        public void ReturnToMainMenu()
        {
            _menuController.ReturnToMainMenu();
        }   

    }
}
