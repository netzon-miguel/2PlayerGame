namespace _2PlayerGame
{
    interface ICombatService
    {
        bool CoinToss(Coins selectCoin);
        void Battle(IPlayer player1, IPlayer player2);
        void ActionRound(IPlayer attacker, IPlayer defender);
    }
}
