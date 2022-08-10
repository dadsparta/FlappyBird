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
        [SerializeField] private GameObject _touchPanel;



        public void PauseGame()
        {
            Time.timeScale = 0;
            _pauseButton.SetActive(false);
            _pauseMenu.SetActive(true);
            _touchPanel.SetActive(false);

        }

        public void ContinueGame()
        {
            Time.timeScale = 1;
            _pauseButton.SetActive(true);
            _pauseMenu.SetActive(false);
            _touchPanel.SetActive(true);
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }

        public void ExitToMenu()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
    }
}


