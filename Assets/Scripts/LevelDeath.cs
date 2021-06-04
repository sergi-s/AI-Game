
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    public GameObject LevelAudio;
    public GameObject FadeOut;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(YouFellOff());
        }
    }
    IEnumerator YouFellOff()
    {
        youFell.SetActive(true);
        LevelAudio.SetActive(false);
        yield return new WaitForSeconds(2);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(RedirectToLevel.redirectToLevel);

    }
}