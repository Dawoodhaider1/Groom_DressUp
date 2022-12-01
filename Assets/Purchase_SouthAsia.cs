using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Purchase_SouthAsia : MonoBehaviour
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

        //South Asian
        if (MainManager.Instance.Purchased_Sherwani[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Sherwani[selected - 5] = selected;
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

        else if (MainManager.Instance.Purchased_Trousers[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Trousers[selected - 5] = selected;
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

        else if (MainManager.Instance.Purchased_Shawls[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Shawls[selected - 5] = selected;
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

        else if (MainManager.Instance.Purchased_Turbans_SA[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Turbans_SA[selected - 5] = selected;
                priceTag.SetActive(false);
                //MainManager.Instance.PriceTag[selected - 5] = false;

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

        else if (MainManager.Instance.Purchased_Khussas[selected - 5] == 0)
        {
            if (MainManager.Instance.Coins >= price)
            {
                MainManager.Instance.Coins = MainManager.Instance.Coins - price;
                MainManager.Instance.Purchased_Khussas[selected - 5] = selected;
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
