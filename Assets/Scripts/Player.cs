using System;
[System.Serializable]
public class Player
{
    public int score;
    public string name;
    public int time;

    public Player() { }
    public Player(int score, string name, int time)
    {
        this.score = score;
        this.name = name;
        this.time = time;
    }

}
