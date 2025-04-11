using Conesaw.GameLogic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Clonesaw
{
    internal class Game
    {
        public Player PlayerDevil { get; }
        public Player PlayerHuman { get; }
        public Bell Bell { get; private set; }
        public Saw Saw { get; private set; }
        public readonly Form1 UI;
        private Color handcolor;

        private Player playerTurn;
        private Hand handSelected;
        public List<Hand> hands;

        public static Game ActiveGame { get; private set; }


        public static Game InitializeGame(Form1 ui)
        {
            Game game = new Game(ui);
            ActiveGame = game;
            return game;
        }

        private Game(Form1 ui)
        {
            UI = ui;
            Bell = new Bell();
            Saw = new Saw();
            ActiveGame = this;
            PlayerDevil = new HumanPlayer("Devil");
            PlayerHuman = new HumanPlayer("Human");
            playerTurn = PlayerHuman;
            hands = new List<Hand>();
            hands.Add(PlayerHuman.HandR);
            hands.Add(PlayerHuman.HandL);
            hands.Add(PlayerDevil.HandL);
            hands.Add(PlayerDevil.HandR);
        }

        public bool FingerCut()
        {
            Random random = new Random();
            if (Game.ActiveGame.Bell._charges >= random.Next(1,11) )
            {
                return true;
            }
            return false;
        }

        public void CutFingers(Hand hand)
        {
            hand.CutFinger();
            hand.Fingers = 0;
        }

        public void SelectHand(Hand hand)
        {
            if (handSelected == null)
            {
                if (playerTurn == hand.owner)
                {
                    handSelected = hand;
                    handcolor = hand.HandBox.BackColor;
                    hand.HandBox.BackColor = Color.Yellow;
                }
            }
            else
            {
                
                if (playerTurn != hand.owner)
                {
                    hand.Fingers += handSelected.Fingers;

                    if (hand.Fingers == 0)
                    {
                        hands.Remove(hand);

                        hand.HandBox.Enabled = false;
                        hand.HandBox.Visible = false; 

                        if (UI.pictureBoxBell.Visible == false)
                            Bell.ActivateBell();
                    }
                    handSelected.HandBox.BackColor = handcolor;

                    if (Game.ActiveGame.Saw.SawStatus)
                    {
                        Hand handsaw = Game.ActiveGame.Saw.SawMove(0);
                        if (handsaw != null)
                        {
                            CutProbabilityResolve(handsaw);
                        }
                    }

                    playerTurn = hand.owner;
                    if (playerTurn == PlayerDevil)
                    {
                        Game.ActiveGame.UI.pictureBoxplayerturn.BackColor = Color.Red;
                    }
                    else
                    {
                        Game.ActiveGame.UI.pictureBoxplayerturn.BackColor = Color.PeachPuff;
                    }
                    handSelected = null;

                }
            }
        }

        public void BellPush()
        {
            Hand SawHand;
            if (handSelected == null) return;
            handSelected.HandBox.BackColor = handcolor;

            if (handSelected.owner == PlayerDevil)
            {
                playerTurn = PlayerHuman;
            }
            else
            {
                playerTurn = PlayerDevil;
            }

            if (playerTurn == PlayerDevil)
            {
                Game.ActiveGame.UI.pictureBoxplayerturn.BackColor = Color.Red;
            }
            else
            {
                Game.ActiveGame.UI.pictureBoxplayerturn.BackColor = Color.PeachPuff;
            }

            if (! Game.ActiveGame.Saw.SawStatus)
            {
                Game.ActiveGame.Saw.ActivSaw();
            }
            else
            {
                SawHand = Game.ActiveGame.Saw.SawMove(handSelected.Fingers);
                
                
            }
            handSelected = null;
        }

        public void CutProbabilityResolve(Hand Cuthand)
        {

            if (Game.ActiveGame.Saw.SawCutProbability())
            {
                  
                MessageBox.Show("schnip schnap der finger ist ab");
                CutFingers(Cuthand);
                    
            }
            else
            {
                 MessageBox.Show("Glück gehabt");
            }
        }
            
        public void FingerUpdate()
        {
            PlayerHuman.HandL.FingerLabel.Text = $"{PlayerHuman.HandL.Fingers} / {PlayerHuman.HandL.MaxFingers}";
            PlayerHuman.HandR.FingerLabel.Text = $"{PlayerHuman.HandR.Fingers} / {PlayerHuman.HandR.MaxFingers}";


        }

        public void gwinn()
        {
            int human = 0;
            int devil = 0;

            if (PlayerHuman.HandL.Fingers == 0)
            {
                human++;
            }
            if (PlayerHuman.HandR.Fingers == 0)
            {
                human++;
            }
            if (PlayerDevil.HandL.Fingers == 0)
            {
                devil++; 
            }
            if (PlayerDevil.HandR.Fingers == 0)
            {
                devil++;
            }

           // if (human == 2)

           // if (devil == 2)


        }
    }
}

