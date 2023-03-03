using UnityEngine;
using System.IO;
using System;

public class JSONScript : MonoBehaviour
{

    public static JSONScript instance;
    public TextAsset jsonFile;

    void Awake()
    {
        instance = this;

        string jsonString = jsonFile.text;
        MyData myData = JsonUtility.FromJson<MyData>(jsonString);
        q1a1 = myData.q1.a1;
        q1a2 = myData.q1.a2;
        q1a3 = myData.q1.a3;
        q1a4 = myData.q1.a4;
        q1a5 = myData.q1.a5;
        q1a6 = myData.q1.a6;
        q1a7 = myData.q1.a7;
        q1a8 = myData.q1.a8;
        q2a1 = myData.q2.a1;
        q2a2 = myData.q2.a2;
        q2a3 = myData.q2.a3;
        q2a4 = myData.q2.a4;
        q2a5 = myData.q2.a5;
        q2a6 = myData.q2.a6;
        q2a7 = myData.q2.a7;
        q2a8 = myData.q2.a8;
        q3a1 = myData.q3.a1;
        q3a2 = myData.q3.a2;
        q3a3 = myData.q3.a3;
        q3a4 = myData.q3.a4;
        q3a5 = myData.q3.a5;
        q3a6 = myData.q3.a6;
        q3a7 = myData.q3.a7;
        q3a8 = myData.q3.a8;
        q4a1 = myData.q4.a1;
        q4a2 = myData.q4.a2;
        q4a3 = myData.q4.a3;
        q4a4 = myData.q4.a4;
        q4a5 = myData.q4.a5;
        q4a6 = myData.q4.a6;
        q4a7 = myData.q4.a7;
        q4a8 = myData.q4.a8;
        q5a1 = myData.q5.a1;
        q5a2 = myData.q5.a2;
        q5a3 = myData.q5.a3;
        q5a4 = myData.q5.a4;
        q5a5 = myData.q5.a5;
        q5a6 = myData.q5.a6;
        q5a7 = myData.q5.a7;
        q5a8 = myData.q5.a8;
        q6a1 = myData.q6.a1;
        q6a2 = myData.q6.a2;
        q6a3 = myData.q6.a3;
        q6a4 = myData.q6.a4;
        q6a5 = myData.q6.a5;
        q6a6 = myData.q6.a6;
        q6a7 = myData.q6.a7;
        q6a8 = myData.q6.a8;
        q1q = myData.q1.q;
        q2q = myData.q2.q;
        q3q = myData.q3.q;
        q4q = myData.q4.q;
        q5q = myData.q5.q;
        q6q = myData.q6.q;
    }

    public string decoi = "OO";

    public string q1a1;
    public string q1a2;
    public string q1a3;
    public string q1a4;
    public string q1a5;
    public string q1a6;
    public string q1a7;
    public string q1a8;
    public string q2a1;
    public string q2a2;
    public string q2a3;
    public string q2a4;
    public string q2a5;
    public string q2a6;
    public string q2a7;
    public string q2a8;
    public string q3a1;
    public string q3a2;
    public string q3a3;
    public string q3a4;
    public string q3a5;
    public string q3a6;
    public string q3a7;
    public string q3a8;
    public string q4a1;
    public string q4a2;
    public string q4a3;
    public string q4a4;
    public string q4a5;
    public string q4a6;
    public string q4a7;
    public string q4a8;
    public string q5a1;
    public string q5a2;
    public string q5a3;
    public string q5a4;
    public string q5a5;
    public string q5a6;
    public string q5a7;
    public string q5a8;
    public string q6a1;
    public string q6a2;
    public string q6a3;
    public string q6a4;
    public string q6a5;
    public string q6a6;
    public string q6a7;
    public string q6a8;
    public string q1q;
    public string q2q;
    public string q3q;
    public string q4q;
    public string q5q;
    public string q6q;

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
}