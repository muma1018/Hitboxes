using UnityEngine;

// Camera follows the player continuously

public class FollowPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;
    
	
	// Update is called once per frame
	void Update () {

        // only transform main camera to player if position.z != NaN
        if (!float.IsNaN(player.position.z))
        {
            Debug.Log("Follow player update is called.");
            transform.position = player.position + offset;
        }
            

	}
}
