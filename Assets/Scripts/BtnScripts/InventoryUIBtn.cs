using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUIBtn : MonoBehaviour
{
    public GameObject Info;
    public GameObject ButtonUI;
    public GameObject InventoryUI;

    // Start is called before the first frame update

    public void InventoryOn()
    {
        InventoryUI.SetActive(true);
        Info.SetActive(false);
        ButtonUI.SetActive(false);
    }

    public void InventoryOff()
    {
        InventoryUI.SetActive(false);
        ButtonUI.SetActive(true);
        Info.SetActive(true);
    }
}
