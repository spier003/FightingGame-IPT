using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource[] myMusic;
    public static AudioSource BG_1;
    public static AudioSource BG_2;


    void Awake() {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Start(){
        myMusic = GetComponents<AudioSource>();
        BG_1 = myMusic[0];
        BG_2 = myMusic[1];
    
    if(SceneManager.GetActiveScene().name == "Main Menu")
            BG_1.Play(); 
    }
    void Update(){
        if(SceneManager.GetActiveScene().name == "P1Winner")
            BG_2.Stop();
        else if(SceneManager.GetActiveScene().name == "P2Winner")
            BG_2.Stop();
    }
}
