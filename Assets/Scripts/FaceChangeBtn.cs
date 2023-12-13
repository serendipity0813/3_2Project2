using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceChangeBtn : MonoBehaviour
{
    public GameObject NormalFace;
    public GameObject AngryFace;
    public GameObject SurprisedFace;
    public GameObject SuperAngryFace;
    public GameObject UI;

    public void EquipNormalFace()
    {
        NormalFace.SetActive(true);
        AngryFace.SetActive(false);
        SurprisedFace.SetActive(false);
        SuperAngryFace.SetActive(false);
        UI.SetActive(true);
    }

    public void EquipAngryFace()
    {
        NormalFace.SetActive(false);
        AngryFace.SetActive(true);
        SurprisedFace.SetActive(false);
        SuperAngryFace.SetActive(false);
        UI.SetActive(true);
    }

    public void EquipSurprisedFace()
    {
        NormalFace.SetActive(false);
        AngryFace.SetActive(false);
        SurprisedFace.SetActive(true);
        SuperAngryFace.SetActive(false);
        UI.SetActive(true);
    }

    public void EquipSuperAngryFace()
    {
        NormalFace.SetActive(false);
        AngryFace.SetActive(false);
        SurprisedFace.SetActive(false);
        SuperAngryFace.SetActive(true);
        UI.SetActive(true);
    }

}
