using UnityEngine;

// Script that ends a level

public class EndTrigger : MonoBehaviour {

    public GameManager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }




}
