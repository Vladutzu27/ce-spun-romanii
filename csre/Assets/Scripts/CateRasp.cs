using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CateRasp : MonoBehaviour
{
    public static CateRasp instance;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int CateRaspunsuri(int x)
    {
        if (x == 1)
        {
            if (JSONScript.instance.q1a8 == "")
            {
                if (JSONScript.instance.q1a7 == "")
                {
                    if (JSONScript.instance.q1a6 == "")
                    {
                        Debug.Log("Error: Less then 5 answers to the question, some features might not work correctly");
                        return 69;
                    }
                    else
                    {
                        return 6;
                    }
                }
                else
                {
                    return 7;
                }
            }
            else
            {
                return 8;
            }
        }
        if (x == 2)
        {
            if (JSONScript.instance.q2a8 == "")
            {
                if (JSONScript.instance.q2a7 == "")
                {
                    if (JSONScript.instance.q2a6 == "")
                    {
                        Debug.Log("Error: Less then 5 answers to the question, some features might not work correctly");
                        return 69;
                    }
                    else
                    {
                        return 6;
                    }
                }
                else
                {
                    return 7;
                }
            }
            else
            {
                return 8;
            }
        }
        if (x == 3)
        {
            if (JSONScript.instance.q3a8 == "")
            {
                if (JSONScript.instance.q3a7 == "")
                {
                    if (JSONScript.instance.q3a6 == "")
                    {
                        Debug.Log("Error: Less then 5 answers to the question, some features might not work correctly");
                        return 69;
                    }
                    else
                    {
                        return 6;
                    }
                }
                else
                {
                    return 7;
                }
            }
            else
            {
                return 8;
            }
        }
        if (x == 4)
        {
            if (JSONScript.instance.q4a8 == "")
            {
                if (JSONScript.instance.q4a7 == "")
                {
                    if (JSONScript.instance.q4a6 == "")
                    {
                        Debug.Log("Error: Less then 5 answers to the question, some features might not work correctly");
                        return 69;
                    }
                    else
                    {
                        return 6;
                    }
                }
                else
                {
                    return 7;
                }
            }
            else
            {
                return 8;
            }
        }
        if (x == 5)
        {
            if (JSONScript.instance.q5a8 == "")
            {
                if (JSONScript.instance.q5a7 == "")
                {
                    if (JSONScript.instance.q5a6 == "")
                    {
                        Debug.Log("Error: Less then 5 answers to the question, some features might not work correctly");
                        return 69;
                    }
                    else
                    {
                        return 6;
                    }
                }
                else
                {
                    return 7;
                }
            }
            else
            {
                return 8;
            }
        }
        if (x == 6)
        {
            if (JSONScript.instance.q6a8 == "")
            {
                if (JSONScript.instance.q6a7 == "")
                {
                    if (JSONScript.instance.q6a6 == "")
                    {
                        Debug.Log("Error: Less then 5 answers to the question, some features might not work correctly");
                        return 69;
                    }
                    else
                    {
                        return 6;
                    }
                }
                else
                {
                    return 7;
                }
            }
            else
            {
                return 8;
            }
        }
        else
        {
            return 69;
        }
    }
}
