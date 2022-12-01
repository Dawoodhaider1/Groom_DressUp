using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bought : MonoBehaviour
{
    public GameObject[] priceTag = new GameObject[5];

    void Start()
    {
        //Middle Eastern
        for(int i = 0; i <= MainManager.Instance.Purchased_Dresses.Length; i++)
        {
            if (MainManager.Instance.Purchased_Dresses[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Shoes_ME.Length; i++)
        {
            if (MainManager.Instance.Purchased_Shoes_ME[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Turbans_ME.Length; i++)
        {
            if (MainManager.Instance.Purchased_Turbans_ME[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        //Western
        for (int i = 0; i <= MainManager.Instance.Purchased_Shirts.Length; i++)
        {
            if (MainManager.Instance.Purchased_Shirts[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Pants.Length; i++)
        {
            if (MainManager.Instance.Purchased_Pants[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Coats.Length; i++)
        {
            if (MainManager.Instance.Purchased_Coats[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Ties.Length; i++)
        {
            if (MainManager.Instance.Purchased_Ties[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Hairstyles.Length; i++)
        {
            if (MainManager.Instance.Purchased_Hairstyles[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Shoes_W.Length; i++)
        {
            if (MainManager.Instance.Purchased_Shoes_W[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        //South Asian
        for (int i = 0; i <= MainManager.Instance.Purchased_Sherwani.Length; i++)
        {
            if (MainManager.Instance.Purchased_Sherwani[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Trousers.Length; i++)
        {
            if (MainManager.Instance.Purchased_Trousers[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Shawls.Length; i++)
        {
            if (MainManager.Instance.Purchased_Shawls[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Turbans_SA.Length; i++)
        {
            if (MainManager.Instance.Purchased_Turbans_SA[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }

        for (int i = 0; i <= MainManager.Instance.Purchased_Khussas.Length; i++)
        {
            if (MainManager.Instance.Purchased_Khussas[i] != 0)
            {
                priceTag[i].SetActive(false);
                MainManager.Instance.SaveUserData();
            }
        }
    }
}
