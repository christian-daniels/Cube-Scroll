using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Camera script in order to follow player but ignore rotation
public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    // Stores 3 floats
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position);
        transform.position = player.position + offset;
    }
}
