namespace WalkerGame.Models;

public class Player
{
    public Player(string name)
    {
        Name = name;
        CurrentPosition = 0;
    }

    public string Name { get; init; }
    public int CurrentPosition { get; set; }
}