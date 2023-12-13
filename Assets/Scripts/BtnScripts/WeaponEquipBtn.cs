using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponEquipBtn : MonoBehaviour
{
    public GameObject Sword;
    public GameObject Spear;
    public GameObject Battle;
    public GameObject UI;


    public void EquipSword()
    {
        Sword.SetActive(true);
        Spear.SetActive(false);
        Battle.SetActive(false);
        UI.SetActive(false);
    }

    public void EquipSpear()
    {
        Sword.SetActive(false);
        Spear.SetActive(true);
        Battle.SetActive(false);
        UI.SetActive(false);
    }

    public void EquipBattle()
    {
        Sword.SetActive(false);
        Spear.SetActive(false);
        Battle.SetActive(true);
        UI.SetActive(false);
    }
}
