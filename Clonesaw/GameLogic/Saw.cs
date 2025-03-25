using Clonesaw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conesaw.GameLogic
{
    internal class Saw
    {
        public bool SawStatus = false;

        public void ActivSaw()
        {
            if (SawStatus)
            {
                return;
            }

            SawStatus = true;

            Random random = new Random();

            Game.ActiveGame.hands[random.Next(0, Game.ActiveGame.hands.Count)].saw = true;
        }

        public void SawMove(int fingers)
        {
            foreach (var item in Game.ActiveGame.hands)
            {

            }
        }
    }

    
}
