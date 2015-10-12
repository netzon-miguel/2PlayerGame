using System;
namespace _2PlayerGame
{
  public class ArmorFactory : IEquipmentFactory
  {
    public IEquipment CreateEquipment()
    {
      IOutputService message = new ConsoleOutput();
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
      return weapon;
    }
  }
}
