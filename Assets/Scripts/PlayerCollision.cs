using UnityEngine;
using System.Collections;

// Script 

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public GameObject myPlayer;
    
    public bool gameIsOver = false;
    

    void OnCollisionEnter(Collision collisionInfo)
    {
        // If collision with obstacle ...
        if (collisionInfo.collider.tag == "Obstacle")
        {
            // set gameIsOver to true - to disable material changes after player is grey'ed
            gameIsOver = true;

            // Change color to grey when player hit an obstacle
            myPlayer.GetComponent<MeshRenderer>().material.color = Color.grey;

            Debug.Log("We hit an obstacle of different color. Game Over.");

            Debug.Log("Material player:");
            Debug.Log(myPlayer.GetComponent<MeshRenderer>().material.name);

            Debug.Log("Material collider:");
            Debug.Log(collisionInfo.collider.GetComponent<MeshRenderer>().material.name);

            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
