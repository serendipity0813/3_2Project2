using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text MoneyTxt;
    [SerializeField] private Text HpTxt;
    [SerializeField] private Text MpTxt;
    [SerializeField] private Text AtkTxt;
    [SerializeField] private Text ArmorTxt;
    [SerializeField] private Slider HpSlider;
    [SerializeField] private Slider MpSlider;
    [SerializeField] private Slider AtkSlider;
    [SerializeField] private Slider ArmorSlider;

    private int playerMoney;
    private int playerHp;
    private int playerMp;
    private int playerAtk;
    private int playerArmor;
    private int MaxHp = 500;
    private int MaxMp = 500;
    private int MaxAtk = 500;
    private int MaxArmor = 500;


    void Start()
    {
        Setting();
        GetPercentage();
    }

    private void Update()
    {
        UpdateUI();
    }

    void Setting()
    {
        playerHp = PlayerInfo.player.HP;
        playerMp = PlayerInfo.player.MP;
        playerAtk = PlayerInfo.player.ATK;
        playerArmor = PlayerInfo.player.Armor;
        playerMoney = PlayerInfo.player.Money;
    }

    void GetPercentage()
    {
        HpSlider.value = (playerHp / (float)MaxHp);
        MpSlider.value = (playerMp / (float)MaxMp);
        AtkSlider.value = (playerAtk / (float)MaxAtk);
        ArmorSlider.value = (playerArmor / (float)MaxArmor);
    }

    void UpdateUI()
    {
        HpTxt.text = "HP : " + playerHp.ToString() + " / " + MaxHp.ToString();
        MpTxt.text = "MP : " + playerMp.ToString() + " / " + MaxMp.ToString();
        AtkTxt.text = "Atk : " + playerAtk.ToString() + " / " + MaxAtk.ToString();
        ArmorTxt.text = "Armor : " + playerArmor.ToString() + " / " + MaxArmor.ToString();
        MoneyTxt.text = playerMoney.ToString();
    }



}
