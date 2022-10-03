using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using TMPro;
public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
 public int damageChance;
     public void P1LowPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 75){
            SceneManager.LoadScene(4);

        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(5);
        }  
    }
}