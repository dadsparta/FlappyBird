using System;
using Sources.Scripts.GameScene.Bird;
using Sources.Scripts.GameScene.DataBase;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

namespace Sources.Scripts.UI
{
    public class ButtonController : MonoBehaviour
    {
        [SerializeField] private GameObject _pauseButton;
        [SerializeField] private GameObject _pauseMenu;

        private GameObject _bird;
        
        public void PauseGame()
        {
            Time.timeScale = 0;
            _pauseButton.SetActive(false);
            _pauseMenu.SetActive(true);

        }

        public void ContinueGame()
        {
            Time.timeScale = 1;
            _pauseButton.SetActive(true);
            _pauseMenu.SetActive(false);
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }

        public void ExitToMenu()
        {
            ScoreRecordDatabase.Score = 0;
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
    }
}


