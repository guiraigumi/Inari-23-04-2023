using UnityEngine;

public class ShowImage : MonoBehaviour
{
    public GameObject imagenObjeto;
    private bool isImageOpen = false;

    public void ToggleImage()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !isImageOpen)
        {
            imagenObjeto.SetActive(true);
            isImageOpen = true;
        }
        else if ((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return)) && isImageOpen)
        {
            imagenObjeto.SetActive(false);
            isImageOpen = false;
        }
    }



}


