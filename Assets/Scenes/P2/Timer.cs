using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 2f;

    int P1;
    int P2;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        P1 = GameHandler.P1HP;
        P2 = GameHandler.P2HP;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Debug.Log(currentTime);
        if(currentTime <= 0){
            if(P2 <= 0){
                SceneManager.LoadScene(24);
                Debug.Log("Player 2 is Dead");
            }
            else if(P1 <= 0){
                SceneManager.LoadScene(25);
                Debug.Log("Player 1 is Dead");
            }
            else{
                SceneManager.LoadScene(3);
            }
            
        }
    }
}
