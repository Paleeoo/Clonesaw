namespace Clonesaw
{
    internal abstract class Player
    {
        public readonly string Name;
        public int Score { get; private set; }
        public Hand HandL { get; private set; }
        public Hand HandR { get; private set; }
        public Player(string name)
        {
            Name = name;
            HandL = new Hand(this);
            HandR = new Hand(this);
        }

        public void IncrementScore()
        {
            Score ++;
        }
    }
}
