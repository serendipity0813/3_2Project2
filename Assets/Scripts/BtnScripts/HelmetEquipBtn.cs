using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelmetEquipBtn : MonoBehaviour
{
    public GameObject BronzeHelmet;
    public GameObject SilverHelmet;
    public GameObject BlackHelmet;
    public GameObject UI;


    public void EquipBronzeHelmet()
    {
        BronzeHelmet.SetActive(true);
        SilverHelmet.SetActive(false);
        BlackHelmet.SetActive(false);
        UI.SetActive(false);
    }

    public void EquipSilverHelmet()
    {
        BronzeHelmet.SetActive(false);
        SilverHelmet.SetActive(true);
        BlackHelmet.SetActive(false);
        UI.SetActive(false);
    }

    public void EquipBlackHelmet()
    {
        BronzeHelmet.SetActive(false);
        SilverHelmet.SetActive(false);
        BlackHelmet.SetActive(true);
        UI.SetActive(false);
    }
}
