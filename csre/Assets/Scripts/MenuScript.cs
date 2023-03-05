using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public AudioSource muzica;

    void Start()
    {
        PlayerPrefs.SetInt("MuzicaBool", true ? 1 : 0);
        PlayerPrefs.SetInt("OftatBool", false ? 1 : 0);
        PlayerPrefs.SetInt("SFXBool", true ? 1 : 0);
        PlayerPrefs.SetInt("FullscreenBool", true ? 1 : 0);
        if (PlayerPrefs.GetInt("MuzicaBool") == 1)
        {
            muzica.Play();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SelectQuestion");
        UnityEngine.Debug.Log("Jocul a inceput");
    }

    public void Options()
    {
        SceneManager.LoadScene("Setări");
    }
    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
}
