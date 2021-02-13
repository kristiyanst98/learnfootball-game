using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseGame : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject mycamera;
    public AudioSource lockerRoom;
   

    void Update()
    {
        if (Input.GetButtonDown("PauseGame"))
        {
            PauseMenu.SetActive(!PauseMenu.activeSelf);
            if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                if (mycamera.GetComponent<CameraRotateLockerRoom>().enabled == true)
                {
                    Time.timeScale = 0;
                    mycamera.GetComponent<CameraRotateLockerRoom>().enabled = false;
                    Cursor.visible = true;
                    lockerRoom.Pause();
                }
                else if (mycamera.GetComponent<CameraRotateLockerRoom>().enabled == false)
                {
                    Time.timeScale = 1;
                    mycamera.GetComponent<CameraRotateLockerRoom>().enabled = true;
                    Cursor.visible = false;
                    lockerRoom.Play();
                }
            }
            if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                if (mycamera.GetComponent<CameraRotate>().enabled == true)
                {
                    Time.timeScale = 0;
                    mycamera.GetComponent<CameraRotate>().enabled = false;
                    Cursor.visible = true;
                }
                else if (mycamera.GetComponent<CameraRotate>().enabled == false)
                {
                    Time.timeScale = 1;
                    mycamera.GetComponent<CameraRotate>().enabled = true;
                    Cursor.visible = false;
                }
            }

        }
       
    }
}
