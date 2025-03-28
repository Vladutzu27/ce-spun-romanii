﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Assertions;

public class TextScript : MonoBehaviour
{
    public static TextScript instance;
    List<Intrebari> intrebariList =new List<Intrebari>();
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        TextAsset intrebari = Resources.Load<TextAsset>("intrebari");

        string[] data = intrebari.text.Split(new char[] { '\n' });

        for (int i = 1; i < data.Length - 1; i++)
        {
            string[] row = data[i].Split(new char[] { ',' });

            if (row[1] == "")
            {
                Intrebari q = new Intrebari();

                q.Useless = row[0];
                q.Q1 = row[1];
                q.Q2 = row[2];
                q.Q3 = row[3];
                q.Q4 = row[4];
                q.Q5 = row[5];
                q.Q6 = row[6];

                intrebariList.Add(q);
            }
        }

        foreach (Intrebari q in intrebariList) {
            Debug.Log(q.Q1);
        }
    }
    public string GetAnswer(string x)
    {
        if (x != "")
            return x.Split('$')[0];
        else
            return "";
    }
    public string GetScore(string x)
    {
        if (x != "")
            return x.Split('$')[1];
        else
            return "";
    }

    public float GetSize(string x)
    {
        return 86.38f;
    //    if(x.Length < 14)
    //    {
    //        return 86.38f;
    //    }
    //    else
    //    {
    //        if(x.Length < 20)
    //            return 70f;
    //        if (x.Length < 25)
    //            return 60f;
    //        if (x.Length < 30)
    //            return 53f;
    //        else
    //            return 50;
    //    }
    }
}