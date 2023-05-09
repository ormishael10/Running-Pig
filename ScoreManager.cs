using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    
    public Text scoreText;
    public Text highScoreText;
    


    public static int score;
    public static int highScore;


    private void Awake()
    {
        instance= this;
    }


    void Start()
    {
        score = 0;
        highScore = 0;

        
        PlayerPrefs.SetInt("score", 0);
        

        highScore = PlayerPrefs.GetInt("highScore", 0);
        scoreText.text = "Score: " + score.ToString();
        highScoreText.text = "High Score: " + highScore.ToString();


    }


    public void AddPointToScore()
    {
        score++;
        PlayerPrefs.SetInt("score", score);
        scoreText.text = "Score: " + score.ToString();
        
        if (highScore < score)
        {
            PlayerPrefs.SetInt("highScore", score);
        }
        

    }
}
