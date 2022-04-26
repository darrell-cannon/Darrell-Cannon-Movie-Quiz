using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class DisplayLeaderBoard : MonoBehaviour
{
    public GameObject gameManager;
    
    public GameObject leaderBoardManager;
    public GameObject leaderBoardPanel;
    public Text leaderBoardText;


    List<Player> playerList;

    // Start is called before the first frame update
    void Start()
    {
        playerList = new List<Player>();
        UpdateLeaderBoard();

    }

    public void UpdateLeaderBoard()
    {
        playerList = SortByTime(leaderBoardManager.GetComponent<LeaderBoardManager>().ReturnPlayerList());

        string textToDisplay = "";

        foreach (Player player in playerList)
        {
            textToDisplay += $"{player.name} - {player.score.ToString()} correct \n {player.time.ToString()} Seconds\n";
            textToDisplay += "-------------\n";
        }


        leaderBoardText.text = textToDisplay;

    }

    List<Player> SortByTime(List<Player> playerList)
    {
        return playerList.OrderBy(x => x.time).ToList();        
    }
}
