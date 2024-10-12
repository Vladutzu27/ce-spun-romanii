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

    public GameObject splash;

    public bool full = true;

    void Start()
    {
        PlayerPrefs.SetInt("MuzicaBool", true ? 1 : 0);
        PlayerPrefs.SetInt("OftatBool", false ? 1 : 0);
        PlayerPrefs.SetInt("SFXBool", true ? 1 : 0);
        PlayerPrefs.SetInt("FullscreenBool", true ? 1 : 0);
        
        // Play both sources from the start but mute the bass initially
        themeSource.clip = theme;
        bassSource.clip = bass;
        
        themeSource.loop = true;
        bassSource.loop = true;
        
        themeSource.Play();
        bassSource.Play();
        
        bassSource.volume = 0; // Only play the theme initially
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SelectQuestion");
        Debug.Log("Jocul a inceput");
    }

    public void Options()
    {
        SceneManager.LoadScene("Setări");
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
            // Reduce the themeSource volume and increase bassSource volume
            StartCoroutine(FadeOut(themeSource));
            StartCoroutine(FadeIn(bassSource));
            Controale.SetActive(true);
            splash.SetActive(false);
        }
        else
        {
            // Reduce the bassSource volume and increase themeSource volume
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
