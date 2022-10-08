using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicSource : MonoBehaviour
{
    public static MusicSource instance;

    void Awake() {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    void Update(){
        if(SceneManager.GetActiveScene().name == "ActualGame")
            MusicSource.instance.GetComponent<AudioSource>().Stop();
        if(SceneManager.GetActiveScene().name == "P1Winner")
            MusicSource.instance.GetComponent<AudioSource>().Play();
    }
}
