
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideForce = 500f;

    // Start is called before the first frame update
    // void Start()
    // {
    //     Debug.Log("Hello World!");
    // }

    // Update is called once per frame
    // void Update()
    // {
    //     rb.AddForce(0, 0, 500 * Time.deltaTime);
    // }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Check if position on Y-axis is below a certain number
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
