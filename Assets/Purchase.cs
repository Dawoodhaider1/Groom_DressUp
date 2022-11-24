using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Purchase : MonoBehaviour
{
    public int price;
    public GameObject priceTag;
    public GameObject dress;
    public Text Remaining_Coins;

    void OnMouseDown()
    {
        if (MainManager.Instance.Coins >= price)
        {
            MainManager.Instance.Coins = MainManager.Instance.Coins - price;
            MainManager.Instance.SaveUserData();
            priceTag.SetActive(false);
            Remaining_Coins.text = MainManager.Instance.Coins.ToString();
            dress.SetActive(true);
        }
        else
        {
            Debug.Log("Insufficient Money For this purchase");
        }
    }
}
