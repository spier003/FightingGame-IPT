using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using TMPro;

public class GameHandler : MonoBehaviour
{
    public float P1HP;
    public float P2HP;
    //PLAYERS HP
    public Image P1HPBar;
    public Image P2HPBar;
    // Players Accuracy
    public int damageChance;

    public TextMeshProUGUI HPText1;
    public TextMeshProUGUI HPText2;


    // Start is called before the first frame update
    void Start()
    {
        P1HP = PlayerPrefs.GetFloat("P1Health");
        P2HP = PlayerPrefs.GetFloat("P2Health");
    }
    // Update is called once per frame
    void Update()
    {
      HPText1.text = "Health : " + P1HP;
      HPText2.text = "Health : " + P2HP;

    }
   
   void OnDestroy() {
        PlayerPrefs.SetFloat("P1Health", P1HP);
        PlayerPrefs.SetFloat("P2Health", P2HP);
    }

    //Players Attack
    public void P1LowPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 75){
            P2HP -= 3.0f;
            Debug.Log("Player 2 HP : " + P2HP);
            SceneManager.LoadScene(4);

        }else if (P2HP <= 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");
            P2HPBar.fillAmount -= 0;
            
        }else {
            Debug.Log("Missed");
            SceneManager.LoadScene(5);
        }  
    }
    public void P1HighPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 55){
            P2HP -= 8.0f;
            Debug.Log("Player 2 HP: " + P2HP);
            SceneManager.LoadScene(6);
        }else if (P2HP <= 0){
            P2HP = 0;
            Debug.Log("Player 2 is Dead");
        }else {
            Debug.Log("Missed");
            SceneManager.LoadScene(7);
        }

    }
    public void P1LowKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 65){
            P2HP -= 6.0f;
            Debug.Log("Player 2 HP: " + P2HP);
            P2HPBar.fillAmount -= 6.0f / P2HP;
            SceneManager.LoadScene(8);     
        }else if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
        }else {
            Debug.Log("Missed");
            SceneManager.LoadScene(9);
        }

    }


    public void P1HighKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 45){
            P2HP -= 12.0f;
            Debug.Log("Player 2 HP: " + P2HP);
            P2HPBar.fillAmount -= 12.0f / P2HP;
            SceneManager.LoadScene(10);
        }else if (P2HP <= 0){
            
            Debug.Log("Player 2 is Dead");

            
        }else {
            Debug.Log("Missed");
            SceneManager.LoadScene(11);
        }

    }
     public void P1Special(){
        damageChance = Random.Range(0, 101);
        if (damageChance <= 90){
            P2HP -= 25.0f;
            Debug.Log("Player 2 HP: " + P2HP);
            SceneManager.LoadScene(12);
        }else if (P2HP <= 0){
            P2HP = 0;
            
        Debug.Log("Player 2 is Dead");
        Debug.Log("Player 2 HP: " + P2HP);
        P2HPBar.fillAmount -= 25.0f / P2HP;
        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(13);
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
            SceneManager.LoadScene(14);
        }else if (P1HP <= 0){
            P1HP = 0;
            Debug.Log("Player 1 is Dead");
        }else {
            Debug.Log("Missed");
            SceneManager.LoadScene(15);
        }

    }
    public void P2HighPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 55){
            P1HP -= 8.0f;
            Debug.Log("Player 1 HP: " + P1HP);
            P1HPBar.fillAmount -= 8.0f / P1HP;
            SceneManager.LoadScene(16);
        }else if (P1HP <= 0){
            P1HP = 0;
            
            Debug.Log("Player 1 is Dead");
        }else {
            Debug.Log("Missed");
            SceneManager.LoadScene(17);
        }

    }
    public void P2LowKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 65){
            P1HP -= 6.0f;

            Debug.Log("Player 1 HP: " + P1HP);
            P1HPBar.fillAmount -= 6.0f / P1HP;
            SceneManager.LoadScene(18);
        }else if (P1HP <= 0){
            P1HP = 0;
            
            Debug.Log("Player 1 is Dead");
        }else {
            Debug.Log("Missed");
            SceneManager.LoadScene(19);
        }

    }
    public void P2HighKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 45){
            P1HP -= 12.0f;

            Debug.Log("Player 1 HP: " + P1HP);
            P1HPBar.fillAmount -= 12.0f / P1HP;
            SceneManager.LoadScene(20);
        }else if (P1HP <= 0){
            P1HP = 0;
            
            Debug.Log("Player 1 is Dead");
        }else {
            Debug.Log("Missed");
            SceneManager.LoadScene(21);
        }

    }
    
     public void P2Special(){
        damageChance = Random.Range(0, 101);
        if (damageChance <= 90){
            P1HP -= 25.0f;

            Debug.Log("Player 1 HP: " + P1HP);
            SceneManager.LoadScene(22);
        }else if (P1HP <= 0){
            P1HP = 0;
            
            Debug.Log("Player 2 is Dead");
        P1HP -= 25.0f;
        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(23);
        if (P1HP <= 0){
            Debug.Log("Player P1 is dead");
        }
     }
     }
}
