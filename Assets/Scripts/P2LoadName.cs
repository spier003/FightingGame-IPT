using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class P2LoadName : MonoBehaviour
{
    public TextMeshProUGUI Player2Name;
    
    // Start is called before the first frame update
    void Start()
    {
         Player2Name.text = PlayerPrefs.GetString("P2Name");
    }
}