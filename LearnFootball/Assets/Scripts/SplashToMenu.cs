using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashToMenu : MonoBehaviour
{
    public AudioSource intro;

    IEnumerator SplashToMainMenu()
    {
        yield return new WaitForSeconds(6.5f);
        SceneManager.LoadScene(1);
    }
    void Start()
    {
        intro.Play();
        StartCoroutine("SplashToMainMenu");
    }
    private void Update()
    {
        if (Input.anyKeyDown)
        {
            SceneManager.LoadScene(1);
        }
    }

}
