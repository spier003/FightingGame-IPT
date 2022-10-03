using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;
public class LoadName : MonoBehaviour
{
    public TextMeshProUGUI Player1Name;
    public TextMeshProUGUI Player2Name;

    public Image P1HPBar;

    public Image P2HPBar;
    public int damageChance;
    public static float P1HP;
    public static float P2HP;
    public TextMeshProUGUI HPText1;
    public TextMeshProUGUI HPText2;

    
    // Start is called before the first frame update
    void Start()
    {
         Player1Name.text = PlayerPrefs.GetString("P1Name");
         Player2Name.text = PlayerPrefs.GetString("P2Name");

        P1HP = 50f;
        P2HP = 50f;
    }

    public void ResetPlayerName(){
        PlayerPrefs.DeleteAll();
        Debug.Log("Names are Deleted");
    }

    // Update is called once per frame
    void Update()
    {
    
        HPText1.text = "Health : " + P1HP;
        HPText2.text = "Health : " + P2HP;
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

    public void RestartGame() {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
            SceneManager.LoadScene(1);
    }
    public void BackToMainMenu(){
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.LoadScene(0);
    }    

public void P1LowPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 75){
            P2HP -= 3.0f;
            Debug.Log("Player 2 HP : " + P2HP);
            P2HPBar.fillAmount -= .30f / P2HP;
            SceneManager.LoadScene(3);

        }else if (P2HP <= 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");
            P2HPBar.fillAmount -= 0;
            
        }else {
            Debug.Log("Missed");
            SceneManager.LoadScene(4);
        }  
    }
    public void P1HighPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 55){
            P2HP -= 8.0f;

            Debug.Log("Player 2 HP: " + P2HP);
            P2HPBar.fillAmount -= 8.0f / P2HP;
        }else if (P2HP <= 0){
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
        }else if (P2HP <= 0){
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
        }else if (P2HP <= 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");

            
        }else {
            Debug.Log("Missed");
        }

    }
     public void P1Special(){
        damageChance = Random.Range(0, 101);
        if (damageChance <= 90){
            P2HP -= 25.0f;
        P2HP -= 25.0f;

            Debug.Log("Player 2 HP: " + P2HP);
        }else if (P2HP <= 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");
        Debug.Log("Player 2 HP: " + P2HP);
        P2HPBar.fillAmount -= 25.0f / P2HP;
        }
        else {
            Debug.Log("Missed");
        if (P2HP <= 0){
            Debug.Log("Player P2 is dead");
        } 
        }
    }
    public void P2LowPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 75){
            P1HP -= 3.0f;

            Debug.Log("Player 1 HP: " + P1HP);
            P1HPBar.fillAmount -= 3.0f / P1HP;
        }else if (P1HP <= 0){
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
        }else if (P1HP <= 0){
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
        }else if (P1HP <= 0){
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
        }else if (P1HP <= 0){
            P1HP = 0;
            
            Debug.Log("Player 1 is Dead");
        }else {
            Debug.Log("Missed");
        }

    }
    
     public void P2Special(){
        damageChance = Random.Range(0, 101);
        if (damageChance <= 90){
            P1HP -= 25.0f;

            Debug.Log("Player 1 HP: " + P1HP);
        }else if (P1HP <= 0){
            P1HP = 0;
            
            Debug.Log("Player 2 is Dead");
        P1HP -= 25.0f;
        }
        else {
            Debug.Log("Missed");
        Debug.Log("Player 1 HP: " + P1HP);
        P1HPBar.fillAmount -= 25.0f / P1HP;
        if (P1HP <= 0){
            Debug.Log("Player P1 is dead");
        }
     }
     }

}
