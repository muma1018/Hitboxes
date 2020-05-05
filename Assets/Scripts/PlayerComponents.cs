using UnityEngine;

// Script to change player material

public class PlayerComponents : MonoBehaviour {

    public GameObject myPlayer;
    public Rigidbody rb;
    public Material[] myMaterial = new Material[3];
    public bool gameIsOver;
    

    void Start()
    {
        //var myPlayerRenderer = myPlayer.GetComponent<Renderer>();

        // Assigns a material named "Assets/Resources/ObstacleRMat" to the object.
        // Has to be called in Start()
        Material RMat = Resources.Load("ObstacleRMat", typeof(Material)) as Material;
        Material GMat = Resources.Load("ObstacleGMat", typeof(Material)) as Material;
        Material BMat = Resources.Load("ObstacleBMat", typeof(Material)) as Material;

        // //Set array with materials
        //Material[] mymaterials = new material[3];
        myMaterial[0] = RMat;
        myMaterial[1] = GMat;
        myMaterial[2] = BMat;
    }

    void Update()
    {
        // After 100m, change players material
        if (Mathf.FloorToInt(rb.position.z) %100 == 0)
        {
            // Get GameIsOver object
            gameIsOver = myPlayer.GetComponent<PlayerCollision>().gameIsOver;

            // Only change color if game is not over yet
            if (!gameIsOver)
            {
                // Randomly change player material to [R,G,B]
                var myPlayerRenderer = myPlayer.GetComponent<Renderer>();
                myPlayerRenderer.material = myMaterial[Mathf.FloorToInt(Random.Range(0, 3))]; ;
            }

        }
        
    }

}



