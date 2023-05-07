using UnityEngine;

public class DesactivarObjetosRuhe : MonoBehaviour
{
    public GameObject[] objectsToDeactivate;
    public GameObject cameraToActivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(false);
            }
            cameraToActivate.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            foreach (GameObject obj in objectsToDeactivate)
            {
                obj.SetActive(true);
            }
            cameraToActivate.SetActive(false);
        }
    }
}




