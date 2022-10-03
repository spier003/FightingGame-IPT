using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadName : MonoBehaviour
{
    public TextMeshProUGUI Player1Name;
    public TextMeshProUGUI Player2Name;
    
    // Start is called before the first frame update
    void Start()
    {
         Player1Name.text = PlayerPrefs.GetString("P1Name");
         Player2Name.text = PlayerPrefs.GetString("P2Name");
    }

}
