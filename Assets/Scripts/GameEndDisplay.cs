using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEndDisplay : MonoBehaviour
{
    ScoreManager scoreManager;
    public GameObject scoreObject;
    public GameObject imageSpawner;

    public GameObject successPanel;
    public GameObject failurePanel;

    string textToDisplay;

    bool win;

     void Start()
    {
        scoreManager = scoreObject.GetComponent<ScoreManager>();

        QuizManager.OnGameEnd += OnGameEnd;

        this.gameObject.SetActive(false);
    }


    void OnGameEnd()
    {
        CheckForWin();
        SetText();
        DisplayText();
        SpawnImageBubbles();
    }

    private void SpawnImageBubbles()
    {
        if (win)
        {
            imageSpawner.GetComponent<EndGameImages>().Win(scoreManager.GetScore().score);
        }
        else
        {
            imageSpawner.GetComponent<EndGameImages>().Lose();
        }
    }

    private void CheckForWin()
    {
        if (scoreManager.GetScore().win)
        {
            win = true;
        }
        else { win = false; }
    }
    void SetText()
    {
        string score = scoreManager.GetScore().score.ToString();
        textToDisplay = $"You scored {score}\n";

        if (win)
        {
            textToDisplay += "You won!";
            
        }
        else
        {
            textToDisplay += "You lost!";
            
        }
        ShowWinAndLosePanel();
    }

    void ShowWinAndLosePanel()
    {
        if (win)
        {
            failurePanel.SetActive(false);
            successPanel.SetActive(true);
        }
        else
        {
            failurePanel.SetActive(true);
            successPanel.SetActive(false);
        }
    }

    void DisplayText()
    {
        this.GetComponentInChildren<Text>().text = textToDisplay;
    }
}
