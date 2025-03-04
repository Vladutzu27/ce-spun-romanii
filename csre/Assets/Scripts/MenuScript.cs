using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public AudioClip theme;
    public AudioClip bass;

    public AudioSource themeSource;
    public AudioSource bassSource;
    public GameObject Controale;
    public GameObject Setari;
    
    public GameObject splash;

    public bool full = true;

    void Start()
    {   
        themeSource.clip = theme;
        bassSource.clip = bass;
        
        themeSource.loop = true;
        bassSource.loop = true;
        
        themeSource.Play();
        bassSource.Play();
        
        bassSource.volume = 0;
    }

    void Update()
    {
        if (!full && Input.GetKeyDown(KeyCode.Escape))
        {
            StartCoroutine(FadeOut(bassSource));
            StartCoroutine(FadeIn(themeSource));
            Controale.SetActive(false);
            splash.SetActive(true);
            full = !full;
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SelectQuestion");
        Debug.Log("Jocul a inceput");
    }

    public void Options()
    {
        Setari.SetActive(!Setari.activeSelf);
    }

    public void Controls()
    {
        // LEGACY: SceneManager.LoadScene("Controls")
    }

    public void Schimba()
    {
        VideoScript.instance.ChangeVideoClip(VideoScript.instance.clip1);
        TutorialScript.instance.tutorialText.text = "Pentru a afișa un răspuns, apăsați pe numărul corespunzător răspunsului.";
        if (full)
        {
            StartCoroutine(FadeOut(themeSource));
            StartCoroutine(FadeIn(bassSource));
            Controale.SetActive(true);
            splash.SetActive(false);
        }
        else
        {
            StartCoroutine(FadeOut(bassSource));
            StartCoroutine(FadeIn(themeSource));
            Controale.SetActive(false);
            splash.SetActive(true);
        }
        full = !full;
    }

    private IEnumerator FadeIn(AudioSource source, float duration = 1f)
    {
        float targetVolume = 1f;
        float startVolume = source.volume;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            source.volume = Mathf.Lerp(startVolume, targetVolume, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        source.volume = targetVolume;
    }

    private IEnumerator FadeOut(AudioSource source, float duration = 1f)
    {
        float targetVolume = 0f;
        float startVolume = source.volume;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            source.volume = Mathf.Lerp(startVolume, targetVolume, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        source.volume = targetVolume;
    }
}