namespace _2PlayerGame
{
  public class Player : IPlayer
  {
    private string charName;
    int health;
    string weapName;
    int weapValue;
    string armorName;
    int armorValue;
    ActionSelection selectAction;

    public ActionSelection SelectAction
    {
      get { return selectAction; }
      set { selectAction = value; }
    }

    public string CharacterName
    {
      get { return charName; }
      set { charName = value; }
    }

    public int Health
    {
      get { return health; }
      set { health = value; }
    }

    public string WeaponName
    {
      get { return weapName; }
      set { weapName = value; }
    }

    public int WeaponValue
    {
      get { return weapValue; }
      set { weapValue = value; }
    }

    public string ArmorName
    {
      get { return armorName; }
      set { armorName = value; }
    }

    public int ArmorValue
    {
      get { return armorValue; }
      set { armorValue = value; }
    }
  }
}
