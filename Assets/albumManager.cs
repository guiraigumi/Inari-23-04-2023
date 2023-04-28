using UnityEngine;

public class albumManager : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    private SFXManager sfxManager;

    void Start()
    {
        gameObject1.SetActive(false);
        gameObject2.SetActive(false);
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        Time.timeScale = 1; // set timeScale to 1 at start
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) || Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            gameObject1.SetActive(true);
            gameObject2.SetActive(true);
            sfxManager.BookSound();
            Time.timeScale = 0; // set timeScale to 0 when object is active
        }

        if (Input.GetButtonDown("Cancel") || Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject1.SetActive(false);
            gameObject2.SetActive(false);
            Time.timeScale = 1; // set timeScale back to 1 when objects are inactive
        }
    }
}

