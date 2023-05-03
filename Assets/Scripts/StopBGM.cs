using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBGM : MonoBehaviour
{
    private BGMManager bgmManager;
    // Start is called before the first frame update
    void Awake()
    {
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
    }

    // Update is called once per frame
    void Start()
    {
        bgmManager.StopBGM();
    }
}
