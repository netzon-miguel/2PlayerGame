using System;

namespace _2PlayerGame
{
  class CombatLogic : ICombatService
  {
    public void ActionRound(IPlayer attacker, IPlayer defender)
    {
      Random dodge = new Random();

      if (attacker.SelectAction == ActionSelection.Attack)
      {
        if (defender.SelectAction == ActionSelection.Defend)
        {
          if (dodge.Next(0, 2) == 0)
          {
            Console.Write(String.Format(
                          ApplicationSettings.ActionDodgePrompt));
          }

          else
          {
            defender.Health -= (attacker.WeaponValue - defender.ArmorValue);
          }
        }

        else
        {
          defender.Health -= (attacker.WeaponValue - defender.ArmorValue);
        }
      }

      else
      {
        attacker.SelectAction = ActionSelection.Defend;
      }
    }

    public bool CoinToss(Coins selectCoin)
    {
      int coin;
      Random toss = new Random();
      if (Coins.Heads == selectCoin)
      {
        coin = 0;
      }

      else
      {
        coin = 1;
      }

      if (toss.Next(0, 2) == coin)
      {
        return true;
      }

      else
      {
        return false;
      }
    }

    public void Battle(IPlayer player1, IPlayer player2)
    {
      Random ran = new Random();
      ConsoleOutput message = new ConsoleOutput();

      bool turn = message.CoinTossInfo();
      while (player1.Health > 0 && player2.Health > 0)
      {

        if (turn)
        {
          Console.Write(String.Format(ApplicationSettings.ActionChoose, 
                                      player1.CharacterName));

          if ((ActionSelection)Enum.Parse(typeof(ActionSelection),
                                         Console.ReadLine(),
                                         true)
                                         == ActionSelection.Attack)
          {
            player1.SelectAction = ActionSelection.Attack;
          }

          else
          {
            player1.SelectAction = ActionSelection.Defend;
          }
          ActionRound(player1, player2);
        }
        else
        {
          Console.Write(String.Format(ApplicationSettings.ActionChoose, 
                                      player2.CharacterName));
          if ((ActionSelection)Enum.Parse(typeof(ActionSelection),
                                        Console.ReadLine(),
                                        true)
                                        == ActionSelection.Attack)
          {
            player2.SelectAction = ActionSelection.Attack;
          }

          else
          {
            player2.SelectAction = ActionSelection.Defend;
          }

          ActionRound(player2, player1);
        }
        turn = !turn;
        if (player1.Health < 0)
        {
          player1.Health = 0;
        }

        if (player2.Health < 0)
        {
          player2.Health = 0;
        }

        message.BattleInfo(player1, player2);
      }

      message.CheckWinner(player1, player2);
    }
  }
}
