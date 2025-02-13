namespace Clonesaw
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
            Game game = Game.ActiveGame;
        }
    }
}
