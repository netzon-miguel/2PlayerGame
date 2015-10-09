using System;

namespace _2PlayerGame
{
  class ConsoleOutput : IOutputService
  {
    public void WelcomeMessage()
    {
      Console.Write(String.Format(ApplicationSettings.WelcomeText));
    }

    public string NamePrompt()
    {
      Console.Write(String.Format(ApplicationSettings.NameText));
      return Console.ReadLine();
    }

    public string WeaponPrompt()
    {
      Console.Write(String.Format(ApplicationSettings.WeaponChoices));
      return Console.ReadLine();
    }

    public string ArmorPrompt()
    {
      Console.Write(String.Format(ApplicationSettings.ArmorChoices));
      return Console.ReadLine();
    }

    public void GetPlayerInfo(IPlayer character)
    {
      Console.WriteLine(character.CharacterName);
      Console.WriteLine(character.Health);
      Console.WriteLine(character.WeaponName);
      Console.WriteLine(character.WeaponValue);
      Console.WriteLine(character.ArmorName);
      Console.WriteLine(character.ArmorValue);
    }

    public void BattleInfo(IPlayer player1, IPlayer player2)
    {
      Console.Write(String.Format(ApplicationSettings.BattleInfoText,
                                  player1.Health.ToString(),
                                  player2.Health.ToString()));
    }

    public string ActionChoose(string name)
    {
      Console.Write(String.Format(ApplicationSettings.ActionChoose));
      return Console.ReadLine();
    }

    public bool CoinTossInfo()
    {
      string choice;
      CombatLogic coin = new CombatLogic();
      Console.Write(String.Format(ApplicationSettings
                          .CoinTossInfo_Pick));

      if (coin.CoinToss((Coins)Enum.Parse(typeof(Coins),
                                          Console.ReadLine(),
                                          true)))
      {
        Console.Write(String.Format(ApplicationSettings
                            .CoinTossInfo_First));
        return true;
      }

      else
      {
        Console.Write(String.Format(ApplicationSettings
                            .CoinTossInfo_Second));
        return false;
      }

      Console.Write(String.Format(ApplicationSettings
                          .CoinTossInfo_PickInfo, choice));
    }

    public void CheckWinner(IPlayer player1, IPlayer player2)
    {
      if (player1.Health > player2.Health)
      {
        Console.Write(String.Format(ApplicationSettings
                            .CoinTossInfo_P1Win));
      }

      else
      {
        Console.Write(String.Format(ApplicationSettings
                            .CoinTossInfo_P2Win));
      }

      Console.Write(String.Format(ApplicationSettings
                          .CoinTossInfo_Goodbye));
    }

    public IEquipment AddEnchantment(IEquipment equip)
    {
      IEquipment equip2 = equip;
      Console.Write(String.Format(ApplicationSettings
                          .AddEnchantmentPrompt));
      Selection selectOrb = (Selection)Enum.Parse(typeof(Selection),
                             Console.ReadLine(), true);
      switch (selectOrb)
      {
        case Selection.A:
        {
          equip2 = new BlueOrb(equip);
          break;
        }

        case Selection.B:
        {
          equip2 = new GreenOrb(equip);
          break;
        }

        case Selection.C:
        {
          equip2 = new RedOrb(equip);
          break;
        }

        default:
          break;
      }
      return equip2;
    }
  }
}
