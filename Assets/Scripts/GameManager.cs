using UnityEngine;
using UnityEngine.SceneManagement;

// Script to restart levels

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;
    bool gameIsOver;
    public GameObject myPlayer;

    public void CompleteLevel()
    {
        gameIsOver = myPlayer.GetComponent<PlayerCollision>().gameIsOver;
        if (!gameIsOver)
        {
            completeLevelUI.SetActive(true);
        }
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            Debug.Log("Game Over!");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
