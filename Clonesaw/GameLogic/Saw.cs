using Clonesaw;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conesaw.GameLogic
{
    internal class Saw
    {
        public bool SawStatus = false;
        Random random = new Random();

        public void ActivSaw()
        {
            if (SawStatus)
            {
                return;
            }

            SawStatus = true;

            Hand i = Game.ActiveGame.hands[random.Next(0, Game.ActiveGame.hands.Count)];
            i.saw = true;
            i.SawBox.Visible = true;
        }

        public Hand SawMove(int fingers)
        {
            foreach (var item in Game.ActiveGame.hands)
            {
                if (item.saw)
                {
                    item.saw = false;
                    int i = fingers + Game.ActiveGame.hands.IndexOf(item);

                    while (true)
                    {
                        if (i <= Game.ActiveGame.hands.Count)
                        {
                            Game.ActiveGame.hands[i].saw = true;
                            return Game.ActiveGame.hands[i];
                        }

                        i -= Game.ActiveGame.hands.Count;
                    }
                }
            }
            return null;
        }
        public bool SawCutProbability()
        {
            if (random.Next(1, 11) <= Game.ActiveGame.Bell._charges)
            {
                return true;
            }
            return false;
        }
    }

    
}
