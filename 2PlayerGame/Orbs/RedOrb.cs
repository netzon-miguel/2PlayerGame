namespace _2PlayerGame
{
  public class RedOrb : IEquipment
  {
    IEquipment equip;

    public RedOrb(IEquipment equip)
    {
      this.equip = equip;
    }

    public string EquipmentName
    {
      get
      {
        return equip.EquipmentName + " Enchanted: Red Orb";
      }
      set { }
    }

    public int EquipmentValue
    {
      get
      {
        return equip.EquipmentValue + 20;
      }
      set { }
    }
  }
}
