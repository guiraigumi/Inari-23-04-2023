using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject[] elementsToDeactivate; // Array of GameObjects to deactivate

    void Start()
    {
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Escape))
        {
            // Loop through each element and set it inactive
            for (int i = 0; i < elementsToDeactivate.Length; i++)
            {
                elementsToDeactivate[i].SetActive(false);
                Time.timeScale = 1f;
            }
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton1) || Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            // Loop through each element and set it inactive
            for (int i = 0; i < elementsToDeactivate.Length; i++)
            {
                elementsToDeactivate[i].SetActive(false);
                Time.timeScale = 1f;
            }
        }

    }
}

