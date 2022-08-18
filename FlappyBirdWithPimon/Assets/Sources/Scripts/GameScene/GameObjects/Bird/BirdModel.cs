using Sources.Scripts.GameScene.DataBase;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


namespace Sources.Scripts.GameScene.Bird
{
    public class BirdModel : MonoBehaviour
    {
        #region Parameters
        
        [SerializeField]private GameObject _deathMenu;
        [SerializeField]private GameObject _bestScoreGameObject;
        
        private TMP_Text _counter;
        private TMP_Text _endCounter;
        private ScoreRecordController _scoreRecordController;
        private TouchController _touchController;

        #endregion

        #region Methods
        
        private void Start()
        {
            _counter = GameObject.FindWithTag("Counter").GetComponent<TMP_Text>();
            _deathMenu = GameObject.FindWithTag("DeathMenu");
            _endCounter = GameObject.FindGameObjectWithTag("EndCounter").GetComponent<TMP_Text>();
            _bestScoreGameObject = GameObject.FindGameObjectWithTag("RecordCounter");
            _scoreRecordController = _bestScoreGameObject.GetComponent<ScoreRecordController>();
            _touchController = GetComponent<TouchController>();
            
            _deathMenu.SetActive(false);
        }

        public void IncreaseScore()
        {
            ScoreRecordDatabase.Score++;
            _counter.text = ScoreRecordDatabase.Score.ToString();
        }

        private void ResetScore()
        {
            ScoreRecordDatabase.Score = 0;
        }

        public void Die()
        {
            _endCounter.text = ScoreRecordDatabase.Score.ToString();
            _scoreRecordController.UpdateMaxRecord();
            _scoreRecordController.ShowMaxRecord();
            _deathMenu.SetActive(true);
            Time.timeScale = 0;
            ResetScore();
        }
        
        #endregion
    }
}
