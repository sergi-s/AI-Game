using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level003 : MonoBehaviour
{
    public GameObject fadeIn;

    void Start()
    {
        
       
        RedirectToLevel.redirectToLevel = 6;
        RedirectToLevel.nextLevel = 4;
        StartCoroutine(FadeInoff());
    }
    IEnumerator FadeInoff()
    {
        yield return new WaitForSeconds(1);
        fadeIn.SetActive(false);
    }

}
