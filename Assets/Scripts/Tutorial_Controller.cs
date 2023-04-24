using UnityEngine;
using System.Collections;

public class Tutorial_Controller : MonoBehaviour
{
    public GameObject tutorialCanvas;

    // Start is called before the first frame update
    void Start()
    {
        // Set the tutorial canvas to active and stop time
        tutorialCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player has hit the enter key
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Escape)) 
        {
            // Deactivate the tutorial canvas and resume time
            tutorialCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
        
        if (Input.GetKeyDown(KeyCode.JoystickButton1) || Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            // Deactivate the tutorial canvas and resume time
            tutorialCanvas.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}

