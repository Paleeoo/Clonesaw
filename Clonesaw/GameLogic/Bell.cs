using Clonesaw;
using System;

namespace Conesaw.GameLogic
{
    internal class Bell
    {
        public Hand Hand; //TODO 
        private int _charges;

        public void ActivateBell()
        {
            Game.ActiveGame.UI.pictureBoxBell.Enabled = true;

            Random random = new Random();
            SetBell(_charges);
        }

        public void SetBell(int charges)
        {
            _charges = charges;
            UpdateBell();
        }

        public void UpdateBell()
        {
        }

        public void RingBell(Hand hand)
        {

            UpdateBell();
        }
    }
}
