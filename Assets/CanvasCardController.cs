using UnityEngine;

public class CanvasCardController : MonoBehaviour
{
    public GameObject[] elementsToDeactivate; // Array of GameObjects to deactivate

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Loop through each element and set it inactive
            for (int i = 0; i < elementsToDeactivate.Length; i++)
            {
                elementsToDeactivate[i].SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            // Loop through each element and set it inactive
            for (int i = 0; i < elementsToDeactivate.Length; i++)
            {
                elementsToDeactivate[i].SetActive(false);
            }
        }

    }
}

