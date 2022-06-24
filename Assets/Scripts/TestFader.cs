using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestFader : MonoBehaviour
{
    public RawImage faderImage;

    float timer = 0;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(FadeIn());
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            StartCoroutine(FadeOut());
        }
    }

    IEnumerator FadeIn()
    {
        timer = 0;

        while(timer <= 1)
        {
            faderImage.color = Color.Lerp(Color.clear, Color.black, timer);
            timer += 0.1f;
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator FadeOut()
    {
        timer = 0;

        while (timer <= 1)
        {
            faderImage.color = Color.Lerp(Color.black, Color.clear, timer);
            timer += 0.1f;
            yield return new WaitForEndOfFrame();
        }
    }
}
