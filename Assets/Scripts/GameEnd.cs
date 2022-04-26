using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public GameObject gameManager;

    void Start()
    {
        QuizManager.OnGameEnd += GameEnded;
    }

    public void GameEnded()
    {
        ShowGameEndPanel();
    }
 
    private void ShowGameEndPanel()
    {
        gameManager.GetComponent<GameFlow>().ShowPanel("gameEndPanel");
    }


    
}
