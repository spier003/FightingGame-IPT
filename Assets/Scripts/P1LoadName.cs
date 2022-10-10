using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class P1LoadName : MonoBehaviour
{
 
    public TextMeshProUGUI Player1Name;
    

    void Start()
    {
         Player1Name.text = PlayerPrefs.GetString("P1Name");
    }
}
