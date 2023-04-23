using UnityEngine;

public class ColliderActivator : MonoBehaviour
{
    public GameObject objectToActivate;
    public LayerMask playerLayer;

    private void OnTriggerEnter(Collider other)
    {
        if (IsPlayer(other))
        {
            objectToActivate.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsPlayer(other))
        {
            objectToActivate.SetActive(false);
        }
    }

    private bool IsPlayer(Collider other)
    {
        return playerLayer == (playerLayer | (1 << other.gameObject.layer));
    }
}



