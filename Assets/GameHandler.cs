using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using TMPro;

public class GameHandler : MonoBehaviour
{
    //PLAYERS HP
    public float P1HP;
    public float P2HP;

    public Image P1HPBar;

    public Image P2HPBar;

    // Players Accuracy
    public int damageChance;

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
    public void BackToMainMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    //To restart
    public void RestartGame() {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
         }
    // to quit
    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
    
    // Set HP

    public void RestartHP(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }
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

    //Players Attack
    public void P1LowPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 75){
            P2HP -= 3.0f;
            Debug.Log("Player 2 HP : " + P2HP);
            P2HPBar.fillAmount -= 3.0f / P2HP;
        }else if (P2HP < 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");
        }else {
            Debug.Log("Missed");
        }
    }
}
