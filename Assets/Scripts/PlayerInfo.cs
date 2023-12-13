using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stat
{
    [HideInInspector]
    public float curValue;
    public float maxValue;
    public float startValue = 30;
    public Image uiBar;

    public void Add(float amount)
    {
        curValue = Mathf.Min(curValue + amount, maxValue);
    }

    public float GetPercentage()
    {
        return curValue / maxValue;
    }

}

public class PlayerInfo : MonoBehaviour
{
    public Stat HP;
    public Stat MP;
    public Stat ATK;
    public Stat Armor;

    void Start()
    {
        HP.curValue = HP.startValue;
        MP.curValue = MP.startValue;
        ATK.curValue = ATK.startValue;
        Armor.curValue = Armor.startValue;

    }

    void Update()
    {
        HP.uiBar.fillAmount = HP.GetPercentage();
        MP.uiBar.fillAmount = MP.GetPercentage();
        ATK.uiBar.fillAmount = ATK.GetPercentage();
        Armor.uiBar.fillAmount = Armor.GetPercentage();
    }


}
