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
            }
        }

        public void ShowMaxRecord()
        {
            _recordText.text = "Ваш рекорд: " + ScoreRecordDatabase.ScoreRecord;
        }
    }
}
