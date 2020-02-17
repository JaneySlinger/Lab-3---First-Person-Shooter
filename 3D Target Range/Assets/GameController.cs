using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float timeLeft = 30.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft < 0 ){
            Debug.Log("Game Over");
        }
    }

    public void TargetDestroyed(){
        if(GameObject.FindObjectsOfType<Destroyable>().Length == 0){
            Debug.Log("You win!");
        }
    }
}
