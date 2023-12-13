using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Itemtype
{
    Helmet,
    Weapon,
    Shield,
    Armor,
    Face,
}


[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    public string description;
    public Itemtype type;
    public float attack;
    public float HP;
    public float MP;
    public float armor;

}

