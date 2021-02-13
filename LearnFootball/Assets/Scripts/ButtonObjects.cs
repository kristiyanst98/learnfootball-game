using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonObjects : MonoBehaviour
{

    public void PlayGame()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("question", 1);
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("question", 1);
        SceneManager.LoadScene(1);
    }

    public void Rules()
    {
        SceneManager.LoadScene(7);
    }

    public void Credits()
    {
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
