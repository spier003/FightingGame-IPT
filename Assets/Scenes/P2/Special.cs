using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Special : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 5f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Debug.Log(currentTime);
        if(currentTime <= 0){
            SceneManager.LoadScene(26);

        }
    
        
    }
}
