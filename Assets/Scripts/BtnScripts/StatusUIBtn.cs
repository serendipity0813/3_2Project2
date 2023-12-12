using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusUIBtn : MonoBehaviour
{
    public GameObject Info;
    public GameObject StatusUI;


    // Start is called before the first frame update
    public void StatusOn()
    {
        StatusUI.SetActive(true);
        Info.SetActive(false);
    }

    public void StatusOff()
    {
        StatusUI.SetActive(false);
        Info.SetActive(true);
    }



}
