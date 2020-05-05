using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Script to display score

public class Score : MonoBehaviour {

    public Transform player;
    public Text scoreText;
    public float restartDelay = 2f;

    // Update is called once per frame
    void Update () {
        if (!float.IsNaN(player.position.z))
        {
            scoreText.text = player.position.z.ToString("0");
        }

    }
}
