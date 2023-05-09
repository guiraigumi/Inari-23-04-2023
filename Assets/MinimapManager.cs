using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapManager : MonoBehaviour
{
    public GameObject minimapBig;
    public GameObject instruction;
    public GameObject miniMap;
    public GameObject minimapFrame;
    public GameObject minimapCamera;
    public GameObject bigmapCamera;

    // Start is called before the first frame update

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            minimapBig.SetActive(true);
            bigmapCamera.SetActive(true);
            instruction.SetActive(true);
            miniMap.SetActive(false);
            minimapCamera.SetActive(false);
            minimapFrame.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton5))
        {
            minimapBig.SetActive(true);
            bigmapCamera.SetActive(true);
            instruction.SetActive(true);
            miniMap.SetActive(false);
            minimapCamera.SetActive(false);
            minimapFrame.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            minimapBig.SetActive(false);
            bigmapCamera.SetActive(false);
            instruction.SetActive(false);
            miniMap.SetActive(true);
            minimapCamera.SetActive(true);
            minimapFrame.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            minimapBig.SetActive(false);
            bigmapCamera.SetActive(false);
            instruction.SetActive(false);
            miniMap.SetActive(true);
            minimapCamera.SetActive(true);
            minimapFrame.SetActive(true);
        }
    }
}
