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

    public GameObject Background;
    public Sprite ans7;
    public Sprite ans6;

    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        /*
        if (CateRasp.instance.CateRaspunsuri(1) == 8)
        {
            Background.GetComponent<SpriteRenderer>().sprite = Background.GetComponent<Sprite>();
        }
        else if (CateRasp.instance.CateRaspunsuri(1) == 7)
        {
            Background.GetComponent<SpriteRenderer>().sprite = ans7.GetComponent<Sprite>();
        }
        else if (CateRasp.instance.CateRaspunsuri(1) == 6)
        {
            Background.GetComponent<SpriteRenderer>().sprite = ans6.GetComponent<Sprite>();
        }
        */

        Q.text = JSONScript.instance.q1q;

        A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a1);
        A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a2);
        A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a3);
        A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a4);
        A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a5);
        A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a6);
        A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a7);
        A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q1a8);

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
                Q.text = JSONScript.instance.q2q;

                A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a1);
                A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a2);
                A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a3);
                A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a4);
                A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a5);
                A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a6);
                A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a7);
                A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q2a8);

                S1.text = TextScript.instance.GetScore(JSONScript.instance.q2a1);
                S2.text = TextScript.instance.GetScore(JSONScript.instance.q2a2);
                S3.text = TextScript.instance.GetScore(JSONScript.instance.q2a3);
                S4.text = TextScript.instance.GetScore(JSONScript.instance.q2a4);
                S5.text = TextScript.instance.GetScore(JSONScript.instance.q2a5);
                S6.text = TextScript.instance.GetScore(JSONScript.instance.q2a6);
                S7.text = TextScript.instance.GetScore(JSONScript.instance.q2a7);
                S8.text = TextScript.instance.GetScore(JSONScript.instance.q2a8);

                question++;
            }
            else if (question == 2)
            {
                Q.text = JSONScript.instance.q3q;

                A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a1);
                A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a2);
                A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a3);
                A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a4);
                A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a5);
                A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a6);
                A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a7);
                A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q3a8);

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

                A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a1);
                A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a2);
                A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a3);
                A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a4);
                A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a5);
                A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a6);
                A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a7);
                A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q4a8);

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

                A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a1);
                A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a2);
                A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a3);
                A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a4);
                A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a5);
                A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a6);
                A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a7);
                A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q5a8);

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

                A1.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a1);
                A2.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a2);
                A3.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a3);
                A4.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a4);
                A5.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a5);
                A6.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a6);
                A7.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a7);
                A8.text = TextScript.instance.GetAnswer(JSONScript.instance.q6a8);

                S1.text = TextScript.instance.GetScore(JSONScript.instance.q6a2);
                S2.text = TextScript.instance.GetScore(JSONScript.instance.q6a1);
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
}