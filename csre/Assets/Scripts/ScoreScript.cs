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
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q1[1]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q2[1]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q3[1]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q4[1]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q5[1]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q6[1]), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q1[2]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q2[2]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q3[2]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q4[2]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q5[2]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q6[2]), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q1[3]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q2[3]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q3[3]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q4[3]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q5[3]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q6[3]), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q1[4]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q2[4]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q3[4]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q4[4]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q5[4]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q6[4]), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q1[5]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q2[5]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q3[5]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q4[5]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q5[5]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q6[5]), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q1[6]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q2[6]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q3[6]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q4[6]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q5[6]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q6[6]), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q1[7]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q2[7]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q3[7]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q4[7]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q5[7]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q6[7]), out z);
                AddPoints(z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            if (MainScript.instance.question == 1 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q1[8]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 2 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q2[8]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 3 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q3[8]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 4 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q4[8]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 5 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q5[8]), out z);
                AddPoints(z);
            }
            if (MainScript.instance.question == 6 && Safe == false)
            {
                int.TryParse(TextScript.instance.GetScore(Raspunsuri.instance.Q6[8]), out z);
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