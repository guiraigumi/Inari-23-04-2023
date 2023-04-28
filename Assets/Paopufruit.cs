using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paopufruit : MonoBehaviour
{

    GameObject npcQuest; // declarar el GameObject

    void Start()
    {
         // encuentra el GameObject en Start()
    }

    void Update()
    {
        npcQuest = GameObject.Find("NPC_Quest");

        if (gameObject.activeSelf && gameObject.name == "PaopuFruit")
        {
            // Desactiva el script NPC_Quest
            npcQuest.GetComponent<NPC_Quest>().enabled = false;

            // Activa el script NPC_Quest_2
            npcQuest.GetComponent<NPC_Quest_2>().enabled = true;
        }
    }
}

