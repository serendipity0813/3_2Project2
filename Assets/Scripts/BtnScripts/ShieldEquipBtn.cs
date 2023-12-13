using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldEquipBtn : MonoBehaviour
{
    public GameObject OrangeShield;
    public GameObject RedShield;
    public GameObject BlueShield;
    public GameObject UI;


    public void EquipOrangeShield()
    {
        OrangeShield.SetActive(true);
        RedShield.SetActive(false);
        BlueShield.SetActive(false);
        UI.SetActive(false);
    }

    public void EquipRedShield()
    {
        OrangeShield.SetActive(false);
        RedShield.SetActive(true);
        BlueShield.SetActive(false);
        UI.SetActive(false);
    }

    public void EquipBlueShield()
    {
        OrangeShield.SetActive(false);
        RedShield.SetActive(false);
        BlueShield.SetActive(true);
        UI.SetActive(false);
    }
}
