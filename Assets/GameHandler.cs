using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{
    //PLAYERS HP
    public float P1HP;
    public float P2HP;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //For Main Menu
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // to quit
    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
    // Set HP
    public void SetHP50(){
        P1HP = 50.0f;
        P2HP = 50.0f;
        Debug.Log("Player 1 HP: " + P1HP);
        Debug.Log("Player 2 HP: " + P2HP);
    }
    public void SetHP100(){
        P1HP = 100.0f;
        P2HP = 100.0f;

        Debug.Log("Player 1 HP: " + P1HP);
        Debug.Log("Player 2 HP: " + P2HP);
    }
    public void SetHP150(){
        P1HP = 150.0f;
        P2HP = 150.0f;

        Debug.Log("Player 1 HP: " + P1HP);
        Debug.Log("Player 2 HP: " + P2HP);
    }
}
