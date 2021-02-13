using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightAnswer : MonoBehaviour
{
    
    public GameObject ps;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Ball"))
        {
            if (PlayerPrefs.GetInt("Goals") < 5)
            {
                PlayerPrefs.SetInt("Goals", PlayerPrefs.GetInt("Goals") + 1);
                PlayerPrefs.SetInt("question", PlayerPrefs.GetInt("question") + 1);
                audioSource.Play();
                GameObject particle = Instantiate(ps, this.transform.position, Quaternion.identity);
                Object.Destroy(particle, 3);
            }

        }
    }

}
