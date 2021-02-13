using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowResult : MonoBehaviour
{
    public TextMeshProUGUI result;

    void Update()
    {
        result.GetComponent<TextMeshProUGUI>().SetText(PlayerPrefs.GetInt("Goals").ToString() + " : " + PlayerPrefs.GetInt("OwnGoals").ToString()); ;
    }

   
}
