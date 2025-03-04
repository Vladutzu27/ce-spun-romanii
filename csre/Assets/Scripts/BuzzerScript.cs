using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuzzerScript : MonoBehaviour
{
    public GameObject buzzerLeft;
    public GameObject buzzerRight;

    public Sprite Red;
    public Sprite Blank;

    public AudioSource buzzer;

    public Animator animator;

    public bool isOpen;

    void Start()
    {
        isOpen = animator.GetBool("Open");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            StartCoroutine(Flash());
        }
    }

    private IEnumerator Flash()
    {
        

        animator.SetBool("Open", true);

        yield return new WaitForSeconds(0.4f);

        buzzer.Play();

        float[] delays = { 0.1f, 0.07f, 0.05f, 0.04f, 0.03f, 0.02f, 0.02f, 0.01f, 0.01f, 0.01f };

        foreach (float delay in delays)
        {
            for (int i = 0; i < 2; i++) // Switch 3 times per delay
            {
                buzzerLeft.GetComponent<SpriteRenderer>().sprite = Blank;
                buzzerRight.GetComponent<SpriteRenderer>().sprite = Red;
                yield return new WaitForSeconds(delay);

                buzzerRight.GetComponent<SpriteRenderer>().sprite = Blank;
                buzzerLeft.GetComponent<SpriteRenderer>().sprite = Red;
                yield return new WaitForSeconds(delay);
            }
            if (Random.Range(0, 2) == 1)
            {
                buzzerRight.GetComponent<SpriteRenderer>().sprite = Red;
                buzzerLeft.GetComponent<SpriteRenderer>().sprite = Blank;
            }
        }
        yield return new WaitForSeconds(0.4f);

        animator.SetBool("Open", false);
    }
}
