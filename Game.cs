using WalkerGame.Models;

namespace WalkerGame;

public class Game
{
    public void CreatePlayer(int count)
    {
       
        string name = Console.ReadLine() ?? throw new ArgumentNullException("Поле имя не может быть пустым");
        for (int i = 0; i < count; i++)
        {
            Player player = new Player(Guid.NewGuid(), name, 0);

        }

       
    }
}