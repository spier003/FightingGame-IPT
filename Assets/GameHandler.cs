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

    //Player Name
    public TextMeshProUGUI P1Name;
    public TextMeshProUGUI P2Name;
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
  
     
 
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

    //Set Player Name
    public void SetPlayerName(){
        P1Name.text = inputField1.text;
        P2Name.text = inputField2.text;

        Debug.Log(P1Name);
        Debug.Log(P2Name);
    }

    //Players Attack
    public void P1LowPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 75){
            P2HP -= 3.0f;
            Debug.Log("Player 2 HP : " + P2HP);
            P2HPBar.fillAmount -= .30f / P2HP;
        }else if (P2HP < 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");
            P2HPBar.fillAmount -= 0;
        }else {
            Debug.Log("Missed");
        }
    }
    public void P1HighPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 55){
            P2HP -= 8.0f;

            Debug.Log("Player 2 HP: " + P2HP);
            P2HPBar.fillAmount -= 8.0f / P2HP;
        }else if (P2HP < 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");
        }else {
            Debug.Log("Missed");
        }

    }
    public void P1LowKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 65){
            P2HP -= 6.0f;

            Debug.Log("Player 2 HP: " + P2HP);
            P2HPBar.fillAmount -= 6.0f / P2HP;
        }else if (P2HP < 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");
        
            
        }else {
            Debug.Log("Missed");
        }

    }
    public void P1HighKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 45){
            P2HP -= 12.0f;

            Debug.Log("Player 2 HP: " + P2HP);
            P2HPBar.fillAmount -= 12.0f / P2HP;
        }else if (P2HP < 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");

            
        }else {
            Debug.Log("Missed");
        }

    }
    public void P1Special(){

        P2HP -= 25.0f;

        Debug.Log("Player 2 HP: " + P2HP);
        P2HPBar.fillAmount -= 25.0f / P2HP;

        if (P2HP == 0){
            Debug.Log("Player P2 is dead");
        }

    }


    public void P2LowPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 75){
            P1HP -= 3.0f;

            Debug.Log("Player 1 HP: " + P1HP);
            P1HPBar.fillAmount -= 3.0f / P1HP;
        }else if (P1HP < 0){
            P1HP = 0;
            
            Debug.Log("Player 1 is Dead");
        }else {
            Debug.Log("Missed");
        }

    }
    public void P2HighPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 55){
            P1HP -= 8.0f;

            Debug.Log("Player 1 HP: " + P1HP);
            P1HPBar.fillAmount -= 8.0f / P1HP;
        }else if (P1HP < 0){
            P1HP = 0;
            
            Debug.Log("Player 1 is Dead");
        }else {
            Debug.Log("Missed");
        }

    }
    public void P2LowKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 65){
            P1HP -= 6.0f;

            Debug.Log("Player 1 HP: " + P1HP);
            P1HPBar.fillAmount -= 6.0f / P1HP;
        }else if (P1HP < 0){
            P1HP = 0;
            
            Debug.Log("Player 1 is Dead");
        }else {
            Debug.Log("Missed");
        }

    }
    public void P2HighKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 45){
            P1HP -= 12.0f;

            Debug.Log("Player 1 HP: " + P1HP);
            P1HPBar.fillAmount -= 12.0f / P1HP;
        }else if (P1HP < 0){
            P1HP = 0;
            
            Debug.Log("Player 1 is Dead");
        }else {
            Debug.Log("Missed");
        }

    }
    
    public void P2Special(){

        P1HP -= 25.0f;

        Debug.Log("Player 1 HP: " + P1HP);
        P1HPBar.fillAmount -= 25.0f / P1HP;
        if (P1HP == 0){
            Debug.Log("Player P1 is dead");
        }

    }

}
