using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Dialogue_Ruhe : MonoBehaviour
{
    private bool isPlayerInRange;
    private bool didDialogueStart;
    public bool isTalking;
    private int lineIndex;
    private AudioSource _audioSource;
    GameObject npc;

    Animator anim;
    Animator anim2;
    public Player player;

    private float typingTime = 0.01f;

    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private GameObject backgroundImage;
    [SerializeField] private GameObject RawImage;
    private SFXManager sfxManager;
    private BGMManager bgmManager;
    [SerializeField, TextArea(4, 6)] private string[] dialogueLines;

    [SerializeField] private GameObject npc1; // Assign in inspector
    [SerializeField] private GameObject npc2; // Assign in inspector

    void Awake()
    {
        anim = npc1.GetComponent<Animator>();
        anim2 = npc2.GetComponent<Animator>();
        player = GameObject.Find("Player").GetComponent<Player>();
        sfxManager = GameObject.Find("SFXManager").GetComponent<SFXManager>();
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();

    }

    void Start()
    {
        StartDialogue();
        bgmManager.StartBGM();
    }

    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Submit"))
        {
            if (!didDialogueStart)
            {
                StartDialogue();
            }
            else if (dialogueText.text == dialogueLines[lineIndex])
            {
                NextDialogueLine();
            }
            else
            {
                StopAllCoroutines();

                dialogueText.text = dialogueLines[lineIndex];
            }

        }
    }

    private void StartDialogue()
    {
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        backgroundImage.SetActive(true);
        RawImage.SetActive(true);
        lineIndex = 0;

        StartCoroutine(ShowLine());
        player.isplayerTalking = true;
    }


    private void NextDialogueLine()
    {
        lineIndex++;
        if (lineIndex < dialogueLines.Length)
        {
            SetIdleAnimations();
            StartCoroutine(ShowLine());
        }
        else
        {
            didDialogueStart = false;
            dialoguePanel.SetActive(false);
            backgroundImage.SetActive(false);
            RawImage.SetActive(false);
            anim.SetBool("isTalking", false);
            anim2.SetBool("isTalking", false);
            npc = GameObject.Find("Profesor");
            player.isplayerTalking = false;
            //Time.timeScale = 1f;
        }

        if (lineIndex >= dialogueLines.Length)
        {
            SceneManager.LoadScene("Scene_7");
        }
    }


    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;

        // switch the animation for the two NPCs
        if (lineIndex % 2 == 0)
        {
            anim.SetBool("isTalking", true);
            anim2.SetBool("isTalking", false);
        }
        else
        {
            anim.SetBool("isTalking", false);
            anim2.SetBool("isTalking", true);
        }

        foreach (char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch;
            sfxManager.TypingSound();

            // switch the animation for the two NPCs
            if (lineIndex % 2 == 0)
            {
                anim.SetBool("isTalking", true);
                anim2.SetBool("isTalking", false);
            }
            else
            {
                anim.SetBool("isTalking", false);
                anim2.SetBool("isTalking", true);
            }

            yield return new WaitForSecondsRealtime(typingTime);
            yield return null;
        }

        SetIdleAnimations();

    }

    void SetIdleAnimations()
    {
        anim.SetBool("isTalking", false);
        anim2.SetBool("isTalking", false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            StopAllCoroutines();

            if (didDialogueStart)
            {
                dialoguePanel.SetActive(false);
                backgroundImage.SetActive(false);
                RawImage.SetActive(false);
                anim.SetBool("isTalking", false);
                anim2.SetBool("isTalking", false);
                player.isplayerTalking = false;
            }
        }
    }
}
























