/*
     * Darion Jeffries
     * ScoreManager
     * Challenge2
     * Keeps track of score
     */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text textbox;
    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;
    public static int health = 5;
    public Text healthText;


    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (!gameOver)
                textbox.text = "Score: " + score;
                healthText.text = "Health: " + health;
        }
        if (score >= 5)
        {
            won = true;
            gameOver = true;
        }
        if (health <= 0)
        {
            won = false;
            gameOver = true;
        }
        if (gameOver)
        { 
            if (won)
            {
                textbox.text = "You win!\nPress R to Try Again!";
                healthText.text = " ";
            }
            else
            {
                textbox.text = "You lose!\nPress R to Try Again!";
                healthText.text = " ";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }


    }
}
