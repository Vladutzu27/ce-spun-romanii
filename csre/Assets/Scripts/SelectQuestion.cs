using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using TMPro;

public class SelectQuestion : MonoBehaviour
{
    public int slot;
    public GameObject urleu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Meniu");
    }

    public void slot1()
    {
        slot = 1;
        PlayerPrefs.SetInt("slot", slot);
        SceneManager.LoadScene("Jocul");
    }
    public void slot2()
    {
        slot = 2;
        PlayerPrefs.SetInt("slot", slot);
        SceneManager.LoadScene("Jocul");
    }
    public void slot3()
    {
        slot = 3;
        PlayerPrefs.SetInt("slot", slot);
        SceneManager.LoadScene("Jocul");
    }
    public void slot4()
    {
        slot = 4;
        PlayerPrefs.SetInt("slot", slot);
        SceneManager.LoadScene("Jocul");
    }
    public void customSlot()
    {
        ImportJSON.instance.SelectJSONFile();
    }
}