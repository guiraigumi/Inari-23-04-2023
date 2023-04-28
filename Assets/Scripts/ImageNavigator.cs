using UnityEngine;
using UnityEngine.UI;

public class ImageNavigator : MonoBehaviour
{
    public Image[] images;
    public float scaleFactor = 2f;

    private int currentIndex = 0;

    private void Start()
    {
        UpdateImageScale();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex = (currentIndex + 1) % images.Length;
            UpdateImageScale();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = images.Length - 1;
            }
            UpdateImageScale();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            images[currentIndex].transform.localScale *= scaleFactor;
        }
    }

    private void UpdateImageScale()
    {
        for (int i = 0; i < images.Length; i++)
        {
            if (i == currentIndex)
            {
                images[i].transform.localScale = Vector3.one;
            }
            else
            {
                images[i].transform.localScale = Vector3.one * 0.5f;
            }
        }
    }
}

