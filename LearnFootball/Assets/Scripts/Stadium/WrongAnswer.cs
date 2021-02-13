using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongAnswer : MonoBehaviour
{
   
    public AudioSource audioSource;
    public GameObject ps;
    
  
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Ball"))
        {
            
            if (PlayerPrefs.GetInt("OwnGoals") < 5)
            {
                PlayerPrefs.SetInt("question", PlayerPrefs.GetInt("question") + 1);
                PlayerPrefs.SetInt("OwnGoals", PlayerPrefs.GetInt("OwnGoals") + 1);
                audioSource.Play();
                GameObject particle = Instantiate(ps, this.transform.position, Quaternion.identity);
                Object.Destroy(particle, 3f);   
            }
            
        }
    }
}
