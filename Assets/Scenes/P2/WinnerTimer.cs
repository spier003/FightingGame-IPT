using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinnerTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 4f;
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
            SceneManager.LoadScene(0);

        }
}
}
