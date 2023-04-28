using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMController : MonoBehaviour
{
    private BGMManager bgmManager;
    private void Awake()
    {
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
    }

    void Start()
    {
        bgmManager.StartBGM();
    }
}

