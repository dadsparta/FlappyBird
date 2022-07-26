using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sources.Scripts.GameScene.Bird
{
    [RequireComponent(typeof(BirdController))]
    public class BirdModel : MonoBehaviour
    {
        #region Parameters
        
        [SerializeField] private TMP_Text _counter;
        [SerializeField] private TMP_Text _endCounter;
        [SerializeField] private GameObject _deathMenu;
        
        private BirdController _birdController;
        private int _score;
    
        #endregion

        #region Methods

        

        private void Start()
        {
            _birdController = GetComponent<BirdController>();
        }

        public void IncreaseScore()
        {
            _score++;
            _counter.text = _score.ToString();
        }

        private void ResetPlayer()
        {
            _score = 0;
            _birdController.ResetBird();
        }

        public void Die()
        {
            Debug.Log("Вы умерли");
            _endCounter.text = _score.ToString();
            _deathMenu.SetActive(true);
            Time.timeScale = 0;
            ResetPlayer();
        }
        
        #endregion
    }
}
