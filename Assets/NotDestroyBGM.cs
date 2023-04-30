using UnityEngine;

public class NotDestroyBGM : MonoBehaviour
{
    private static NotDestroyBGM instance = null;

    private void Awake()
    {
        // Check if an instance already exists in the scene
        if (instance != null && instance != this)
        {
            // Destroy the duplicate BGM Manager
            Destroy(gameObject);
            return;
        }

        // Set the instance to this BGM Manager
        instance = this;

        // Don't destroy this object when loading new scenes
        DontDestroyOnLoad(gameObject);
    }

    public void StopBGM()
    {
        // Destroy the instance of this BGM Manager
        Destroy(gameObject);
    }
}













