using System;
using System.Windows.Forms;

namespace Clonesaw
{
    public partial class Form1 : Form
    {
        static Game game;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = Game.InitializeGame(this);

            game.PlayerDevil.HandL.HandBox = pictureBoxDevilHandL;
            game.PlayerDevil.HandL.SawBox = pictureBoxDevilHandLSaw;
            game.PlayerDevil.HandR.HandBox = pictureBoxDevilHandR;
            game.PlayerDevil.HandR.SawBox = pictureBoxDevilHandRSaw;
            game.PlayerHuman.HandL.HandBox = pictureBoxHumanHandL;
            game.PlayerHuman.HandL.SawBox = pictureBoxHumanHandLSaw;
            game.PlayerHuman.HandR.HandBox = pictureBoxHumanHandR;
            game.PlayerHuman.HandR.SawBox = pictureBoxHumanHandRSaw;
        }

        private void pictureBoxDevilHandL_Click(object sender, EventArgs e)
        {
            game.SelectHand(game.PlayerDevil.HandL);
        }

        private void pictureBoxDevilHandR_Click(object sender, EventArgs e)
        {
            game.SelectHand(game.PlayerDevil.HandR);
        }

        private void pictureBoxHumanHandL_Click(object sender, EventArgs e)
        {
            game.SelectHand(game.PlayerHuman.HandL);
        }

        private void pictureBoxHumanHandR_Click(object sender, EventArgs e)
        {
            game.SelectHand(game.PlayerHuman.HandR);
        }

        private void pictureBoxBell_Click(object sender, EventArgs e)
        {
            game.BellPush();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSideLights11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxSideLights1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
