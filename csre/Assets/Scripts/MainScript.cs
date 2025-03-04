using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Mono.Cecil.Cil;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    public static MainScript instance;

    public int question = 1;

    public AudioSource bun;
    public AudioSource bzz;
    public AudioSource jingle;

    public TextMeshProUGUI Q;

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

    //mult vine de la multiplier, nu este opusul lui puțin
    public int mult;
    public GameObject multObject;
    public TextMeshProUGUI multText;
    public AudioSource mult1;
    public AudioSource mult2;
    public AudioSource mult3;

    public GameObject titrare;


    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    public int CateIntrebariAvem()
    {
        if (JSONScript.instance.q1a1 != "")
        {
            if (JSONScript.instance.q2a1 != "")
            {
                if (JSONScript.instance.q3a1 != "")
                {
                    if (JSONScript.instance.q4a1 != "")
                    {
                        if (JSONScript.instance.q5a1 != "")
                        {
                            if (JSONScript.instance.q6a1 != "")
                            {
                                return 6;
                            }
                            else
                                return 5;
                        }
                        else
                            return 4;
                    }
                    else
                        return 3;
                }
                else
                    return 2;
            }
            else
                return 1;
        }
        else
            return 0;
    }

    void Start()
    {
        if (PlayerPrefs.GetInt("titrare") == 0)
            titrare.SetActive(false);

        mult = 1;

        Debug.Log("Avem " + CateIntrebariAvem() + " intrebari");
        Debug.Log("Question este egal cu " + question + ".");
        Q.text = JSONScript.instance.q1q;

        CateRasp.instance.CateRaspunsuri(1);

        A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a1);
        A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a2);
        A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a3);
        A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a4);
        A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a5);
        A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a6);
        A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a7);
        A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a8);
        //A1.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q1a1));
        //A2.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q1a2));
        //A3.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q1a3));
        //A4.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q1a4));
        //A5.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q1a5));
        //A6.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q1a6));
        //A7.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q1a7));
        //A8.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q1a8));

        S1.text = TextScript.instance.GetScore(JSONScript.instance.q1a1);
        S2.text = TextScript.instance.GetScore(JSONScript.instance.q1a2);
        S3.text = TextScript.instance.GetScore(JSONScript.instance.q1a3);
        S4.text = TextScript.instance.GetScore(JSONScript.instance.q1a4);
        S5.text = TextScript.instance.GetScore(JSONScript.instance.q1a5);
        S6.text = TextScript.instance.GetScore(JSONScript.instance.q1a6);
        S7.text = TextScript.instance.GetScore(JSONScript.instance.q1a7);
        S8.text = TextScript.instance.GetScore(JSONScript.instance.q1a8);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && !ScoreScript.instance.unuLuat)
            bun.Play();
        if (Input.GetKeyDown(KeyCode.Alpha2) && !ScoreScript.instance.doiLuat)
            bun.Play();
        if (Input.GetKeyDown(KeyCode.Alpha3) && !ScoreScript.instance.treiLuat)
            bun.Play();
        if (Input.GetKeyDown(KeyCode.Alpha4) && !ScoreScript.instance.patruLuat)
            bun.Play();
        if (Input.GetKeyDown(KeyCode.Alpha5) && !ScoreScript.instance.cinciLuat)
            bun.Play();
        if (Input.GetKeyDown(KeyCode.Alpha6) && !ScoreScript.instance.saseLuat)
            bun.Play();
        if (Input.GetKeyDown(KeyCode.Alpha7) && !ScoreScript.instance.sapteLuat && CateRasp.instance.Cate > 6)
            bun.Play();
        if (Input.GetKeyDown(KeyCode.Alpha8) && !ScoreScript.instance.optLuat && CateRasp.instance.Cate > 7)
            bun.Play();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (PlayerPrefs.GetInt("MuzicaBool") == 1)
            {
                Debug.Log("jingle");
                jingle.Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
            Debug.Log("Question este la momentul apăsării egal cu " + question + ".");

        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Meniu");

        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            StartCoroutine(Mult(false));
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            StartCoroutine(Mult(true));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            mult = 1;
            if (CateIntrebariAvem() == question)
                SceneManager.LoadScene("Meniu");
            CateRasp.instance.CateRaspunsuri(question + 1);
            Debug.Log("Avem " + CateIntrebariAvem() + " intrebari");
            Debug.Log("Question este egal cu " + question + ".");
            Numere.instance.PuneLaLoc();
            RaspunsuriScript.instance.Ascunde();
            if (question == 1) 
            {
                Q.text = JSONScript.instance.q2q;

                CateRasp.instance.CateRaspunsuri(2);

                A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a1);
                A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a2);
                A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a3);
                A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a4);
                A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a5);
                A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a6);
                A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a7);
                A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a8);
                //A1.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q2a1));
                //A2.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q2a2));
                //A3.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q2a3));
                //A4.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q2a4));
                //A5.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q2a5));
                //A6.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q2a6));
                //A7.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q2a7));
                //A8.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q2a8));

                S1.text = TextScript.instance.GetScore(JSONScript.instance.q2a1);
                S2.text = TextScript.instance.GetScore(JSONScript.instance.q2a2);
                S3.text = TextScript.instance.GetScore(JSONScript.instance.q2a3);
                S4.text = TextScript.instance.GetScore(JSONScript.instance.q2a4);
                S5.text = TextScript.instance.GetScore(JSONScript.instance.q2a5);
                S6.text = TextScript.instance.GetScore(JSONScript.instance.q2a6);
                S7.text = TextScript.instance.GetScore(JSONScript.instance.q2a7);
                S8.text = TextScript.instance.GetScore(JSONScript.instance.q2a8);

                question++;
                Debug.Log("Ar trebui să se fi mărit!");
            }
            else if (question == 2)
            {
                Q.text = JSONScript.instance.q3q;

                CateRasp.instance.CateRaspunsuri(3);

                A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a1);
                A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a2);
                A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a3);
                A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a4);
                A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a5);
                A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a6);
                A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a7);
                A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a8);
                //A1.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q3a1));
                //A2.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q3a2));
                //A3.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q3a3));
                //A4.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q3a4));
                //A5.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q3a5));
                //A6.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q3a6));
                //A7.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q3a7));
                //A8.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q3a8));

                S1.text = TextScript.instance.GetScore(JSONScript.instance.q3a1);
                S2.text = TextScript.instance.GetScore(JSONScript.instance.q3a2);
                S3.text = TextScript.instance.GetScore(JSONScript.instance.q3a3);
                S4.text = TextScript.instance.GetScore(JSONScript.instance.q3a4);
                S5.text = TextScript.instance.GetScore(JSONScript.instance.q3a5);
                S6.text = TextScript.instance.GetScore(JSONScript.instance.q3a6);
                S7.text = TextScript.instance.GetScore(JSONScript.instance.q3a7);
                S8.text = TextScript.instance.GetScore(JSONScript.instance.q3a8);

                question++;
            }
            else if(question == 3)
            {
                Q.text = JSONScript.instance.q4q;

                CateRasp.instance.CateRaspunsuri(4);

                A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a1);
                A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a2);
                A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a3);
                A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a4);
                A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a5);
                A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a6);
                A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a7);
                A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a8);
                //A1.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q4a1));
                //A2.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q4a2));
                //A3.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q4a3));
                //A4.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q4a4));
                //A5.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q4a5));
                //A6.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q4a6));
                //A7.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q4a7));
                //A8.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q4a8));

                S1.text = TextScript.instance.GetScore(JSONScript.instance.q4a1);
                S2.text = TextScript.instance.GetScore(JSONScript.instance.q4a2);
                S3.text = TextScript.instance.GetScore(JSONScript.instance.q4a3);
                S4.text = TextScript.instance.GetScore(JSONScript.instance.q4a4);
                S5.text = TextScript.instance.GetScore(JSONScript.instance.q4a5);
                S6.text = TextScript.instance.GetScore(JSONScript.instance.q4a6);
                S7.text = TextScript.instance.GetScore(JSONScript.instance.q4a7);
                S8.text = TextScript.instance.GetScore(JSONScript.instance.q4a8);

                question++;
            }
            else if (question == 4)
            {
                Q.text = JSONScript.instance.q5q;
                
                CateRasp.instance.CateRaspunsuri(5);

                A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a1);
                A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a2);
                A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a3);
                A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a4);
                A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a5);
                A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a6);
                A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a7);
                A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a8);
                //A1.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q5a1));
                //A2.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q5a2));
                //A3.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q5a3));
                //A4.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q5a4));
                //A5.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q5a5));
                //A6.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q5a6));
                //A7.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q5a7));
                //A8.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q5a8));


                S1.text = TextScript.instance.GetScore(JSONScript.instance.q5a1);
                S2.text = TextScript.instance.GetScore(JSONScript.instance.q5a2);
                S3.text = TextScript.instance.GetScore(JSONScript.instance.q5a3);
                S4.text = TextScript.instance.GetScore(JSONScript.instance.q5a4);
                S5.text = TextScript.instance.GetScore(JSONScript.instance.q5a5);
                S6.text = TextScript.instance.GetScore(JSONScript.instance.q5a6);
                S7.text = TextScript.instance.GetScore(JSONScript.instance.q5a7);
                S8.text = TextScript.instance.GetScore(JSONScript.instance.q5a8);

                question++;
            }
            else if (question == 5)
            {
                Q.text = JSONScript.instance.q6q;

                CateRasp.instance.CateRaspunsuri(6);

                A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a1);
                A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a2);
                A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a3);
                A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a4);
                A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a5);
                A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a6);
                A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a7);
                A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a8);
                //A1.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q6a1));
                //A2.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q6a2));
                //A3.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q6a3));
                //A4.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q6a4));
                //A5.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q6a5));
                //A6.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q6a6));
                //A7.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q6a7));
                //A8.fontSize = TextScript.instance.GetSize(TextScript.instance.GetAnswer(JSONScript.instance.q6a8));


                S1.text = TextScript.instance.GetScore(JSONScript.instance.q6a1);
                S2.text = TextScript.instance.GetScore(JSONScript.instance.q6a2);
                S3.text = TextScript.instance.GetScore(JSONScript.instance.q6a3);
                S4.text = TextScript.instance.GetScore(JSONScript.instance.q6a4);
                S5.text = TextScript.instance.GetScore(JSONScript.instance.q6a5);
                S6.text = TextScript.instance.GetScore(JSONScript.instance.q6a6);
                S7.text = TextScript.instance.GetScore(JSONScript.instance.q6a7);
                S8.text = TextScript.instance.GetScore(JSONScript.instance.q6a8);

                question++;
            }
        }
    }
    IEnumerator Mult(bool Sus)
    {
        if (Sus && mult <3)
            mult++;
        else if (!Sus && mult > 1)
            mult--;
        multObject.SetActive(true);
        multText.text = mult.ToString() + "x";
        if (mult == 1)
            mult1.Play();
        else if (mult == 2)
            mult2.Play();
        else if (mult == 3)
            mult3.Play();
        yield return new WaitForSeconds(1);
        multObject.SetActive(false);
    }
}