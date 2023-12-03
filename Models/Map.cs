namespace WalkerGame.Models;

public class Map
{
    public Map(List<Trap> traps)
    {
        Traps = traps;
    }

    public int Size { get; init; }
    public List<Trap> Traps { get; init; }
    
    
}