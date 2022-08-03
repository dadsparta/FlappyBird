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
        [SerializeField] private GameObject _soundSlider;

        private Slider _slider;

        #endregion

        #region Methods

        

        private void Start()
        {
                _slider = _soundSlider.GetComponent<Slider>();
            if (!PlayerPrefs.HasKey("VolumeOfSounds"))
            {
                _slider.value = 1f;
            }
            else
            {
                AudioVolumeDatabase.AudioVolume = PlayerPrefs.GetFloat("VolumeOfSounds");
                _slider.value = AudioVolumeDatabase.AudioVolume;
            }
        }

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
            PlayerPrefs.SetFloat("VolumeOfSounds", AudioVolumeDatabase.AudioVolume);
            PlayerPrefs.Save();
        }
        
        #endregion
    }
}
