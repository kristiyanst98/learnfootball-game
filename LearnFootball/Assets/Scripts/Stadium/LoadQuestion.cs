using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadQuestion : MonoBehaviour
{
    public GameObject question1;
    public GameObject question2;
    public GameObject question3;
    public GameObject question4;
    public GameObject question5;
    public GameObject question6;
    public GameObject question7;
    public GameObject question8;
    public GameObject question9;

    
    void Update()
    {
        if (PlayerPrefs.GetInt("question") == 1)
        {
            question1.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("question") == 2)
        {
            question1.SetActive(false);
            question2.SetActive(true);
        }
       else if (PlayerPrefs.GetInt("question") == 3)
        {
            question2.SetActive(false);
            question3.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("question") == 4)
        {
            question3.SetActive(false);
            question4.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("question") == 5)
        {
            question4.SetActive(false);
            question5.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("question") == 6)
        {
            question5.SetActive(false);
            question6.SetActive(true);
        }
       else if (PlayerPrefs.GetInt("question") == 7)
        {
            question6.SetActive(false);
            question7.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("question") == 8)
        {
            question7.SetActive(false);
            question8.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("question") ==9)
        {
            question8.SetActive(false);
            question9.SetActive(true);
        }
    }
}
