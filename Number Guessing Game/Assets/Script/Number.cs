using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    private int guess = 5; 
    private int minValue = 1;
    private int maxValue = 10;

    // Start is called before the first frame update
    void Start()
    {
          StartGame();
    }
    

    // Update is called once per frame

     void Update()
     {
       if(Input.GetKeyDown(KeyCode.UpArrow))
       {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
       } 
       if(Input.GetKeyDown(KeyCode.DownArrow))
       {
            maxValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
       }
       if(Input.GetKeyDown(KeyCode.Return))
       {
            Debug.Log("I guessed your number, Me big brain");
            Debug.Log("");
            StartGame();
       }



    }

    void StartGame()
    {
          guess = 5;
          minValue = 1;
          maxValue = 10;
          Debug.Log("Wecome to number guessing game.");
          Debug.Log("The number range is from " + minValue + " and " + maxValue);
          Debug.Log("Guess a Number Using the Arrow keys");
          Debug.Log("Push up arrow = Higher, Push Down arrow = Lower, Push enter = Correct");
          Debug.Log("Tell me if your number is higher or lower : " + guess + "?");
          maxValue = maxValue + 1;
    }
}
