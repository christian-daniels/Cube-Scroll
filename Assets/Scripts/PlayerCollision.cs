
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;


   void OnCollisionEnter(Collision collisionInfo){
       
       
    //    Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Hit an obstacle");
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();

        }
   }
}
