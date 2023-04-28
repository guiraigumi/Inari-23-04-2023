using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject cardCanvas; // reference to the canvas that displays the cards
    public GameObject[] cards; // array of card game objects
    public string[] cardLetters; // array of letters that correspond to each card
    private List<GameObject> collectedCards = new List<GameObject>(); // list of collected cards
    private int playerLayer; // the layer that the player is on

    private void Start()
    {
        // disable all the card game objects at the start of the game
        foreach (GameObject card in cards)
        {
            card.SetActive(false);
        }

        // get the layer index of the "Player" layer
        playerLayer = LayerMask.NameToLayer("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == playerLayer)
        {
            // find the index of the card that corresponds to this chest
            int cardIndex = System.Array.IndexOf(cardLetters, gameObject.name);

            // get the card game object
            GameObject card = cards[cardIndex];

            if (!collectedCards.Contains(card))
            {
                collectedCards.Add(card); // add the card to the collected cards list if it hasn't been collected before

                // show the card on the canvas
                cardCanvas.SetActive(true);
                card.SetActive(true);

                // disable player movement while the card is displayed
                other.GetComponent<Player>().enabled = false;
            }
        }
    }

    private void Update()
    {
        // check if the player presses the enter key to close the card canvas
        if (Input.GetKeyDown(KeyCode.Return) && cardCanvas.activeSelf)
        {
            // hide the card canvas
            cardCanvas.SetActive(false);

            // enable player movement again
            foreach (GameObject go in GameObject.FindObjectsOfType<GameObject>())
            {
                if (go.layer == playerLayer)
                {
                    go.GetComponent<Player>().enabled = true;
                }
            }
        }

        // check if the player presses the I key to show the collected cards
        if (Input.GetKeyDown(KeyCode.I))
        {
            // loop through the collected cards list and show them on the canvas
            for (int i = 0; i < collectedCards.Count; i++)
            {
                collectedCards[i].SetActive(true);
            }
        }
    }
}




