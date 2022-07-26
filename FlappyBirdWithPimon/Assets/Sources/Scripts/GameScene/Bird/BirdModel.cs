using Sources.Scripts.GameScene.DataBase;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

namespace Sources.Scripts.GameScene.Bird
{
    [RequireComponent(typeof(BirdController))]
    public class BirdModel : MonoBehaviour
    {
        #region Parameters
        
        [SerializeField] private TMP_Text _counter;
        [SerializeField] private TMP_Text _endCounter;
        [SerializeField] private GameObject _deathMenu;
        [SerializeField] private GameObject _BestScoreGameObject;
        
        private ScoreRecordController _scoreRecordController;
        private BirdController _birdController;

        #endregion

        #region Methods

        

        private void Start()
        {
            _scoreRecordController = _BestScoreGameObject.GetComponent<ScoreRecordController>();
            _birdController = GetComponent<BirdController>();
            
        }

        public void IncreaseScore()
        {
            ScoreRecordDatabase.Score++;
            _counter.text = ScoreRecordDatabase.Score.ToString();
        }

        private void ResetPlayer()
        {
            ScoreRecordDatabase.Score = 0;
            _birdController.ResetBird();
        }

        public void Die()
        {
            Debug.Log("Вы умерли");
            _endCounter.text = ScoreRecordDatabase.Score.ToString();
            _scoreRecordController.UpdateMaxRecord();
            _scoreRecordController.ShowMaxRecord();
            _deathMenu.SetActive(true);
            Time.timeScale = 0;
            ResetPlayer();
        }
        
        #endregion
    }
}
