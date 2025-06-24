using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    public GameObject butonOftat;
    public GameObject butonTitrare;
    public GameObject butonMult;
    public GameObject Myself;

    public bool oftat;
    public bool titrare;
    public bool mult;

    public static SettingsScript instance;

    void Awake()
    {
        instance = this;
        oftat = false;
        titrare = false;
        PlayerPrefs.SetInt("oftat", 0);
        PlayerPrefs.SetInt("titrare", 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            butonOftat.GetComponent<Image>().color = new Color32(180, 180, 180, 255);
            UnityEngine.Debug.Log("S-a oprit butonul");
        }
    }

    public void Oftat()
    {
        oftat = !oftat;
        PlayerPrefs.SetInt("oftat", oftat ? 1 : 0);
        if (oftat)
            butonOftat.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        else
            butonOftat.GetComponent<Image>().color = new Color32(180, 180, 180, 255);
    }

    public void Titrare()
    {
        UnityEngine.Debug.Log("Tirare");
        titrare = !titrare;
        PlayerPrefs.SetInt("titrare", titrare ? 1 : 0);
        if (titrare)
            butonTitrare.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        else
            butonTitrare.GetComponent<Image>().color = new Color32(180, 180, 180, 255);
    }

    public void MultiplierUI()
    {UnityEngine.Debug.Log("Mult");
        mult = !mult;
        PlayerPrefs.SetInt("mult", mult ? 1 : 0);
        UnityEngine.Debug.Log("Mult este" + PlayerPrefs.GetInt("mult"));
        if (mult)
            butonMult.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        else
            butonMult.GetComponent<Image>().color = new Color32(180, 180, 180, 255);

    }

    public void KillMyself()
    {
        Myself.SetActive(false);
    }
}