namespace _2PlayerGame
{
    public interface ICharacter
    {
        string CharacterName { get; set; }
        int Health { get; set; }
        string WeaponName { get; set; }
        int WeaponValue { get; set; }
        string ArmorName { get; set; }
        int ArmorValue { get; set; }
    }
}
