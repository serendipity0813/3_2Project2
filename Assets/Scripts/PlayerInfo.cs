using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class PlayerInfo : MonoBehaviour
{
    public int HP = 50;
    public int bonusHP;
    public int MP = 50;
    public int bonusMP;
    public int ATK = 50;
    public int bonusATK;
    public int Armor = 50;
    public int bonusArmor;
    public static PlayerInfo player { get; private set; }

    private void Awake()
    {
        if (player == null)
        {
            player = this;
        }
    }

    
}
