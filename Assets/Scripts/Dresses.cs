using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dresses : MonoBehaviour
{
    public Sprite[] images;
    public Image imageContainer;
    public static int Dress_number;

    public void SetImage(int index)
    {
        if (images.Length >= index)
        {
            imageContainer.sprite = images[index];
            Dress_number = index;
        }
        else
        {
            Debug.LogError("Invalid image index: " + index);
        }
    }
}
