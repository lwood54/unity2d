using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int maxNum;
    int minNum;
    int guess;
    int numTries;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maxNum = 5000;
        minNum = 1;
        guess = 2500;
        numTries = 0;
        Debug.Log("Welcome to number wizard.");
        Debug.Log("Pick a number.");
        Debug.Log("Highest number is: " + maxNum);
        Debug.Log("Lowest number is: " + minNum);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        maxNum += 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNum = guess;
            NextGuess();
        }
        //Detect when the down arrow key has been released
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNum = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Sweet, we guessed your number after " + numTries + " tries!");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (maxNum + minNum) / 2;
        numTries++;
        Debug.Log("Ok, so is your number higher or lower than " + guess);

    }
}
