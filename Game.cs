using WalkerGame.Models;

namespace WalkerGame;

public class Game
{
    public void Start(int playersCount, int mapSize, int trapsCount)
    {
        CreatePlayers(playersCount);
        GenerateMap(mapSize, trapsCount);
    }

    private void CreatePlayers(int count)
    {
        string name = Console.ReadLine() ?? throw new ArgumentNullException($"Поле Имени не может быть пустым");
        for (int i = 0; i < count; i++)
        {
            Player player = new Player(name);
        }
    }

    private void GenerateMap(int trapsCount, int mapSize)
    {
        var traps = GenerateTraps(mapSize, trapsCount);
        var map = new Map(traps, mapSize);
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
}