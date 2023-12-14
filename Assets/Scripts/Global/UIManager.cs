using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] private Text HpTxt;
    [SerializeField] private Text MpTxt;
    [SerializeField] private Text AtkTxt;
    [SerializeField] private Text ArmorTxt;
    [SerializeField] private Slider HpSlider;
    [SerializeField] private Slider MpSlider;
    [SerializeField] private Slider AtkSlider;
    [SerializeField] private Slider ArmorSlider;


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
        StatSetting();
        GetPercentage();
    }

    private void Update()
    {
        UpdateUI();
    }

    void StatSetting()
    {
        playerHp = PlayerInfo.player.HP;
        playerMp = PlayerInfo.player.MP;
        playerAtk = PlayerInfo.player.ATK;
        playerArmor = PlayerInfo.player.Armor;
    }

    void GetPercentage()
    {
        HpSlider.value = (playerHp / (float)MaxHp) * 100;
        MpSlider.value = Mathf.Round(playerMp / MaxMp);
        AtkSlider.value = Mathf.Round(playerAtk / MaxAtk);
        ArmorSlider.value = Mathf.Round(playerArmor / MaxArmor);
    }

    void UpdateUI()
    {
        HpTxt.text = "HP : " + playerHp.ToString() + " / " + MaxHp.ToString();
        HpTxt.text = "MP : " + playerMp.ToString() + " / " + MaxMp.ToString();
        HpTxt.text = "Atk : " + playerAtk.ToString() + " / " + MaxAtk.ToString();
        HpTxt.text = "Armor : " + playerArmor.ToString() + " / " + MaxArmor.ToString();

    }



}
