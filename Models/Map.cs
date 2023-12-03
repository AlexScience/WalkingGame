namespace WalkerGame.Models;

public class Map
{
    public Map(List<Trap> traps, int sizeMap, List<Player> players)
    {
        Traps = traps;
        SizeMap = sizeMap;
        Players = players;
    }

    public List<Trap> Traps { get; init; }
    public int SizeMap { get; init; }

    public List<Player> Players { get; init; }
}