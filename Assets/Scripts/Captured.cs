
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Captured : MonoBehaviour
{
    public GameObject youGotCaptured;
    public GameObject LevelAudio;
    public GameObject FadeOut;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enime")
        {
            StartCoroutine(YouGotCapmtures());
        }
    }
    IEnumerator YouGotCapmtures()
    {
        youGotCaptured.SetActive(true);
        LevelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);

    }

}
