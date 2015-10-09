using System;

namespace _2PlayerGame
{
  class CharacterRegistration : IRegistrationService
  {
    public void Register(IPlayer character)
    {
      IOutputService message = new ConsoleOutput();

      character.CharacterName = message.NamePrompt();

      character.Health = 100;
      character.SelectAction = ActionSelection.Attack;

      IEquipment weapon = null;

      string optionWeap = message.WeaponPrompt();
      Selection selectWeap = (Selection)Enum.Parse(typeof(Selection),
                             optionWeap, true);

      switch (selectWeap)
      {
        case Selection.A:
        {
          weapon = new Knife();
          break;
        }

        case Selection.B:
        {
          weapon = new Sword();
          break;
        }

        case Selection.C:
        {
          weapon = new Blade();
          break;
        }

        case Selection.D:
        {
          weapon = new Katana();
          break;
        }
      }

      if (weapon != null)
      {
        character.WeaponName = weapon.EquipmentName;
        character.WeaponValue = message.AddEnchantment(weapon)
                                       .EquipmentValue;
      }

      string optionArm = message.ArmorPrompt();
      Selection selectArm = (Selection)Enum.Parse(typeof(Selection),
                            optionArm, true);

      IEquipment armor = null;

      switch (selectArm)
      {
        case Selection.A:
        {
          armor = new Guard();
          break;
        }

        case Selection.B:
        {
          armor = new Buckler();
          break;
        }

        case Selection.C:
        {
          armor = new Shield();
          break;
        }

        case Selection.D:
        {
          armor = new ThornShield();
          break;
        }
      }
      if (armor != null)
      {
        character.ArmorName = armor.EquipmentName;
        character.ArmorValue = message.AddEnchantment(armor)
                                      .EquipmentValue;
      }
    }
  }
}
