using Conesaw.GameLogic;
using System;

namespace Clonesaw
{
    internal class Game
    {
        public Player PlayerDevil { get; }
        public Player PlayerHuman { get; }
        public Bell Bell { get; private set; }
        public readonly Form1 UI;

        private Player playerTurn;
        private Hand handSelected;

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
            ActiveGame = this;
            PlayerDevil = new HumanPlayer("Devil");
            PlayerHuman = new HumanPlayer("Human");
            playerTurn = PlayerHuman;
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
                        hand.HandBox.Enabled = false;

                        if (UI.pictureBoxBell.Enabled == false)
                            Bell.ActivateBell();
                       
                    }

                    handSelected = null;
                    playerTurn = hand.owner;
                }
            }

        }
    }
}
