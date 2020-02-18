using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour
{
    //script for the target
    public int timeBonus = 10;
    public GameController gameController;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision){
        //destroy this object
        DestroyObject(gameObject);
    }

    private void OnDestroy(){
        //tell the game controller
        if (gameController != null){
            gameController.TargetDestroyed(timeBonus);
        }
    }
}
