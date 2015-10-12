namespace _2PlayerGame
{
  class Katana : IEquipment
  {
    public string EquipmentName
    {
      get { return "Katana"; }
    }

    public int EquipmentValue
    {
      get { return 30; }
    }

    public int EquipmentPrice
    {
      get { return 50; }
    }
  }
}
