using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Mono.Cecil.Cil;
using Unity.VisualScripting;

public class MainScript : MonoBehaviour
{
    public static MainScript instance;

    public int question = 1;

    public AudioSource bun;
    public AudioSource bzz;
    public AudioSource jingle;
    public TextMeshProUGUI A1;
    public TextMeshProUGUI A2;
    public TextMeshProUGUI A3;
    public TextMeshProUGUI A4;
    public TextMeshProUGUI A5;
    public TextMeshProUGUI A6;
    public TextMeshProUGUI A7;
    public TextMeshProUGUI A8;

    public TextMeshProUGUI S1;
    public TextMeshProUGUI S2;
    public TextMeshProUGUI S3;
    public TextMeshProUGUI S4;
    public TextMeshProUGUI S5;
    public TextMeshProUGUI S6;
    public TextMeshProUGUI S7;
    public TextMeshProUGUI S8;

    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        A1.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q1[1]);
        A2.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q1[2]);
        A3.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q1[3]);
        A4.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q1[4]);
        A5.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q1[5]);
        A6.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q1[6]);
        A7.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q1[7]);
        A8.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q1[8]);

        S1.text = TextScript.instance.GetScore(Raspunsuri.instance.Q1[1]);
        S3.text = TextScript.instance.GetScore(Raspunsuri.instance.Q1[3]);
        S4.text = TextScript.instance.GetScore(Raspunsuri.instance.Q1[4]);
        S5.text = TextScript.instance.GetScore(Raspunsuri.instance.Q1[5]);
        S6.text = TextScript.instance.GetScore(Raspunsuri.instance.Q1[6]);
        S2.text = TextScript.instance.GetScore(Raspunsuri.instance.Q1[2]);
        S7.text = TextScript.instance.GetScore(Raspunsuri.instance.Q1[7]);
        S8.text = TextScript.instance.GetScore(Raspunsuri.instance.Q1[8]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Alpha8))
        {
            Debug.Log("Bun");
            bun.Play();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jingle.Play();
            Debug.Log("jingle");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Numere.instance.PuneLaLoc();
            RaspunsuriScript.instance.Ascunde();
            if (question == 1)
            {
                A1.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q2[1]);
                A2.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q2[2]);
                A3.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q2[3]);
                A4.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q2[4]);
                A5.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q2[5]);
                A6.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q2[6]);
                A7.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q2[7]);
                A8.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q2[8]);

                S1.text = TextScript.instance.GetScore(Raspunsuri.instance.Q2[1]);
                S3.text = TextScript.instance.GetScore(Raspunsuri.instance.Q2[3]);
                S4.text = TextScript.instance.GetScore(Raspunsuri.instance.Q2[4]);
                S5.text = TextScript.instance.GetScore(Raspunsuri.instance.Q2[5]);
                S6.text = TextScript.instance.GetScore(Raspunsuri.instance.Q2[6]);
                S2.text = TextScript.instance.GetScore(Raspunsuri.instance.Q2[2]);
                S7.text = TextScript.instance.GetScore(Raspunsuri.instance.Q2[7]);
                S8.text = TextScript.instance.GetScore(Raspunsuri.instance.Q2[8]);

                question++;
            }
            else if (question == 2)
            {
                A1.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q3[1]);
                A2.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q3[2]);
                A3.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q3[3]);
                A4.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q3[4]);
                A5.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q3[5]);
                A6.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q3[6]);
                A7.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q3[7]);
                A8.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q3[8]);

                S1.text = TextScript.instance.GetScore(Raspunsuri.instance.Q3[1]);
                S3.text = TextScript.instance.GetScore(Raspunsuri.instance.Q3[3]);
                S4.text = TextScript.instance.GetScore(Raspunsuri.instance.Q3[4]);
                S5.text = TextScript.instance.GetScore(Raspunsuri.instance.Q3[5]);
                S6.text = TextScript.instance.GetScore(Raspunsuri.instance.Q3[6]);
                S2.text = TextScript.instance.GetScore(Raspunsuri.instance.Q3[2]);
                S7.text = TextScript.instance.GetScore(Raspunsuri.instance.Q3[7]);
                S8.text = TextScript.instance.GetScore(Raspunsuri.instance.Q3[8]);

                question++;
            }
            else if(question == 3)
            {
                A1.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q4[1]);
                A2.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q4[2]);
                A3.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q4[3]);
                A4.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q4[4]);
                A5.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q4[5]);
                A6.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q4[6]);
                A7.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q4[7]);
                A8.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q4[8]);

                S1.text = TextScript.instance.GetScore(Raspunsuri.instance.Q4[1]);
                S3.text = TextScript.instance.GetScore(Raspunsuri.instance.Q4[3]);
                S4.text = TextScript.instance.GetScore(Raspunsuri.instance.Q4[4]);
                S5.text = TextScript.instance.GetScore(Raspunsuri.instance.Q4[5]);
                S6.text = TextScript.instance.GetScore(Raspunsuri.instance.Q4[6]);
                S2.text = TextScript.instance.GetScore(Raspunsuri.instance.Q4[2]);
                S7.text = TextScript.instance.GetScore(Raspunsuri.instance.Q4[7]);
                S8.text = TextScript.instance.GetScore(Raspunsuri.instance.Q4[8]);

                question++;
            }
            else if (question == 4)
            {
                A1.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q5[1]);
                A2.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q5[2]);
                A3.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q5[3]);
                A4.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q5[4]);
                A5.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q5[5]);
                A6.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q5[6]);
                A7.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q5[7]);
                A8.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q5[8]);

                S1.text = TextScript.instance.GetScore(Raspunsuri.instance.Q5[1]);
                S3.text = TextScript.instance.GetScore(Raspunsuri.instance.Q5[3]);
                S4.text = TextScript.instance.GetScore(Raspunsuri.instance.Q5[4]);
                S5.text = TextScript.instance.GetScore(Raspunsuri.instance.Q5[5]);
                S6.text = TextScript.instance.GetScore(Raspunsuri.instance.Q5[6]);
                S2.text = TextScript.instance.GetScore(Raspunsuri.instance.Q5[2]);
                S7.text = TextScript.instance.GetScore(Raspunsuri.instance.Q5[7]);
                S8.text = TextScript.instance.GetScore(Raspunsuri.instance.Q5[8]);

                question++;
            }
            else if (question == 5)
            {
                A1.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q6[1]);
                A2.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q6[2]);
                A3.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q6[3]);
                A4.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q6[4]);
                A5.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q6[5]);
                A6.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q6[6]);
                A7.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q6[7]);
                A8.text = TextScript.instance.GetAnswer(Raspunsuri.instance.Q6[8]);

                S1.text = TextScript.instance.GetScore(Raspunsuri.instance.Q6[1]);
                S3.text = TextScript.instance.GetScore(Raspunsuri.instance.Q6[3]);
                S4.text = TextScript.instance.GetScore(Raspunsuri.instance.Q6[4]);
                S5.text = TextScript.instance.GetScore(Raspunsuri.instance.Q6[5]);
                S6.text = TextScript.instance.GetScore(Raspunsuri.instance.Q6[6]);
                S2.text = TextScript.instance.GetScore(Raspunsuri.instance.Q6[2]);
                S7.text = TextScript.instance.GetScore(Raspunsuri.instance.Q6[7]);
                S8.text = TextScript.instance.GetScore(Raspunsuri.instance.Q6[8]);

                question++;
            }
        }
    }
}