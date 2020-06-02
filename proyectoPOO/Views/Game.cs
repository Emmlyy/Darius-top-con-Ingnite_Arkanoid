using System;
using System.Windows.Forms;

namespace proyectoPOO
{
    public partial class Game : Form
    {
        public int verticalBallMovement;
        public int horizontalBallMovement;
        public Game()
        {
            InitializeComponent();
            verticalBallMovement = 1;
            horizontalBallMovement = 1;
        }

        private void Game_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxBall.Top += verticalBallMovement;
            pictureBoxBall.Left += horizontalBallMovement;
            if (pictureBoxBall.Bottom>this.ClientSize.Height)
            {
                verticalBallMovement = -verticalBallMovement;
            }
            else if (pictureBoxBall.Top<0)
            {
                verticalBallMovement = -verticalBallMovement;
            }
            else if (pictureBoxBall.Right>this.ClientSize.Width)
            {
                horizontalBallMovement = -horizontalBallMovement;
            }
            else if (pictureBoxBall.Left<0)
            {
                horizontalBallMovement = -horizontalBallMovement;
            }
        }
    }
}