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

      IEquipmentFactory weaponFactory = new WeaponFactory();
      IEquipment weapon = null;

      weapon = weaponFactory.CreateEquipment();
      if (weapon != null)
      {
        character.WeaponName = weapon.EquipmentName;
        character.WeaponValue = message.AddEnchantment(weapon)
                                       .EquipmentValue;
      }
      
      IEquipmentFactory armorFactory = new ArmorFactory();
      IEquipment armor = null;
      
      armor = armorFactory.CreateEquipment();

      if (armor != null)
      {
        character.ArmorName = armor.EquipmentName;
        character.ArmorValue = message.AddEnchantment(armor)
                                      .EquipmentValue;
      }
    }
  }
}
