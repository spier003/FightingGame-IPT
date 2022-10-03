using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Game : MonoBehaviour
{
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public void saveButtonName(){
    PlayerPrefs.SetString("P1Name", inputField1.text);
    PlayerPrefs.SetString("P2Name", inputField2.text);
    Debug.Log("P1 name is" + PlayerPrefs.GetString("P1Name"));
    Debug.Log("P2 name is" + PlayerPrefs.GetString("P2Name"));
    }
    public void SetHP50(){
        
        PlayerPrefs.SetFloat("P1Health", 50);
        PlayerPrefs.SetFloat("P2Health", 50);
        Debug.Log("Player 1 HP: " + PlayerPrefs.GetFloat("P1Health"));
        Debug.Log("Player 2 HP: " + PlayerPrefs.GetFloat("P2Health"));  
    }
    public void SetHP100(){
        
        PlayerPrefs.SetFloat("P1Health", 100);
        PlayerPrefs.SetFloat("P2Health", 100);
        Debug.Log("Player 1 HP: " + PlayerPrefs.GetFloat("P1Health"));
        Debug.Log("Player 2 HP: " + PlayerPrefs.GetFloat("P2Health"));
    }
    public void SetHP150(){
        
        PlayerPrefs.SetFloat("P1Health", 150);
        PlayerPrefs.SetFloat("P2Health", 150);
        Debug.Log("Player 1 HP: " + PlayerPrefs.GetFloat("P1Health"));
        Debug.Log("Player 2 HP: " + PlayerPrefs.GetFloat("P2Health"));
        
    }
}
