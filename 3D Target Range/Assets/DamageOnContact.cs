using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    GameController gameController;
    GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
            Debug.Log("Start of damage script");
            GameObject gameControllerObject = GameObject.FindWithTag("GameController");
            if(gameControllerObject != null){
                gameController = gameControllerObject.GetComponent<GameController>();
            }

            if(gameController == null){
                Debug.Log("Cannot find GameController script");
            }

            playerObject = GameObject.FindWithTag("Player");
            if(playerObject == null){
                Debug.Log("Cannot find the player object");
            }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other){
        Debug.Log("Collided with bat");
        if(other.gameObject == playerObject){
            gameController.TargetCollided(2);
        }
    }
}
