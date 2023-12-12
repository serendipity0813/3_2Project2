using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionUIBtn : MonoBehaviour
{
    public GameObject Info;
    public GameObject OptionUI;
    
    public void OptionOn()
    {
        OptionUI.SetActive(true);
        Info.SetActive(false);
    }

    public void OptionOff()
    {
        OptionUI.SetActive(false);
        Info.SetActive(true);
    }

}
