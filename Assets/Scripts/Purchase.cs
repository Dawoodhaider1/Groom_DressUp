using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Purchase : MonoBehaviour
{
    public int price;
    public GameObject priceTag;
    public GameObject dress;
    public GameObject store;
    public Text Remaining_Coins;

    public void OnClickButton()
    {
        Button button = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        Debug.Log("The Button Selected is:" + button);
        
        if (MainManager.Instance.Coins >= price)
        {
            MainManager.Instance.Coins = MainManager.Instance.Coins - price;
            MainManager.Instance.SaveUserData();
            priceTag.SetActive(false);

            Debug.Log("Price Tag Set to inactive...");
            Remaining_Coins.text = MainManager.Instance.Coins.ToString();
            dress.SetActive(true);
        }
        else
        {
            Debug.Log("Insufficient Money For this purchase");
            dress.SetActive(false);
            store.SetActive(true);
        }
    }
}
