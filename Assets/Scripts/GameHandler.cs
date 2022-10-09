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
    public static int P1HP;
    public static int P2HP;

    // Players Accuracy
    public int damageChance;

    public TextMeshProUGUI HPText1;
    public TextMeshProUGUI HPText2;

    // Start is called before the first frame update
    void Start()
    {   
        P1HP = PlayerPrefs.GetInt("P1Health");
        P2HP = PlayerPrefs.GetInt("P2Health"); 
    }

    // Update is called once per frame
    void Update()
    {
      HPText1.text = P1HP.ToString();
      HPText2.text = P2HP.ToString();
    }
   
   void OnDestroy() {
        PlayerPrefs.SetInt("P1Health", P1HP);
        PlayerPrefs.SetInt("P2Health", P2HP);
   }
   
    public void P1LowPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 75){
            P2HP -= 3;
            Debug.Log("Player 2 HP : " + P2HP);
            SceneManager.LoadScene(4);
        }
        else {
            SceneManager.LoadScene(5);
            Debug.Log("Missed");
        }
        /*if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(24);   
        }*/
    }
    public void P1HighPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 55){
            P2HP -= 8;
            Debug.Log("Player 2 HP: " + P2HP);
            SceneManager.LoadScene(6);
        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(7);
        }
        /* if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(24);   
        }*/

    }
    public void P1LowKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 65){
            P2HP -= 6;
            Debug.Log("Player 2 HP: " + P2HP);
            SceneManager.LoadScene(8);     
        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(9);
        }
        /* if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(24);   
        }*/
    }

    public void P1HighKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 45){
            P2HP -= 12;
            Debug.Log("Player 2 HP: " + P2HP);
            SceneManager.LoadScene(10);
        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(11);
        }
        /* if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(24);   
        }*/

    }
     public void P1Special(){
        damageChance = Random.Range(0, 101);
        if (damageChance <= 90){
            P2HP -= 25;
            Debug.Log("Player 2 HP: " + P2HP);
            SceneManager.LoadScene(12);
        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(13);
        }
        /* if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(24);   
        }*/
    }
    public void P2LowPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 75){
            P1HP -= 3;
            Debug.Log("Player 1 HP: " + P1HP);
            SceneManager.LoadScene(14);
        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(15);
        }
        /* if (P1HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(25);   
        }*/

    }
    public void P2HighPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 55){
            P1HP -= 8;
            Debug.Log("Player 1 HP: " + P1HP);
            SceneManager.LoadScene(16);
        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(17);
        }
        /* if (P1HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(25);   
        }*/

    }
    public void P2LowKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 65){
            P1HP -= 6;
            Debug.Log("Player 1 HP: " + P1HP);
            SceneManager.LoadScene(18);}
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(19);
        }
        /* if (P1HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(25);   
        }*/
    }
    public void P2HighKick(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 45){
            P1HP -= 12;
            Debug.Log("Player 1 HP: " + P1HP);
            SceneManager.LoadScene(20);
        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(21);
        }
       /* if (P1HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(25);   
        }*/

    }
    
     public void P2Special(){
        damageChance = Random.Range(0, 101);
        if (damageChance <= 90){
            P1HP -= 25;

            Debug.Log("Player 1 HP: " + P1HP);
            SceneManager.LoadScene(22);
        }
        else {
            Debug.Log("Missed");
            SceneManager.LoadScene(23);
        }
       /*  if (P1HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(25);   
        }*/
     }
}
