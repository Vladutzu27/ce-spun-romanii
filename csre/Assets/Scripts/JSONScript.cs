using UnityEngine;
using System.IO;
using System;

public class JSONScript : MonoBehaviour
{
    [NonSerialized]
    public string filePath = "Assets/S6E210.json";

    [System.Serializable]
    public class MyData
    {
        public Question q1;
        public Question q2;
        public Question q3;
        public Question q4;
        public Question q5;
        public Question q6;
    }

    [System.Serializable]
    public class Question
    {
        public string q;
        public string a1;
        public string a2;
        public string a3;
        public string a4;
        public string a5;
        public string a6;
        public string a7;
        public string a8;
    }

    void Start()
    {
        string jsonString = File.ReadAllText(filePath);
        MyData myData = JsonUtility.FromJson<MyData>(jsonString);

        Debug.Log(myData.q1.q);
        Debug.Log(myData.q1.a1);
        Debug.Log(myData.q1.a2);
        Debug.Log(myData.q1.a3);
    }
}