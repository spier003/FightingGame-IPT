using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class timerforan : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 3f;
    public static int P1HP;
    public static int P2HP;

    public TextMeshProUGUI HPText1;
    public TextMeshProUGUI HPText2;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;

        P1HP = 50;
        P1HP = 50;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Debug.Log(currentTime);
        if(currentTime <= 0){
            SceneManager.LoadScene(2);
            HPText1.text = "Health : " + P1HP;
            HPText2.text = "Health : " + P2HP;
        }

        
    }

    public void Back(){
        SceneManager.LoadScene(2);
    }

}

