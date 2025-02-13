using System.Windows.Forms;

namespace Clonesaw
{
    internal class Hand
    {
        public Player owner { get; }

        public int MaxFingers { get; set; }
        private int _fingers;
        public int Fingers
        {
            get { return _fingers; }
            set
            {
                _fingers = value % MaxFingers;
            }
        }

        public PictureBox HandBox;

        public Hand(Player owner) : this(owner, 1, 5)
        {
        }

        public Hand(Player owner, int fingerAmount, int fingerMax)
        {
            this.owner = owner;
            MaxFingers = fingerMax;
            Fingers = fingerAmount;


        }

        public void CutFinger()
        {
            MaxFingers -= 1;
        }
    }
}
