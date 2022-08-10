using System;
using Sources.Scripts.GameScene.DataBase;
using UnityEngine;

namespace Sources.Scripts.AudioScripts
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioController : MonoBehaviour
    {
        private AudioSource _audioSource;

        private void Start()
        {
            _audioSource = GetComponent<AudioSource>();
            if (!PlayerPrefs.HasKey("Volume"))
            {
                _audioSource.volume = 1f;
            }
            else
            {
                _audioSource.volume = PlayerPrefs.GetFloat("Volume");
                AudioVolumeDatabase.AudioVolume = PlayerPrefs.GetFloat("Volume");
            }
        }

        private void Update()
        {
            if (_audioSource.volume != AudioVolumeDatabase.AudioVolume)
            {
                ChangeSound();
            }
        }

        private void ChangeSound()
        {
            _audioSource.volume = AudioVolumeDatabase.AudioVolume;
        }
    }
}
