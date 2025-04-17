using Clonesaw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Conesaw.GameLogic
{
    internal class RoundOver
    {
       public void roundover()
        {
            Game.ActiveGame.UI.pictureBoxBell.Visible = false;
            Game.ActiveGame.UI.pictureBoxBell.Enabled = false;

            Game.ActiveGame.Bell._charges = 0;
            Game.ActiveGame.Bell._count = 0;
            Game.ActiveGame.Bell.UpdateCharges();
            Game.ActiveGame.Bell.UpdateBellSideLights();

            foreach (var item in Game.ActiveGame.allhands)
            {
                if (item.MaxFingers > 1)
                {
                    item.HandBox.Enabled = true;
                    item.HandBox.Visible = true;
                    item.FingerLabel.Visible = true;
                    item.Fingers = 1;
                }
            }


        }
    }
}
