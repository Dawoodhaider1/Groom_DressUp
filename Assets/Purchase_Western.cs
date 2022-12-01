using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Purchase_Western : MonoBehaviour
{
    public int price;
    public GameObject priceTag;
    public GameObject dress;
    public GameObject store;
    public Text Remaining_Coins;

    private int selected;

    public void OnMouseDown()
    {
        Button button = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        selected = MainManager.Instance.item;
        Debug.Log("The selected Item is:" + selected);

        //Western
        if (MainManager.Instance.Purchased_Shirts[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Shirts[selected - 5] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }

        else if (MainManager.Instance.Purchased_Pants[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Pants[selected - 5] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }

        else if (MainManager.Instance.Purchased_Coats[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Coats[selected - 5] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }

        else if (MainManager.Instance.Purchased_Ties[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Ties[selected - 5] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }

        else if (MainManager.Instance.Purchased_Hairstyles[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Hairstyles[selected - 5] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }

        else if (MainManager.Instance.Purchased_Shoes_W[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Shoes_W[selected - 5] = selected;
                priceTag.SetActive(false);

                Debug.Log("Price Tag Set to inactive...");
                Remaining_Coins.text = MainManager.Instance.Coins.ToString();
                dress.SetActive(true);
                MainManager.Instance.SaveUserData();
            }
            else
            {
                Debug.Log("Insufficient Money For this purchase");
                dress.SetActive(false);
                store.SetActive(true);
            }
        }
    }
}
