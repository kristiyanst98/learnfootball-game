using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CreditsQuit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BackToMainMenu());
    }

   IEnumerator BackToMainMenu()
    {
        yield return new WaitForSeconds(15.5f);
        SceneManager.LoadScene(1);
    }
}
