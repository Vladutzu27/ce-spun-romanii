using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Numere : MonoBehaviour
{
    public static Numere instance;
    public GameObject unu;
    public GameObject doi;
    public GameObject trei;
    public GameObject patru;
    public GameObject cinci;
    public GameObject sase;
    public GameObject sapte;
    public GameObject opt;

    private void Awake()
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
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            unu.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            doi.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            trei.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            patru.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            cinci.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            sase.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            sapte.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            opt.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        }
    }

    public void PuneLaLoc()
    {
        unu.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        doi.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        trei.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        patru.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        cinci.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        sase.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        sapte.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        opt.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
    }
}