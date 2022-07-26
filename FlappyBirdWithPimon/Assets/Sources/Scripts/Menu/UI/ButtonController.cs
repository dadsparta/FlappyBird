using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sources.Scripts.menu.UI
{
    public class ButtonController : MonoBehaviour
    {
        public void StartGame()
        {
            SceneManager.LoadScene(1);
        }

        public void ExitGame()
        {
            Application.Quit();
        }
        
    }
}
