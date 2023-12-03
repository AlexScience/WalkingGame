namespace WalkerGame.Models;

public class Trap
{
   public Trap(int position, int punishment)
   {
      Position = position;
      Punishment = punishment;
   }

   public int Position { get;}
   public int Punishment { get; init; }
}