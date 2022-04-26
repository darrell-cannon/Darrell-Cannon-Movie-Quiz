using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameButton : MonoBehaviour
{
    public GameObject leaderBoardManagerObject;
    LeaderBoardManager leaderBoardManager;
    DisplayLeaderBoard displayLeaderBoard;

    public GameObject scoreObject;
    public InputField inputField;
    public GameObject quizManager;

    public GameObject gameManager;

    void Start()
    {
        leaderBoardManager = leaderBoardManagerObject.GetComponent<LeaderBoardManager>();
        displayLeaderBoard = leaderBoardManagerObject.GetComponent<DisplayLeaderBoard>();
    }

    public void OnClick()
    {
        string name = inputField.text;

        if(name.Length != 3)
        {
           
            return;
        }
        
        int score = scoreObject.GetComponent<ScoreManager>().GetScore().score;
        name = inputField.text;
        int time = Mathf.RoundToInt(quizManager.GetComponent<Timer>().ReturnTime());
                
        leaderBoardManager.AddPlayer(score, name, time);
        displayLeaderBoard.UpdateLeaderBoard();

        gameManager.GetComponent<GameFlow>().ShowPanel("leaderBoardPanel");

        scoreObject.GetComponent<ScoreManager>().ResetScore();
        quizManager.GetComponent<Timer>().ResetTimer();
    }
}
