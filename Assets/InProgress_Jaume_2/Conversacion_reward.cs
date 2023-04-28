using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Conversacion_reward : MonoBehaviour
{
    public static Player Instance;
    private Animator anim;
    private SFXManager sfxManager;
    public GameObject card;
    public GameObject canvasController;
    public GameObject albumCard;


    private bool isOpened = false;

    void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }
    void Start()
    {
        Instance = GetComponent<Player>();
        anim = GetComponent<Animator>();
        //sfxManager.TypingSound();
        card.SetActive(true);
        canvasController.SetActive(true);
        albumCard.SetActive(true);
        sfxManager.RewardSound();
        Destroy(this);
    }


}