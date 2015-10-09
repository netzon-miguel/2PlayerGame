namespace _2PlayerGame
{
    interface IOutputService
    {
        void WelcomeMessage();
        string NamePrompt();
        string WeaponPrompt();
        string ArmorPrompt();
        void GetPlayerInfo(IPlayer character);
        void BattleInfo(IPlayer player1, IPlayer player2);
        bool CoinTossInfo();
        void CheckWinner(IPlayer player1, IPlayer player2);
        IEquipment AddEnchantment(IEquipment equip);
    }
}
