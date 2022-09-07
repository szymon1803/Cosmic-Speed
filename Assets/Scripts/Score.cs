using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public GameObject Points;
    public TextMeshProUGUI pointsInGame;
    public float scoreAmount;
    public float pointsPerSecond;
    private bool isGameOver = false;
    public void Start()
    {
        scoreAmount = 0f;
        pointsPerSecond = 1f;
    }
    private void Update()
    {
        if (isGameOver == false)
        {
            pointsInGame.text = "SCORE: " + (int)scoreAmount;
            scoreAmount += pointsPerSecond * Time.deltaTime;
        }
    }
    public void GameOver()
    {
        Points.SetActive(false);
        isGameOver = true;
    }
}
