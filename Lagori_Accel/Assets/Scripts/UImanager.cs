using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour

{
    
    private bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {/*
        if (gameOver)
        {
            gText.text = "Game Over";

        }
        */
    }

    public void setGameOver()
    {
        gameOver = true;
    }
}
