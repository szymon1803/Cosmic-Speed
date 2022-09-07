using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class YourScore : MonoBehaviour
{
    public TextMeshProUGUI score;
    public float highscoreAmount;
    public TextMeshProUGUI highscore;
    public float scoreAmount;
    public float pointsPerSecond;
    private bool isGameOver = false;
    public void Start()
    {
        scoreAmount = 0f;
        pointsPerSecond = 1f;
        highscoreAmount = PlayerPrefs.GetFloat("Highscore");
        highscore.text = "BEST SCORE: " + (int)highscoreAmount;
    }
    private void Update()
    {
        if (isGameOver == false)
        {
            score.text = "YOUR SCORE: " + (int)scoreAmount;
            scoreAmount += pointsPerSecond * Time.deltaTime;
            if (scoreAmount > highscoreAmount)
            {
                PlayerPrefs.SetFloat("Highscore", scoreAmount);
                highscore.text = "BEST SCORE: " + (int)scoreAmount;
            }
        }
    }
    public void GameOver()
    {
        isGameOver = true;
    }
}
