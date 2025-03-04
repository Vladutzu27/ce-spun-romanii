using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CateRasp : MonoBehaviour
{
    public GameObject ans6; // <- 
    public GameObject ans7; // <- Obiectele imaginilor din fundal
    public GameObject ans8; // <-

    public int Cate; //Variabila pe care o citesc alte scripturi din instance pentru a primi numarul de raspunsuri pe care le are intrebarea

    public static CateRasp instance;

    void Awake()
    {
        instance = this;
    }

    public void CateRaspunsuri(int x)
    {
        if (x == 1)
        {
            if (JSONScript.instance.q1a8 == "")
            {
                if (JSONScript.instance.q1a7 == "")
                {
                    ans6.SetActive(true); ans7.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true); ans6.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.opt.SetActive(false);
                    Numere.instance.sapte.SetActive(true);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.sapte.SetActive(true);
                Numere.instance.opt.SetActive(true);
                Cate = 8; ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            }
        }
        else if (x == 2)
        {
            if (JSONScript.instance.q2a8 == "")
            {
                if (JSONScript.instance.q2a7 == "")
                {
                    ans6.SetActive(true); ans7.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true); ans6.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.opt.SetActive(false);
                    Numere.instance.sapte.SetActive(true);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.sapte.SetActive(true);
                Numere.instance.opt.SetActive(true);
                Cate = 8; ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            }
        }
        else if (x == 3)
        {
            if (JSONScript.instance.q3a8 == "")
            {
                if (JSONScript.instance.q3a7 == "")
                {
                    ans6.SetActive(true); ans7.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true); ans6.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.opt.SetActive(false);
                    Numere.instance.sapte.SetActive(true);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.sapte.SetActive(true);
                Numere.instance.opt.SetActive(true);
                Cate = 8; ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            }
        }
        else if (x == 4)
        {
            if (JSONScript.instance.q4a8 == "")
            {
                if (JSONScript.instance.q4a7 == "")
                {
                    ans6.SetActive(true); ans7.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true); ans6.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.opt.SetActive(false);
                    Numere.instance.sapte.SetActive(true);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.opt.SetActive(true);
                Numere.instance.sapte.SetActive(true);
                Cate = 8; ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            }
        }
        else if (x == 5)
        {
            if (JSONScript.instance.q5a8 == "")
            {
                if (JSONScript.instance.q5a7 == "")
                {
                    ans6.SetActive(true); ans7.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true); ans6.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.opt.SetActive(false);
                    Numere.instance.sapte.SetActive(true);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.sapte.SetActive(true);
                Numere.instance.opt.SetActive(true);
                Cate = 8; ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            }
        }
        else if (x == 6)
        {
            if (JSONScript.instance.q6a8 == "")
            {
                if (JSONScript.instance.q6a7 == "")
                {
                    ans6.SetActive(true); ans7.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true); ans6.SetActive(false); ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 0);
                    Numere.instance.opt.SetActive(false);
                    Numere.instance.sapte.SetActive(true);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.sapte.SetActive(true);
                Numere.instance.opt.SetActive(true);
                Cate = 8; ans8.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 255);
            }
        }
    }
}