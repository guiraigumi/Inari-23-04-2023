using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cofre : MonoBehaviour
{
    public static Player Instance;
    private Animator anim;
    private AudioSource audio;
    [SerializeField] private GameObject chestIcon;
    [SerializeField] private GameObject chestIcon2;
    [SerializeField] private GameObject chestIcon3;
    [SerializeField] private GameObject chestIcon4;
    [SerializeField] private AudioClip openChest;
    [SerializeField] private AudioClip chestAlert;
    private SFXManager sfxManager;

    public GameObject card;
    public GameObject canvasController;
    public GameObject cardObtainedalbum;

    // Agrega una variable para almacenar el ID de la carta correspondiente al cofre
    public int cardID;

    private bool isOpened = false;

    // Referencia al Card Manager
    private CardManager cardManager;

    private void Awake()
    {
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
    }
    void Start()
    {
        Instance = GetComponent<Player>();
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        cardManager = FindObjectOfType<CardManager>();
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (!isOpened && collider.gameObject.CompareTag("Player"))
        {
            chestIcon.SetActive(true);
            audio.PlayOneShot(chestAlert);
        }

        if (!isOpened && collider.gameObject.CompareTag("Ruhe"))
        {
            chestIcon2.SetActive(true);
            audio.PlayOneShot(chestAlert);
        }

        if (!isOpened && collider.gameObject.CompareTag("Hangin"))
        {
            chestIcon3.SetActive(true);
            audio.PlayOneShot(chestAlert);
        }

        if (!isOpened && collider.gameObject.CompareTag("Kalju"))
        {
            chestIcon4.SetActive(true);
            audio.PlayOneShot(chestAlert);
        }
    }


    void OnTriggerStay(Collider collider)
    {
        if (!isOpened && collider.gameObject.CompareTag("Player") && Input.GetButtonDown("Submit"))
        {
            anim.SetBool("isOpen", true);
            chestIcon.SetActive(false);
            isOpened = true;
            card.SetActive(true);
            canvasController.SetActive(true);
            cardObtainedalbum.SetActive(true);
            audio.PlayOneShot(openChest);
            sfxManager.RewardSound();
            GetComponent<Player>().enabled = false;

            // Llama a la funci�n ActivateCard del Card Manager y pasa el ID de la carta correspondiente al cofre que se abri�
            cardManager.ActivateCard(cardID);
        }

        if (!isOpened && collider.gameObject.CompareTag("Ruhe") && Input.GetButtonDown("Submit"))
        {
            anim.SetBool("isOpen", true);
            chestIcon2.SetActive(false);
            isOpened = true;
            card.SetActive(true);
            canvasController.SetActive(true);
            cardObtainedalbum.SetActive(true);
            audio.PlayOneShot(openChest);
            GetComponent<Player>().enabled = false;

            // Llama a la funci�n ActivateCard del Card Manager y pasa el ID de la carta correspondiente al cofre que se abri�
            cardManager.ActivateCard(cardID);
        }

        if (!isOpened && collider.gameObject.CompareTag("Hangin") && Input.GetButtonDown("Submit"))
        {
            anim.SetBool("isOpen", true);
            chestIcon3.SetActive(false);
            isOpened = true;
            card.SetActive(true);
            canvasController.SetActive(true);
            cardObtainedalbum.SetActive(true);
            audio.PlayOneShot(openChest);
            GetComponent<Player>().enabled = false;

            // Llama a la funci�n ActivateCard del Card Manager y pasa el ID de la carta correspondiente al cofre que se abri�
            cardManager.ActivateCard(cardID);
        }

        if (!isOpened && collider.gameObject.CompareTag("Kalju") && Input.GetButtonDown("Submit"))
        {
            anim.SetBool("isOpen", true);
            chestIcon4.SetActive(false);
            isOpened = true;
            card.SetActive(true);
            canvasController.SetActive(true);
            cardObtainedalbum.SetActive(true);
            audio.PlayOneShot(openChest);
            GetComponent<Player>().enabled = false;

            // Llama a la funci�n ActivateCard del Card Manager y pasa el ID de la carta correspondiente al cofre que se abri�
            cardManager.ActivateCard(cardID);
        }

        if (isOpened && Input.GetButtonDown("Cancel"))
        {
            GetComponent<Player>().enabled = true;
        }
    }

    

    void OnTriggerExit(Collider collider)
    {
        if (!isOpened && collider.gameObject.CompareTag("Player"))
        {
            chestIcon.SetActive(false);
        }

        if (!isOpened && collider.gameObject.CompareTag("Ruhe"))
        {
            chestIcon2.SetActive(false);
        }

        if (!isOpened && collider.gameObject.CompareTag("Hangin"))
        {
            chestIcon3.SetActive(false);
        }

        if (!isOpened && collider.gameObject.CompareTag("Kalju"))
        {
            chestIcon4.SetActive(false);
        }
    }

}