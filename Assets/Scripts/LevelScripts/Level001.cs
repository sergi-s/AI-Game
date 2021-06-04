using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level001 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        RedirectToLevel.redirectToLevel = 3;
        RedirectToLevel.nextLevel = 5;
        StartCoroutine(FadeInoff());
    }
    IEnumerator FadeInoff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }
}