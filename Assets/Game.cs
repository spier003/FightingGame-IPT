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
}
