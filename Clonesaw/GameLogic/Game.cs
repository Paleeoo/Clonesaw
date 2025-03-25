using Conesaw.GameLogic;
using System;
using System.Collections.Generic;
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
            List<Hand> hands = new List<Hand>();
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

        public void CutFingers()
        {

        }

        public void SelectHand(Hand hand)
        {
            if (handSelected == null)
            {
                if (playerTurn == hand.owner)
                    handSelected = hand;
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

                        if (UI.pictureBoxBell.Enabled == false)
                            Bell.ActivateBell();
                    }
                    handSelected = null;
                    playerTurn = hand.owner;
                }
            }

        }

        public void BellPush(Hand hand)
        {
            if (handSelected == null) return;

            if (hand.owner == PlayerDevil)
            {
                playerTurn = PlayerHuman;
            }
            else
            {
                playerTurn = PlayerDevil;
            }

            Game.ActiveGame.Saw.ActivSaw();

        }
    }
}
