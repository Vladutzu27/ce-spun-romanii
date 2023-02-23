using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Controls : MonoBehaviour
{
    public GameObject unu;
    public GameObject doi;
    public GameObject trei;
    public GameObject patru;

    public int which = 1;
    // Start is called before the first frame update
    void Start()
    {
        unu.SetActive(true);
        doi.SetActive(false);
        trei.SetActive(false);
        patru.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && which == 1)
        {
            unu.SetActive(false);
            doi.SetActive(true);
            trei.SetActive(false);
            patru.SetActive(false);
            which++;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && which == 2)
        {
            unu.SetActive(false);
            doi.SetActive(false);
            trei.SetActive(true);
            patru.SetActive(false);
            which++;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && which == 3)
        {
            unu.SetActive(false);
            doi.SetActive(false);
            trei.SetActive(false);
            patru.SetActive(true);
            which++;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && which == 4)
        {
            SceneManager.LoadScene("Meniu");
        }

    }
}
