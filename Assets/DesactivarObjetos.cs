using UnityEngine;

public class DesactivarObjetos : MonoBehaviour
{
    public GameObject[] objectsToDeactivate;
    public GameObject cameraToActivate1;
    public GameObject cameraToActivate2;
    public string playerTag = "Player";
    public string ruheTag = "Ruhe";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag))
        {
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(false);
            }
            cameraToActivate1.SetActive(true);
            cameraToActivate2.SetActive(false);
        }

        if (other.gameObject.CompareTag(ruheTag))
        {
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(false);
            }
            cameraToActivate1.SetActive(false);
            cameraToActivate2.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(playerTag) || other.gameObject.CompareTag(ruheTag))
        {
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(true);
            }
            cameraToActivate1.SetActive(false);
            cameraToActivate2.SetActive(false);
        }
    }
}




