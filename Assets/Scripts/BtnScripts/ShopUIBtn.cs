using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUIBtn : MonoBehaviour
{
    public GameObject Info;
    public GameObject ShopUI;


    public void ShopUIOn()
    {
        ShopUI.SetActive(true);
        Info.SetActive(false);
    }

    public void ShopUIOff()
    {
        ShopUI.SetActive(false);
        Info.SetActive(true);
    }


}
