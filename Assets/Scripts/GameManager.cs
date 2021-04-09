using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void CompleteLevel(){
        Debug.Log("LEVEL WON!");
        completeLevelUI.SetActive(true); // enable level complete ui
    }
    public void EndGame(){
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            // Restart Game
            // Restart();
            Invoke("Restart", restartDelay);

        }
       

    }
    void Restart(){
        // SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
