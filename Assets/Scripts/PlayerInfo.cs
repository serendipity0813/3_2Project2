using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class PlayerInfo : MonoBehaviour
{
    public int Money;
    public int HP;
    public int MP;
    public int ATK;
    public int Armor;
    public int bonusHP;
    public int bonusMP;
    public int bonusATK;
    public int bonusArmor;

    public static PlayerInfo player { get; set; }


    private void Start()
    {
        if(player == null)
        {
            player = this;
        }

    }



}


