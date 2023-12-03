using WalkerGame.Models;

namespace WalkerGame;

public class Game
{
    public void Start(int playersCount, int mapSize, int trapsCount)
    {
        CreatePlayers(playersCount);
        GenerateMap(mapSize, trapsCount);
    }

    private List<Player> CreatePlayers(int count)
    {
        List<Player> players = new List<Player>();
        for (int i = 0; i < count; i++)
        {
            string? name = Console.ReadLine();
            Player player = new Player(name);
            players.Add(player);
        }

        return players;
    }


    private Map GenerateMap(int trapsCount, int mapSize)
    {
        var traps = GenerateTraps(mapSize, trapsCount);
        var map = new Map(traps, mapSize);
        return map;
    }

    private List<Trap> GenerateTraps(int mapSize, int count)
    {
        int[] positions = GenerateTrapPositions(mapSize, count);
        List<Trap> traps = positions.Select(position => new Trap(position)).ToList();

        return traps;
    }

    private int[] GenerateTrapPositions(int mapSize, int trapsCount)
    {
        int[] positions = new int[trapsCount];

        Random random = new Random();
        for (int i = 0; i < positions.Length; i++)
        {
            int randomPosition = random.Next(0, mapSize);
            while (positions.Contains(randomPosition))
            {
                randomPosition = random.Next(0, mapSize);
            }

            positions[i] = randomPosition;
        }

        return positions;
    }
    
    /// =========
}
