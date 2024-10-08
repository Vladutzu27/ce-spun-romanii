using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaspunsuriScript : MonoBehaviour
{
    public static RaspunsuriScript instance;

    public GameObject unu;
    public GameObject doi;
    public GameObject trei;
    public GameObject patru;
    public GameObject cinci;
    public GameObject sase;
    public GameObject sapte;
    public GameObject opt;

    void Awake()
    {
        instance = this;

        unu.SetActive(false);
        doi.SetActive(false);
        trei.SetActive(false);
        patru.SetActive(false);
        cinci.SetActive(false);
        sase.SetActive(false);
        sapte.SetActive(false);
        opt.SetActive(false);
    }

    public void Ascunde()
    {
        unu.SetActive(false);
        doi.SetActive(false);
        trei.SetActive(false);
        patru.SetActive(false);
        cinci.SetActive(false);
        sase.SetActive(false);
        sapte.SetActive(false);
        opt.SetActive(false);
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
            unu.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            doi.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            trei.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            patru.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            cinci.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            sase.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha7) && CateRasp.instance.Cate >= 7)
        {
            sapte.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Alpha8) && CateRasp.instance.Cate == 8)
        {
            opt.SetActive(true);
        }
    }
}