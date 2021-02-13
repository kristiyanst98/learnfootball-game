using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGameButtons : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject myCam;

   public void ContinueGame()
    {
        PauseMenu.SetActive(false);
        Cursor.visible = false;
        if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            myCam.GetComponent<CameraRotateLockerRoom>().enabled = true;
        }
        if(SceneManager.GetActiveScene().buildIndex == 3)
        {
            myCam.GetComponent<CameraRotate>().enabled = true;
        }
            
        Time.timeScale = 1;
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("question", 1);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
