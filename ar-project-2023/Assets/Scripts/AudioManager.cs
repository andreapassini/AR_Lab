using System;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioManager: MonoBehaviour
    {
        private static AudioSource _audioSource;

        public static AudioManager Instance { get; private set; }

        private void Awake()
        {
            _audioSource ??= transform.GetComponent<AudioSource>();
            
            // If there is an instance and it's not me, destroy me
            if (Instance != null && Instance != this)
            {
                Destroy(this);
                return;
            }
            Instance = this;
        }

        public void PlayClip(AudioClip clip)
        {
            _audioSource.PlayOneShot(clip);
        }
    }
}