using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script to disable collider and activate 'static' so the player can pass w/o collision
// triggers when the player color == collider object color


public class DisableCollider : MonoBehaviour {

    public GameObject myPlayer;
    public GameObject thisObstacle; 
    	
	// Update is called once per frame
	void Update () {

        // Disable collider for objects with same material as player material
        if (myPlayer.GetComponent<MeshRenderer>().material.name == thisObstacle.GetComponent<MeshRenderer>().material.name)
        {
            thisObstacle.GetComponent<Collider>().enabled = false;
            thisObstacle.GetComponent<Rigidbody>().isKinematic = true;
        }
        else
        {
            thisObstacle.GetComponent<Collider>().enabled = true;
            thisObstacle.GetComponent<Rigidbody>().isKinematic = true;
        }

    }
}
