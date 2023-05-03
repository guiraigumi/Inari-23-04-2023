using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicController : MonoBehaviour
{
    public AudioClip[] musicClips;
    private AudioSource audioSource;
    private int currentSceneIndex;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        PlayMusic(currentSceneIndex);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        int newSceneIndex = scene.buildIndex;
        if (newSceneIndex != currentSceneIndex)
        {
            PlayMusic(newSceneIndex);
            currentSceneIndex = newSceneIndex;
        }
    }

    void PlayMusic(int sceneIndex)
    {
        if (sceneIndex == 10)
        {
            audioSource.clip = musicClips[1];
        }
        else
        {
            audioSource.clip = musicClips[0];
        }
        audioSource.Play();
    }
}

