using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStatus : MonoBehaviour
{
    
    void Update()
    {
        if(PlayerPrefs.GetInt("Goals") == 5)
        {
            SceneManager.LoadScene(5);
            Cursor.visible = true;
        }
        if(PlayerPrefs.GetInt("OwnGoals")== 5)
        {
            SceneManager.LoadScene(6);
            Cursor.visible = true;
        }
    }
}
