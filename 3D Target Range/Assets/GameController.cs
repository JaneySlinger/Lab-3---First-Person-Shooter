using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public float timeLeft = 20.0f;
    public Text TimeText;
    public Text WinText;
    bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameOver){
            timeLeft -= Time.deltaTime;
        }

        //format to string with no decimal places
        TimeText.text = timeLeft.ToString("0");
        if(timeLeft < 0 ){
            Debug.Log("Game Over");
            WinText.text = "Game Over";
            TimeText.text = "0";
            isGameOver = true;
        }


    }

    public void TargetDestroyed(){
        if(GameObject.FindObjectsOfType<Destroyable>().Length == 0){
            Debug.Log("You win!");
            WinText.text = "You Win!";
            isGameOver = true;
        }
        if(!isGameOver){
            timeLeft += 10;
        }

    }
}
