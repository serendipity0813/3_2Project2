using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorEquipBtn : MonoBehaviour
{
    public GameObject BronzeBody;
    public GameObject SilverBody;
    public GameObject BlackBody;
    public GameObject UI;


    public void EquipBronzeBody()
    {
        BronzeBody.SetActive(true);
        SilverBody.SetActive(false);
        BlackBody.SetActive(false);
        UI.SetActive(false);
    }

    public void EquipSilverBody()
    {
        BronzeBody.SetActive(false);
        SilverBody.SetActive(true);
        BlackBody.SetActive(false);
        UI.SetActive(false);
    }

    public void EquipBlackBody()
    {
        BronzeBody.SetActive(false);
        SilverBody.SetActive(false);
        BlackBody.SetActive(true);
        UI.SetActive(false);
    }
}
