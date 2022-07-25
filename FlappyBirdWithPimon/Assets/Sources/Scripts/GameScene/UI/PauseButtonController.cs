using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

namespace Sources.Scripts.UI
{
    public class PauseButtonController : MonoBehaviour
    {
        [SerializeField] private GameObject _pauseButton;
        [SerializeField] private GameObject _background;
        [SerializeField] private GameObject _buttonOfRestart;
        [SerializeField] private GameObject _buttonOfContunie;



        public void PauseGame()
        {
            Time.timeScale = 0;
            _pauseButton.SetActive(false);
            _background.SetActive(true);
            _buttonOfRestart.SetActive(true);
            _buttonOfContunie.SetActive(true);
        }

        public void ContinueGame()
        {
            Time.timeScale = 1;
            _pauseButton.SetActive(true);
            _background.SetActive(false);
            _buttonOfRestart.SetActive(false);
            _buttonOfContunie.SetActive(false);
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
    }
}


