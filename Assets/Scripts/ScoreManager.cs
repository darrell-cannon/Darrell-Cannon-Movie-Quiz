using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    int score;
    const int maxScore = 10;
    const int winningScore = 3;


    void Start()
    {
        score = 0;
        DisplayScore();

        QuizManager.OnCorrectAnswer += UpdateScore;
    }

    public (int score, bool win) GetScore()
    {
        return (score, score >= winningScore);
    }

    public void UpdateScore()
    {
        score++;
        DisplayScore();
    }

    void DisplayScore()
    {
        this.GetComponentInChildren<Text>().text = $"Score:\n{score}/{maxScore}";
    }

    public void ResetScore()
    {
        score = 0;
        DisplayScore();
    }
}
