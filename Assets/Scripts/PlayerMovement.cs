using UnityEngine;

// Script to move the player by continous forward force and user input for moving sideways

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce = 600f;
    public float sidwaysForce = 600f;


    // Update is called once per frame - Used FixedUpdate bc we use it to mess with physics
    void FixedUpdate () {

        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);  // Time.deltaTime to even out framerate of computer

        // change sideways force / sideways movement
         if (Input.GetKey("d"))
        {
            rb.AddForce(sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidwaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f || float.IsNaN(rb.position.y))
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
