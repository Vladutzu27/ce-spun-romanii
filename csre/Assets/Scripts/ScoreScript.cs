using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.Examples;
using System;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI Points;
    public TextMeshProUGUI LeftPoints;
    public TextMeshProUGUI RightPoints;

    public static ScoreScript instance;

    private int y;
    private int z;

    public bool Safe = false;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Points.text = "0";
        LeftPoints.text = "0";
        RightPoints.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q1a1), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q2a1), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q3a1), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q4a1), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q5a1), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q6a1), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q1a2), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q2a2), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q3a2), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q4a2), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q5a2), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q6a2), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q1a3), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q2a3), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q3a3), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q4a3), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q5a3), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q6a3), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q1a4), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q2a4), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q3a4), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q4a4), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q5a4), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q6a4), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q1a5), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q2a5), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q3a5), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q4a5), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q5a5), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q6a5), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q1a6), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q2a6), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q3a6), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q4a6), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q5a6), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q6a6), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q1a7), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q2a7), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q3a7), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q4a7), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q5a7), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q6a7), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q1a8), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q2a8), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q3a8), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q4a8), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q5a8), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.q6a8), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            int.TryParse(LeftPoints.text, out z);
            int.TryParse(Points.text, out y);
            LeftPoints.text = (z + y).ToString();
            Points.text = "0";
            Safe = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            int.TryParse(RightPoints.text, out z);
            int.TryParse(Points.text, out y);
            RightPoints.text = (z + y).ToString();
            Points.text = "0";
            Safe = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Points.text = "0";
            Safe = false;
        }
    }

    public void AddPoints(int x)
    {
        int.TryParse(Points.text, out y);
        Debug.Log(x.ToString() + "+" + y.ToString() + "=" + (x + y).ToString());
        Points.text = (y + x).ToString();
    }
}