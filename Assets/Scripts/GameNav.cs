using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameNav : MonoBehaviour
{
    public AudioSource bg1;
    public AudioSource bg2;
   void Start(){
    bg1 = AudioManager.BG_1;
    bg2 = AudioManager.BG_2;
   }

   public void playBG1(){
        bg1.Play();
   }
   public void stopBG1(){
        bg1.Stop();
   }
   public void playBG2(){
        bg2.Play();
   }
   public void stopBG2(){
        bg2.Stop();
   }

   public void SetName(){
        SceneManager.LoadScene(1);
    }
    public void SetHP(){
        SceneManager.LoadScene(2);
    }

    public void StartGame(){
        SceneManager.LoadScene(3);
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

     public void ResetData(){
        PlayerPrefs.DeleteAll();
        Debug.Log("Data are Deleted");
    }

}
