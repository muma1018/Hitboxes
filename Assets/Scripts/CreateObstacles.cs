using UnityEngine;

public class CreateObstacles : MonoBehaviour
{

    // Use this for initialization
    void Start () {

        // Create a new cube object by script

        // Create a new cube primitive to set the color on
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Get the Renderer component from the new cube
        var cubeRenderer = cube.GetComponent<Renderer>();

        // Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.SetColor("_Color", Color.grey);

        Vector3 myPosition = new Vector3(2.0f, 1.0f, 50.0f);
        cube.transform.position = myPosition;
        //cube.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);
        //cube.GetComponent<Rigidbody>().MovePosition(myPosition);
        cube.GetComponent<Collider>().enabled = true;


    }
}
