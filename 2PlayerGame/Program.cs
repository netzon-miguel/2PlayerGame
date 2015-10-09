using System;
using System.Configuration;

namespace _2PlayerGame
{
  class Program
  {
    static void Main(string[] args)
    {
      IOutputService message = new ConsoleOutput();
      message.WelcomeMessage();

      IPlayer playerOne = new Player();
      IPlayer playerTwo = new Player();

      IRegistrationService reg = new CharacterRegistration();
      reg.Register(playerOne);
      Console.Clear();
      reg.Register(playerTwo);
      Console.Clear();

      message.GetPlayerInfo(playerOne);
      message.GetPlayerInfo(playerTwo);

      Console.ReadLine();
      Console.Clear();

      ICombatService combat = new CombatLogic();
      combat.Battle(playerOne, playerTwo);

      //test
      int i = 6;
      //

      Console.ReadLine();
    }
  }
}
