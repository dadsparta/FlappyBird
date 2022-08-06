using Sources.Scripts.GameScene.DataBase;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


namespace Sources.Scripts.GameScene.Bird
{
    [RequireComponent(typeof(BirdController))]
    public class BirdModel : MonoBehaviour
    {
        #region Parameters
        
        [SerializeField]private GameObject _deathMenu;
        [SerializeField]private GameObject _bestScoreGameObject;
        
        private TMP_Text _counter;
        private TMP_Text _endCounter;
        private ScoreRecordController _scoreRecordController;
        private BirdController _birdController;

        #endregion

        #region Methods

        

        private void Start()
        {
            _counter = GameObject.FindWithTag("Counter").GetComponent<TMP_Text>();
            
            _deathMenu = GameObject.FindGameObjectWithTag("DeathMenu");
            
            _endCounter = GameObject.FindGameObjectWithTag("EndCounter").GetComponent<TMP_Text>();
            
            _bestScoreGameObject = GameObject.FindGameObjectWithTag("RecordCounter");
            
            _scoreRecordController = _bestScoreGameObject.GetComponent<ScoreRecordController>();
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
