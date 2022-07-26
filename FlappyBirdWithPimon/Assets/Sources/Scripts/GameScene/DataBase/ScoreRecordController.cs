using System;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

namespace Sources.Scripts.GameScene.DataBase
{
    public class ScoreRecordController : MonoBehaviour
    {
        [SerializeField] private TMP_Text _recordText;

        public void UpdateMaxRecord()
        {
            if (ScoreRecordDatabase.Score > ScoreRecordDatabase.ScoreRecord)
            {
                ScoreRecordDatabase.ScoreRecord = ScoreRecordDatabase.Score;
                PlayerPrefs.SetInt("_recordScore",ScoreRecordDatabase.ScoreRecord);
                PlayerPrefs.Save();
            }
        }

        public void ShowMaxRecord()
        {
            if (PlayerPrefs.HasKey("_recordScore"))
            {
                ScoreRecordDatabase.ScoreRecord = PlayerPrefs.GetInt("_recordScore");
            }
            _recordText.text = "Ваш рекорд: " + ScoreRecordDatabase.ScoreRecord;
        }
    }
}
