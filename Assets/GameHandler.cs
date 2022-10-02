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
    public static float P1HP;
    public static float P2HP;
    public Image P1HPBar;

    public Image P2HPBar;

    //Player Name
    public TextMeshProUGUI P1Name;
    public TextMeshProUGUI P2Name;
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
  
 
    //VIDEOS
    public GameObject VideoPlayer;
    public VideoClip P1LowKickAttack;
    public VideoClip P1LowKickMissed;

    // Players Accuracy
    public int damageChance;

    public TextMeshProUGUI HPText1;
    public TextMeshProUGUI HPText2;

    // static GameHandler TheOne;

    // Start is called before the first frame update
    void Start()
    {
        P1HP = 50f;
        P2HP = 50f;

    
        //       if(TheOne != null){
        //     Destroy(this.gameObject);
        //     return;
        // }
        // TheOne = this;
        // GameObject.DontDestroyOnLoad(this.gameObject);



    }

    // Update is called once per frame
    void Update()
    {
      HPText1.text = "Health : " + P1HP;
      HPText2.text = "Health : " + P2HP;

    }
   
    // public void testinggame(){
    //     SceneManager.LoadScene(22);
    // }

    //For Main Menu
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void NextGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void BackToMainMenu(){
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.LoadScene(0);
    }
    //To restart
    public void RestartGame() {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
            SceneManager.LoadScene(1);
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

        Debug.Log(inputField1);
        Debug.Log(inputField2);
    }

    //Move to scene
    // public void MoveToScene(int sceneID)
    // {
    //     SceneManager.LoadScene(sceneID);
    // }

    //Players Attack
    public void P1LowPunch(){

        damageChance = Random.Range(0, 101);
        if (damageChance <= 75){
            P2HP -= 3.0f;
            Debug.Log("Player 2 HP : " + P2HP);
            P2HPBar.fillAmount -= .30f / P2HP;
            SceneManager.LoadScene(2);

        }else if (P2HP <= 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");
            P2HPBar.fillAmount -= 0;
            
        }else {
            Debug.Log("Missed");
            SceneManager.LoadScene(3);
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
            VideoPlayer.gameObject.GetComponent<VideoPlayer>().clip = P1LowKickAttack;
            VideoPlayer.gameObject.GetComponent<VideoPlayer>().Play();
            Destroy(gameObject, 3);
        }else if (P2HP <= 0){
            P2HP = 0;
            
            Debug.Log("Player 2 is Dead");
            VideoPlayer.gameObject.GetComponent<VideoPlayer>().clip = P1LowKickMissed;
            VideoPlayer.gameObject.GetComponent<VideoPlayer>().Play();
            Destroy(gameObject, 3);
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
