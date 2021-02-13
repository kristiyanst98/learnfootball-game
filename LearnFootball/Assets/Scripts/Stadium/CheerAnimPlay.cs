using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheerAnimPlay : MonoBehaviour
{
    public GameObject[] fans;


     void Start()
    {
        fans = GetFans();
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Ball"))
        {
            if (PlayerPrefs.GetInt("Goals") < 5)
            { 
                foreach(var fan in fans)
                {
                    fan.GetComponent<Animator>().SetTrigger("cheer");
                }

            }

        }
    }

    public GameObject[] GetFans()
    {
        GameObject[] fans;
        fans = GameObject.FindGameObjectsWithTag("Fan");
        return fans;
    }
}
