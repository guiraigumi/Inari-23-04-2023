using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public static BGMManager Instance;

    private AudioSource _audioSource;

    private bool _isPlaying = false;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(this.gameObject);

        _audioSource = GetComponent<AudioSource>();
        _audioSource.playOnAwake = false; // Disable PlayOnAwake
    }


    void Start()
    {
        if (!_isPlaying)
        {
            PlayBGM();
        }
    }

    public void PlayBGM()
    {
        if (_isPlaying) return;

        _audioSource.Play();
        _isPlaying = true;
    }

    public void StopBGM()
    {
        _audioSource.Stop();
        _isPlaying = false;
    }
}


