namespace _2PlayerGame
{
    public enum ActionSelection
    {
        Attack,
        Defend,
    }

    public class ClassicAction
    {
        ActionSelection selectAction;

        public ActionSelection SelectAction
        {
            get { return selectAction; }
            set { selectAction = value; }
        }
    }
}
