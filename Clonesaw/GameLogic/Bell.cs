using Clonesaw;
using System;
using System.Runtime.Serialization;

namespace Conesaw.GameLogic
{
    internal class Bell
    {
        public int _count = 0;
        public Hand Hand; //TODO 
        public int _charges;
        private const int MAX_CHARGES = 5;
        private const int MAX_SIDE_LIGHTS = 3;
        

        public void ActivateBell()
        {
            Game.ActiveGame.UI.pictureBoxBell.Visible = true;
            Game.ActiveGame.UI.pictureBoxBell.Enabled = true;

            Random random = new Random();
            SetBellCharges(random.Next(1,6));
            
        }

        public void SetBellCharges(int charges)
        {
            if(charges <= MAX_CHARGES) _charges = charges;
            UpdateBell();

        }

        public void UpdateBell()
        {
            SetBellSideLights();
            UpdateBellSideLights();
            UpdateCharges();
        }

        private void SetBellSideLights()
        {
            if (_charges == MAX_CHARGES) return;
           
            if (++_count == MAX_SIDE_LIGHTS)
            {
                _count = 0;
                _charges++;
            }
        }

        public void UpdateBellSideLights()
        {
            if (_count > 0)
            {
                Game.ActiveGame.UI.pictureBoxSideLights1.Visible = true;
                Game.ActiveGame.UI.pictureBoxSideLights11.Visible = true;
                if (_count > 1)
                {
                    Game.ActiveGame.UI.pictureBoxSideLights2.Visible = true;
                    Game.ActiveGame.UI.pictureBoxSideLights22.Visible = true;
                    if (_count > 2)
                    {
                        Game.ActiveGame.UI.pictureBoxSideLights3.Visible = true;
                        Game.ActiveGame.UI.pictureBoxSideLights33.Visible = true;
                    }
                }
            }
            else
            {
                Game.ActiveGame.UI.pictureBoxSideLights1.Visible = false;
                Game.ActiveGame.UI.pictureBoxSideLights11.Visible = false;
                Game.ActiveGame.UI.pictureBoxSideLights2.Visible = false;
                Game.ActiveGame.UI.pictureBoxSideLights22.Visible = false;
                Game.ActiveGame.UI.pictureBoxSideLights3.Visible = false;
                Game.ActiveGame.UI.pictureBoxSideLights33.Visible = false;
            }
        }

        public void UpdateCharges()
        {
            if (_charges > 0)
            {
                Game.ActiveGame.UI.pictureCharges1.Visible = true;
                Game.ActiveGame.UI.pictureCharges11.Visible = true;
                if (_charges > 1)
                {
                    Game.ActiveGame.UI.pictureCharges2.Visible = true;
                    Game.ActiveGame.UI.pictureCharges22.Visible = true;
                    if (_charges > 2)
                    {
                        Game.ActiveGame.UI.pictureCharges3.Visible = true;
                        Game.ActiveGame.UI.pictureCharges33.Visible = true;
                        if (_charges > 3)
                        {
                            Game.ActiveGame.UI.pictureCharges4.Visible = true;
                            Game.ActiveGame.UI.pictureCharges44.Visible = true;
                            if (_charges > 4)
                            {
                                Game.ActiveGame.UI.pictureCharges5.Visible = true;
                                Game.ActiveGame.UI.pictureCharges55.Visible = true;
                            }
                        }
                    }
                }
            }
            else
            {
                Game.ActiveGame.UI.pictureCharges1.Visible = false;
                Game.ActiveGame.UI.pictureCharges11.Visible = false;
                Game.ActiveGame.UI.pictureCharges2.Visible = false;
                Game.ActiveGame.UI.pictureCharges22.Visible = false;
                Game.ActiveGame.UI.pictureCharges2.Visible = false;
                Game.ActiveGame.UI.pictureCharges22.Visible = false;
                Game.ActiveGame.UI.pictureCharges4.Visible = false;
                Game.ActiveGame.UI.pictureCharges44.Visible = false;
                Game.ActiveGame.UI.pictureCharges5.Visible = false;
                Game.ActiveGame.UI.pictureCharges55.Visible = false;

            }
        }


        public void RingBell(Hand hand)
        {
            UpdateBell();
        }
    }
}
