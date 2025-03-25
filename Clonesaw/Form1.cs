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
            game.PlayerDevil.HandR.HandBox = pictureBoxDevilHandR;
            game.PlayerHuman.HandL.HandBox = pictureBoxHumanHandL;
            game.PlayerHuman.HandR.HandBox = pictureBoxHumanHandR;
        }

        private void pictureBoxDevilHandL_Click(object sender, EventArgs e)
        {
            game.SelectHand(game.PlayerDevil.HandL);
        }

        private void pictureBoxDevilHandR_Click(object sender, EventArgs e)
        {
            game.SelectHand(game.PlayerDevil.HandL);
        }

        private void pictureBoxHumanHandL_Click(object sender, EventArgs e)
        {
            game.SelectHand(game.PlayerHuman.HandL);
        }

        private void pictureBoxHumanHandR_Click(object sender, EventArgs e)
        {
            game.SelectHand(game.PlayerHuman.HandL);
        }

        private void pictureBoxBell_Click(object sender, EventArgs e)
        {

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
