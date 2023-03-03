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
        if(SettingsScript.MuzicaBool == true)
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
