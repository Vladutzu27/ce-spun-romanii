﻿using UnityEngine;
using TMPro;

public class SplashScript : MonoBehaviour
{
    [SerializeField]

    private string[] splashes;
    public TextMeshProUGUI splash;

    void Awake()
    {
        splashes = new string[]
            {
                "DEFINITIVE EDITION",
                "AS SEEN ON DOIZERO",
                "AS SEEN ON R/PROGRAMARE",
                "AS SEEN ON YOUTUBE",
                "COMPLET NEOFICIAL",
                "CAȘCABRAL",
                "CU CAAAABRAAALLL",
                "AM ÎNTREBAT O SUTĂ DE ROMÂNI",
                "COMPLET OPEN SOURCE",
                "CIUPERCI CU SMÂNTÂNĂ",
                "UN CÂINE?",
            };
    }

    void Start()
    {
        splash.text = GetSplash();
        Debug.Log(GetSplash());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            splash.text = GetSplash();
        }
    }

    public string GetSplash()
    {
        return splashes[Random.Range(0, splashes.Length)];
    }
}