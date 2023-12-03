namespace WalkerGame.Models;

public class Map
{
    public Map(List<Trap> traps,int size)
    {
        Traps = traps;
        Size = new int[size];
    }

    public int[] Size { get; init; }
    public List<Trap> Traps { get; init; }
    
    
}