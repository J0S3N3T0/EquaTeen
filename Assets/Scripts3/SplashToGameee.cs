using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashToGameee : MonoBehaviour
{

    public GameObject bgm;
    public GameObject splashWhite;
    public GameObject splashText;

    void Start()
    {
        StartCoroutine(SplashEnd());
    }

    IEnumerator SplashEnd()
    {
        yield return new WaitForSeconds(4);
        bgm.SetActive(true);
        yield return new WaitForSeconds(1);
        splashText.SetActive(false);
        splashWhite.SetActive(false);
    }
}
