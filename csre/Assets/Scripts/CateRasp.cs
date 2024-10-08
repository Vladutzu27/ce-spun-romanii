using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CateRasp : MonoBehaviour
{
    public GameObject ans6;
    public GameObject ans7;

    public int Cate;

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
                    ans6.SetActive(true);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true);
                    Numere.instance.opt.SetActive(false);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.sapte.SetActive(true);
                Numere.instance.opt.SetActive(true);
                Cate = 8;
            }
        }
        else if (x == 2)
        {
            if (JSONScript.instance.q2a8 == "")
            {
                if (JSONScript.instance.q2a7 == "")
                {
                    ans6.SetActive(true);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true);
                    Numere.instance.opt.SetActive(false);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.sapte.SetActive(true);
                Numere.instance.opt.SetActive(true);
                Cate = 8;
            }
        }
        if (x == 3)
        {
            if (JSONScript.instance.q3a8 == "")
            {
                if (JSONScript.instance.q3a7 == "")
                {
                    ans6.SetActive(true);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true);
                    Numere.instance.opt.SetActive(false);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.sapte.SetActive(true);
                Numere.instance.opt.SetActive(true);
                Cate = 8;
            }
        }
        if (x == 4)
        {
            if (JSONScript.instance.q4a8 == "")
            {
                if (JSONScript.instance.q4a7 == "")
                {
                    ans6.SetActive(true);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true);
                    Numere.instance.opt.SetActive(false);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.opt.SetActive(true);
                Numere.instance.sapte.SetActive(true);
                Cate = 8;
            }
        }
        if (x == 5)
        {
            if (JSONScript.instance.q5a8 == "")
            {
                if (JSONScript.instance.q5a7 == "")
                {
                    ans6.SetActive(true);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true);
                    Numere.instance.opt.SetActive(false);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.sapte.SetActive(true);
                Numere.instance.opt.SetActive(true);
                Cate = 8;
            }
        }
        if (x == 6)
        {
            if (JSONScript.instance.q6a8 == "")
            {
                if (JSONScript.instance.q6a7 == "")
                {
                    ans6.SetActive(true);
                    Numere.instance.sapte.SetActive(false);
                    Numere.instance.opt.SetActive(false);
                    Cate = 6;
                }
                else
                {
                    ans7.SetActive(true);
                    Numere.instance.opt.SetActive(false);
                    Cate = 7;
                }
            }
            else
            {
                ans6.SetActive(false);
                ans7.SetActive(false);
                Numere.instance.sapte.SetActive(true);
                Numere.instance.opt.SetActive(true);
                Cate = 8;
            }
        }
    }
}