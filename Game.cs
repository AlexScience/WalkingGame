using WalkerGame.Models;

namespace WalkerGame;

public class Game
{
    private bool isGameOver = false;
    private int curentPlayer = 0;

    public void Start(int playersCount, int mapSize, int trapsCount)
    {
        var players = CreatePlayers(playersCount);
        var traps = GenerateTraps(mapSize, trapsCount);
        var map = GenerateMap(traps, mapSize, players);

        while (!isGameOver)
        {
            var player = players[curentPlayer];
            Console.WriteLine($"Очередь игрока : {player.Name}");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.KeyChar == ' ')
            {
                var stepCount = new Random().Next(1, 7);
                player.CurrentPosition += stepCount;
                Console.WriteLine($"Игрок {player.Name} - сделал {stepCount} шагов {player.CurrentPosition}");


                foreach (var trap in traps.Where(trap => trap.Position == player.CurrentPosition))
                {
                    Console.WriteLine($"Игрок {player.Name} попал в ловушку! возврат на {trap.Punishment} ");
                    player.CurrentPosition -= Math.Clamp(trap.Punishment, 0, 100);
                }

                if (player.CurrentPosition >= mapSize)
                {
                    Console.WriteLine($"Игрок {player.Name} победил!");
                    isGameOver = true;
                }

                if (curentPlayer >= playersCount - 1)
                    curentPlayer = 0;
                else
                    curentPlayer++;
            }
        }
    }

    private List<Player> CreatePlayers(int count)
    {
        List<Player> players = new List<Player>();
        for (int i = 0; i < count; i++)
        {
            string name = Console.ReadLine();
            Player player = new Player(name);
            players.Add(player);
        }

        return players;
    }


    private Map GenerateMap(List<Trap> traps, int mapSize, List<Player> players)
    {
        var map = new Map(traps, mapSize, players);
        return map;
    }

    private List<Trap> GenerateTraps(int mapSize, int count)
    {
        int[] positions = GenerateTrapPositions(mapSize, count);
        List<Trap> traps = positions.Select(position => new Trap(position, new Random().Next(3, 8))).ToList();

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