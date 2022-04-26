using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoardManager : MonoBehaviour
{
    List<Player> players;

    public TextAsset jsonFile;


    // Start is called before the first frame update
    void Start()
    {
        players = new List<Player>();
        players = JsonHandler.ReadFromJSON<Player>("playersJson.json");

    }

    public void AddPlayer(int score, string name, int time)
    {
        Player newPlayer = new Player(score, name, time);
        players.Add(newPlayer);

        SaveToJson();
      
    }

    public List<Player> ReturnPlayerList()
    {
        return players;
    }

    void SaveToJson()
    {

        JsonHandler.SaveToJSON<Player>(players, "PlayersJson.json");
            
        
    }


}
