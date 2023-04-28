using UnityEngine;

public class CardManager : MonoBehaviour
{
    public GameObject cardContainer;

    public void ActivateCard(int cardID)
    {
        // Busca la carta correspondiente al ID en el contenedor de cartas
        GameObject card = cardContainer.transform.Find("Card" + cardID).gameObject;

        // Activa la carta
        card.SetActive(true);
    }
}

