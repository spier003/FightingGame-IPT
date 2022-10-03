using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameNav : MonoBehaviour
{
   public void Menu(){
        SceneManager.LoadScene(1);
    }
    public void PlayGame(){
        SceneManager.LoadScene(2);
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

     public void ResetPlayerName(){
        PlayerPrefs.DeleteAll();
        Debug.Log("Names are Deleted");
    }
}
