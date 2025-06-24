using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icsuri : MonoBehaviour
{
    public GameObject ics;
    public GameObject icsics;
    public GameObject icsicsics;

    public AudioSource bzz;
    public AudioSource bzzof;
    public GameObject unu;
    public GameObject dois;
    public GameObject doid;
    public GameObject treis;
    public GameObject treic;
    public GameObject treid;

    private void Start()
    {
        ics.SetActive(false);
        icsics.SetActive(false);
        icsicsics.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            StartCoroutine(WaitForSeconds(ics));
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            StartCoroutine(WaitForSeconds(icsics));
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            StartCoroutine(WaitForSeconds(icsicsics));
        }

    }

    IEnumerator WaitForSeconds(GameObject x)
{
    if(PlayerPrefs.GetInt("oftat") == 1)
        bzzof.Play();
    else
        bzz.Play();

    x.SetActive(true);

    BounceEffect bounce = x.GetComponent<BounceEffect>();
    if (bounce != null)
        bounce.Bounce();

    yield return new WaitForSeconds(1);
    x.SetActive(false);
}
}