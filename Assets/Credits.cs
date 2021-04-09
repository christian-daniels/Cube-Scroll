using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene(1);
    }
    public void PlayAgain(){
        SceneManager.LoadScene(0);
    }
    public void Quit(){
        Application.Quit();
    }
}
