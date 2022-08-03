using System;
using Sources.Scripts.GameScene.DataBase;
using UnityEngine;
using UnityEngine.UI;

namespace Sources.Scripts.Menu.UI
{
    public class SliderController : MonoBehaviour
    {
        [SerializeField] private Slider _slider;

        private void Start()
        {
            if (!PlayerPrefs.HasKey("Volume"))
            {
                _slider.value = 1f;
            }
            else
            {
                _slider.value = PlayerPrefs.GetFloat("Volume");
                AudioVolumeDatabase.AudioVolume = PlayerPrefs.GetFloat("Volume");
            }
        }
    }
}
