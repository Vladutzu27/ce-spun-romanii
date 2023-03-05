using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SettingsScript : MonoBehaviour
{
    public GameObject Muzica;
    public GameObject Oftat;
    public GameObject SFX;
    public GameObject Fullscreen;
    public GameObject VolumObject;
    public static bool MuzicaBool = true;
    public static bool OftatBool;
    public static bool SFXBool = true;
    public static bool FullscreenBool = true;
    public static float VolumFloat = 1f;
    public AudioSource on;
    public AudioSource off;
    public static SettingsScript instance;

    void Awake()
    {
        instance = this;
        Muzica.SetActive(MuzicaBool);
        Oftat.SetActive(OftatBool);
        SFX.SetActive(SFXBool);
        Fullscreen.SetActive(FullscreenBool);
        PlayerPrefs.SetInt("MuzicaBool", MuzicaBool ? 1 : 0);
        PlayerPrefs.SetInt("OftatBool", MuzicaBool ? 1 : 0);
        PlayerPrefs.SetInt("SFXBool", MuzicaBool ? 1 : 0);
        PlayerPrefs.SetInt("FullscreenBool", MuzicaBool ? 1 : 0);
    }

    void Update()
    {
        UnityEngine.Debug.Log(MuzicaBool + " " + OftatBool + " " + SFXBool + " " + FullscreenBool + " " + VolumFloat);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Meniu");
    }

    public void Volum()
    {
        AudioListener.volume = VolumFloat;
    }

    public void MuzicaOn()
    {
        if (MuzicaBool)
        {
            Muzica.SetActive(false);
        }
        else
        {
            Muzica.SetActive(true);
        }
        MuzicaBool = !MuzicaBool;
        PlayerPrefs.SetInt("MuzicaBool", MuzicaBool ? 1 : 0);
        UnityEngine.Debug.Log("Muzica");
        if(MuzicaBool)
        {
            on.Play();
        }
        else
        {
            off.Play();
        }
    }

    public void OftatOn()
    {
        if (OftatBool)
        {
            Oftat.SetActive(false);
        }
        else
        {
            Oftat.SetActive(true);
        }
        OftatBool = !OftatBool;
        PlayerPrefs.SetInt("OftatBool", OftatBool ? 1 : 0);
        UnityEngine.Debug.Log("Oftat");
        if(OftatBool)
        {
            on.Play();
        }
        else
        {
            off.Play();
        }
    }

    public void SFXOn()
    {
        if (SFXBool)
        {
            SFX.SetActive(false);
        }
        else
        {
            SFX.SetActive(true);
        }
        SFXBool = !SFXBool;
        PlayerPrefs.SetInt("SFXBool", SFXBool ? 1 : 0);

        UnityEngine.Debug.Log("SFX");
        if(SFXBool)
        {
            on.Play();
        }
        else
        {
            off.Play();
        }
    }

    public void FullscreenOn()
    {
        if (FullscreenBool)
        {
            Fullscreen.SetActive(false);
        }
        else
        {
            Fullscreen.SetActive(true);
        }
        FullscreenBool = !FullscreenBool;
        PlayerPrefs.SetInt("FullscreenBool", FullscreenBool ? 1 : 0);
        UnityEngine.Debug.Log("Fullscreen");
        if(FullscreenBool)
        {
            on.Play();
        }
        else
        {
            off.Play();
        }
    }
}