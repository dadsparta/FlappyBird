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
            _audioSource.volume = AudioVolumeDatabase.AudioVolume;
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
