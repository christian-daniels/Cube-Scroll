using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelComplete : MonoBehaviour
{
   public void LoadNextLevel(){
       // When you go to File->BuildSettings you can see scenes have an index number
       
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
       
   }
}
