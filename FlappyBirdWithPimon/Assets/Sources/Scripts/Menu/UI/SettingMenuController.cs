using System;
using Sources.Scripts.GameScene.DataBase;
using UnityEngine;
using UnityEngine.UI;

namespace Sources.Scripts.Menu.UI
{
    public class SettingMenuController : MonoBehaviour
    {
        #region Parameters
        
        [SerializeField] private GameObject _mainMenu;
        [SerializeField] private GameObject _setting;
        [SerializeField] private GameObject _resetButton;
        [SerializeField] private GameObject _warning;


        #endregion

        #region Methods


        public void OptionsSetActive()
        {
            _mainMenu.SetActive(false);
            _setting.SetActive(true);
        }

        public void ReturnToMainMenu()
        {
            _setting.SetActive(false);
            _mainMenu.SetActive(true);

        }

        public void ShowWarning()
        {
            _resetButton.SetActive(false);
            _warning.SetActive(true);
        }

        public void AgreeToReset()
        {
            PlayerPrefs.SetInt("_recordScore",0);
            PlayerPrefs.Save();
            _warning.SetActive(false);
            _resetButton.SetActive(true);
        }

        public void DeclineToReset()
        {
            _warning.SetActive(false);
            _resetButton.SetActive(true);
        }

        public void ChangeVolumeOfSound(float vol)
        {
            AudioVolumeDatabase.AudioVolume = vol;
            PlayerPrefs.SetFloat("Volume", AudioVolumeDatabase.AudioVolume);
            PlayerPrefs.Save();
        }
        
        #endregion
    }
}
