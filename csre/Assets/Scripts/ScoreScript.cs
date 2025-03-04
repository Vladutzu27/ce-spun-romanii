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

    public bool unuLuat = false;
    public bool doiLuat = false;
    public bool treiLuat = false;
    public bool patruLuat = false;
    public bool cinciLuat = false;
    public bool saseLuat = false;
    public bool sapteLuat = false;
    public bool optLuat = false;

    public void PuneLaLoc()
    {
        unuLuat = false;
        doiLuat = false;
        treiLuat = false;
        patruLuat = false;
        cinciLuat = false;
        saseLuat = false;
        sapteLuat = false;
        optLuat = false;
    }

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
            if (MainScript.instance.question == 1 && !Safe && !unuLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q1a1), out z);
                AddPoints(z);
                unuLuat = true;
            }
            if (MainScript.instance.question == 2 && !Safe && !unuLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q2a1), out z);
                AddPoints(z);
                unuLuat = true;
            }
            if (MainScript.instance.question == 3 && !Safe && !unuLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q3a1), out z);
                AddPoints(z);
                unuLuat = true;
            }
            if (MainScript.instance.question == 4 && !Safe && !unuLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q4a1), out z);
                AddPoints(z);
                unuLuat = true;
            }
            if (MainScript.instance.question == 5 && !Safe && !unuLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q5a1), out z);
                AddPoints(z);
                unuLuat = true;
            }
            if (MainScript.instance.question == 6 && !Safe && !unuLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q6a1), out z);
                AddPoints(z);
                unuLuat = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (MainScript.instance.question == 1 && !Safe && !doiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q1a2), out z);
                AddPoints(z);
                doiLuat = true;
            }
            if (MainScript.instance.question == 2 && !Safe && !doiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q2a2), out z);
                AddPoints(z);
                doiLuat = true;
            }
            if (MainScript.instance.question == 3 && !Safe && !doiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q3a2), out z);
                AddPoints(z);
                doiLuat = true;
            }
            if (MainScript.instance.question == 4 && !Safe && !doiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q4a2), out z);
                AddPoints(z);
                doiLuat = true;
            }
            if (MainScript.instance.question == 5 && !Safe && !doiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q5a2), out z);
                AddPoints(z);
                doiLuat = true;
            }
            if (MainScript.instance.question == 6 && !Safe && !doiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q6a2), out z);
                AddPoints(z);
                doiLuat = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (MainScript.instance.question == 1 && !Safe && !treiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q1a3), out z);
                AddPoints(z);
                treiLuat = true;
            }
            if (MainScript.instance.question == 2 && !Safe && !treiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q2a3), out z);
                AddPoints(z);
                treiLuat = true;
            }
            if (MainScript.instance.question == 3 && !Safe && !treiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q3a3), out z);
                AddPoints(z);
                treiLuat = true;
            }
            if (MainScript.instance.question == 4 && !Safe && !treiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q4a3), out z);
                AddPoints(z);
                treiLuat = true;
            }
            if (MainScript.instance.question == 5 && !Safe && !treiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q5a3), out z);
                AddPoints(z);
                treiLuat = true;
            }
            if (MainScript.instance.question == 6 && !Safe && !treiLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q6a3), out z);
                AddPoints(z);
                treiLuat = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (MainScript.instance.question == 1 && !Safe && !patruLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q1a4), out z);
                AddPoints(z);
                patruLuat = true;
            }
            if (MainScript.instance.question == 2 && !Safe && !patruLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q2a4), out z);
                AddPoints(z);
                patruLuat = true;
            }
            if (MainScript.instance.question == 3 && !Safe && !patruLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q3a4), out z);
                AddPoints(z);
                patruLuat = true;
            }
            if (MainScript.instance.question == 4 && !Safe && !patruLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q4a4), out z);
                AddPoints(z);
                patruLuat = true;
            }
            if (MainScript.instance.question == 5 && !Safe && !patruLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q5a4), out z);
                AddPoints(z);
                patruLuat = true;
            }
            if (MainScript.instance.question == 6 && !Safe && !patruLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q6a4), out z);
                AddPoints(z);
                patruLuat = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (MainScript.instance.question == 1 && !Safe && !cinciLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q1a5), out z);
                AddPoints(z);
                cinciLuat = true;
            }
            if (MainScript.instance.question == 2 && !Safe && !cinciLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q2a5), out z);
                AddPoints(z);
                cinciLuat = true;
            }
            if (MainScript.instance.question == 3 && !Safe && !cinciLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q3a5), out z);
                AddPoints(z);
                cinciLuat = true;
            }
            if (MainScript.instance.question == 4 && !Safe && !cinciLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q4a5), out z);
                AddPoints(z);
                cinciLuat = true;
            }
            if (MainScript.instance.question == 5 && !Safe && !cinciLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q5a5), out z);
                AddPoints(z);
                cinciLuat = true;
            }
            if (MainScript.instance.question == 6 && !Safe && !cinciLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q6a5), out z);
                AddPoints(z);
                cinciLuat = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            if (MainScript.instance.question == 1 && !Safe && !saseLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q1a6), out z);
                AddPoints(z);
                saseLuat = true;
            }
            if (MainScript.instance.question == 2 && !Safe && !saseLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q2a6), out z);
                AddPoints(z);
                saseLuat = true;
            }
            if (MainScript.instance.question == 3 && !Safe && !saseLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q3a6), out z);
                AddPoints(z);
                saseLuat = true;
            }
            if (MainScript.instance.question == 4 && !Safe && !saseLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q4a6), out z);
                AddPoints(z);
                saseLuat = true;
            }
            if (MainScript.instance.question == 5 && !Safe && !saseLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q5a6), out z);
                AddPoints(z);
                saseLuat = true;
            }
            if (MainScript.instance.question == 6 && !Safe && !saseLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q6a6), out z);
                AddPoints(z);
                saseLuat = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            if (MainScript.instance.question == 1 && !Safe && !sapteLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q1a7), out z);
                AddPoints(z);
                sapteLuat = true;
            }
            if (MainScript.instance.question == 2 && !Safe && !sapteLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q2a7), out z);
                AddPoints(z);
                sapteLuat = true;
            }
            if (MainScript.instance.question == 3 && !Safe && !sapteLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q3a7), out z);
                AddPoints(z);
                sapteLuat = true;
            }
            if (MainScript.instance.question == 4 && !Safe && !sapteLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q4a7), out z);
                AddPoints(z);
                sapteLuat = true;
            }
            if (MainScript.instance.question == 5 && !Safe && !sapteLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q5a7), out z);
                AddPoints(z);
                sapteLuat = true;
            }
            if (MainScript.instance.question == 6 && !Safe && !sapteLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q6a7), out z);
                AddPoints(z);
                sapteLuat = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            if (MainScript.instance.question == 1 && !Safe && !optLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q1a8), out z);
                AddPoints(z);
                optLuat = true;
            }
            if (MainScript.instance.question == 2 && !Safe && !optLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q2a8), out z);
                AddPoints(z);
                optLuat = true;
            }
            if (MainScript.instance.question == 3 && !Safe && !optLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q3a8), out z);
                AddPoints(z);
                optLuat = true;
            }
            if (MainScript.instance.question == 4 && !Safe && !optLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q4a8), out z);
                AddPoints(z);
                optLuat = true;
            }
            if (MainScript.instance.question == 5 && !Safe && !optLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q5a8), out z);
                AddPoints(z);
                optLuat = true;
            }
            if (MainScript.instance.question == 6 && !Safe && !optLuat)
            {
                int.TryParse(TextScript.instance.GetScore(JSONScript.instance.q6a8), out z);
                AddPoints(z);
                optLuat = true;
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
            PuneLaLoc();
        }
    }

    public void AddPoints(int x)
    {
        x = x * MainScript.instance.mult;
        int.TryParse(Points.text, out y);
        Points.text = (y + x).ToString();
    }
}