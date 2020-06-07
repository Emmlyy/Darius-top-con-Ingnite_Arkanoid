using System;
using System.Windows.Documents;
using System.Windows.Forms;

namespace proyectoPOO
{
    public partial class Game : Form
    {
        public int verticalBallMovement;
        public int horizontalBallMovement;
        public int life = 3;
        

        public Game()
        {
            InitializeComponent();
            verticalBallMovement = 1;
            horizontalBallMovement = 1;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxBall.Top += verticalBallMovement;
            pictureBoxBall.Left += horizontalBallMovement;
            if (pictureBoxBall.Bottom > this.ClientSize.Height)
            {
                verticalBallMovement = -verticalBallMovement;
            }
            else if (pictureBoxBall.Top < 0)
            {
                verticalBallMovement = -verticalBallMovement;
            }
            else if (pictureBoxBall.Right > this.ClientSize.Width)
            {
                horizontalBallMovement = -horizontalBallMovement;
            }
            else if (pictureBoxBall.Left < 0)
            {
                horizontalBallMovement = -horizontalBallMovement;
            }
            
            //detect collision with block
                blocks();
                Player_rebound();
                Life();
                
        }


        private void Game_KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    Player.Left -= 10;
                    break;
                
                case Keys.Right:
                    Player.Left += 10;
                    break;
            }
        }

        private void Player_rebound()
        {
            
            foreach (PictureBox x in this.Controls)
            {
                if (x.Tag == "player")
                {
                    if (pictureBoxBall.Bounds.IntersectsWith(x.Bounds))
                    {   
                        //AAAAAAAH maldita shit 
                    }
                }
            }
        }

        private void Life()
        {
            
            foreach (PictureBox x in this.Controls)
            {
                if (x.Tag=="floor")
                {
                    if (pictureBoxBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        life -= 1;
                        Controls.Remove(pictureBoxBall);
                        MessageBox.Show("-1 vida");
                        //reiniciar la ubicacion de la PELOTA
                    }
                }
            }

            switch (life)
            {
                case 0:
                    life1.Visible = false;
                    life2.Visible = false;
                    life3.Visible = false;
                    MessageBox.Show("GAME OVER");
                    break;
                case 1:
                    life1.Visible = true;
                    life2.Visible = false;
                    life3.Visible = false;
                    break;
                case 2:
                    life1.Visible = true;
                    life2.Visible = true;
                    life3.Visible = false;
                    break;
                case 3: 
                    life1.Visible = true;
                    life2.Visible = true;
                    life3.Visible = true;
                    break;
            }
        }

        private void blocks()
        {
            foreach (PictureBox x in this.Controls)
            {int broke3 = 0;
                int broke = 0;
                int broke2 = 0;
                
                if (x.Tag == "block")
                {
                    if (pictureBoxBall.Bounds.IntersectsWith(x.Bounds))
                    {
                        Controls.Remove(x);
                        verticalBallMovement -= verticalBallMovement;
                        verticalBallMovement += 1;

                    }
                }
                else
                {
                    if (x.Tag == "blockmore")
                    {
                        if (pictureBoxBall.Bounds.IntersectsWith(x.Bounds))
                        {
                            Controls.Remove(x);
                            verticalBallMovement -= verticalBallMovement;
                            verticalBallMovement += 1;

                        }
                    }
                    else
                    {
                        if (x.Tag == "blockard1")
                        {
                             broke = 0;
                            if (pictureBoxBall.Bounds.IntersectsWith(x.Bounds))
                            {
                                broke += 1;
                                verticalBallMovement += 1;
                                if (broke == 2)
                                {
                                    Controls.Remove(x);
                                    verticalBallMovement -= verticalBallMovement;
                                    verticalBallMovement += 1;
                                }


                            }
                        }
                        else
                            {
                                if (x.Tag == "blockard2")
                                {
                                     broke2 = 1;
                                    if (pictureBoxBall.Bounds.IntersectsWith(x.Bounds))
                                    {
                                        broke2 -= 1;
                                        verticalBallMovement += 1;
                                        if (broke2 < 0)
                                        {
                                            Controls.Remove(x);
                                            verticalBallMovement -= verticalBallMovement;
                                            verticalBallMovement += 1;
                                        }
                                    }
                                }
                                else
                                {
                                    
                                    if (x.Tag == "blockard3")
                                    {
                                        
                                        if (pictureBoxBall.Bounds.IntersectsWith(x.Bounds))
                                        {
                                            broke3 += 1;
                                            verticalBallMovement += 1;
                                            if (broke3 == 2)
                                            {
                                                Controls.Remove(x);
                                                verticalBallMovement -= verticalBallMovement;
                                                verticalBallMovement += 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
        }
    }
    
}