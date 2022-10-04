using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using TMPro;

public class GameHandler : MonoBehaviour
{
    public static int P1HP;
    public static int P2HP;
    //PLAYERS HP

<<<<<<< Updated upstream:Assets/Scripts/GameHandler.cs
    // Players Accuracy
    public int damageChance;
=======
    // public TMP_InputField setHPPlayer;

    public Image P1HPBar;
>>>>>>> Stashed changes:Assets/LoadName.cs

    public TextMeshProUGUI HPText1;
    public TextMeshProUGUI HPText2;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream:Assets/Scripts/GameHandler.cs
        P1HP = PlayerPrefs.GetInt("P1Health");
        P2HP = PlayerPrefs.GetInt("P2Health"); 
=======
         Player1Name.text = PlayerPrefs.GetString("P1Name");
         Player2Name.text = PlayerPrefs.GetString("P2Name");
        
        P1HP = 50;
        P2HP = 50;

        // HPText1.text = PlayerPrefs.GetString("P1HP");
        // HPText2.text = PlayerPrefs.GetString("P2HP");


        
    }

    public void ResetPlayerName(){
        PlayerPrefs.DeleteAll();
        Debug.Log("Names are Deleted");
>>>>>>> Stashed changes:Assets/LoadName.cs
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
    
   

<<<<<<< Updated upstream:Assets/Scripts/GameHandler.cs
    //Players Attack
=======
    //To restart
    public void RestartGame() {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
            SceneManager.LoadScene(1);
         }
    public void SetHP50(){
        
        P1HP = 50;
        P2HP = 50;
        Debug.Log("Player 1 HP: " + P1HP);
        Debug.Log("Player 2 HP: " + P2HP);
        
        // DontDestroyOnLoad(gameObject);
    }

    // public void saveHP(){
    // PlayerPrefs.SetString("P1HP", setHPPlayer.text);
    // PlayerPrefs.SetString("P1HP", setHPPlayer.text);
    // }
    public void SetHP100(){
        
        P1HP = 100;
        P2HP = 100;
        // PlayerPrefs.SetString("P1HP", );

        Debug.Log("Player 1 HP: " + P1HP);
        Debug.Log("Player 2 HP: " + P2HP);

        // DontDestroyOnLoad(gameObject);
    }
    public void SetHP150(){
        
        P1HP = 150;
        P2HP = 150;

        Debug.Log("Player 1 HP: " + P1HP);
        Debug.Log("Player 2 HP: " + P2HP);
        
        // DontDestroyOnLoad(gameObject);
    }

    //     public void saveButtonName(){

    // }
        //Players Attack
>>>>>>> Stashed changes:Assets/LoadName.cs
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
        if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(24);   
        }
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
         if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(24);   
        }

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
         if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(24);   
        }
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
         if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(24);   
        }

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
         if (P2HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(24);   
        }
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
         if (P1HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(25);   
        }

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
         if (P1HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(25);   
        }

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
         if (P1HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(25);   
        }
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
        if (P1HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(25);   
        }

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
         if (P1HP <= 0){
            Debug.Log("Player 2 is Dead");
            SceneManager.LoadScene(25);   
        }
     }
}
