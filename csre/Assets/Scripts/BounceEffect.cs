using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class BounceEffect : MonoBehaviour
{
    public float bounceHeight = 0.5f;
    public float bounceDuration = 0.2f;

    private Vector3 originalScale;

    void Awake()
    {
        originalScale = transform.localScale;
    }

    public void Bounce()
    {
        StopAllCoroutines();
        StartCoroutine(BounceRoutine());
    }

    IEnumerator BounceRoutine()
    {
        float t = 0;
        while (t < bounceDuration)
        {
            t += Time.deltaTime;
            float scale = 1 + Mathf.Sin((t / bounceDuration) * Mathf.PI) * bounceHeight;
            transform.localScale = originalScale * scale;
            yield return null;
        }
        transform.localScale = originalScale;
    }
}
