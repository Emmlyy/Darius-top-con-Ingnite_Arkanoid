using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace proyectoPOO
{
    public partial class Game_ : Form
    {
        public int verticalBallMovement;
        public int horizontalBallMovement;
        public int life = 3;
        private bool statusGame=false;
        private picturebox.picturebox [,] cp;
        public Game_()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            verticalBallMovement = 10;
            statusGame = false;
            horizontalBallMovement = 10;

        }
        private void Game__Load(object sender, EventArgs e)
        {
            loadTiles();
            loadPlayer();
        }

        private void loadPlayer()
        {
            
            Player.BackgroundImage = Image.FromFile("../../Sprites/Player.png");
            Player.BackgroundImageLayout = ImageLayout.Stretch;
            Player.Top = (Height - Player.Height )- 80;
            Player.Left = (Width / 2)-(Player.Width/2);
            
            pictureBoxBall.Top = (Player.Top - pictureBoxBall.Height );
            pictureBoxBall.Left = (Width / 2);

        }
        private void loadTiles()
        {
            int Xtile = 10;
            int Ytile = 5;
            int PHeigt = (int) (Height  * 0.3) / Ytile;
            int pwidth = Width / Xtile;
            cp =  new picturebox.picturebox[Ytile,Xtile];
            for (int i=0; i < Ytile; i++)
            {
                for (int j = 0; j < Xtile; j++)
                {
                    cp[i,j] = new picturebox.picturebox();
                    if (i == 0)
                        cp[i, j].Golpes = 2;
                    else
                        cp[i, j].Golpes = 1;

                    cp[i, j].Height = PHeigt;
                    cp[i, j].Width = pwidth;
                    
                    //posicion de left  y top
                    cp[i, j].Left = j * pwidth;
                    cp[i, j].Top = i * PHeigt +60;
                    
                    cp[i,j].BackgroundImage = Image.FromFile("../../Sprites/" + ( i + 1 ) + ".png");
                    cp[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    //para despues
                    cp[i, j].Tag = "Tag";
                    Controls.Add(cp[i, j]);
                }
                
                
            }
        }

        private void movement()
        {
            pictureBoxBall.Top += -verticalBallMovement;
            pictureBoxBall.Left += horizontalBallMovement;
           if (pictureBoxBall.Bottom > this.ClientSize.Height)
           {
               pictureBoxBall.Top = (Player.Top - pictureBoxBall.Height );
               statusGame = false;
               //verticalBallMovement = -verticalBallMovement;
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

           if (pictureBoxBall.Bounds.IntersectsWith(Player.Bounds))
           {
               verticalBallMovement = -verticalBallMovement;
           }
           //detect collision with block
             /*  blocks();
               Player_rebound();
               Life();*/
               
                   }


        private void Game__MouseMove(object sender, MouseEventArgs e)
        {
            if (!statusGame)
            {
                Player.Left = e.X;
                pictureBoxBall.Left = e.X + Player.Width/2 - pictureBoxBall.Width/2;
            }
            if (e.X < (Width - Player.Width))
            {
                Player.Left = e.X;
                
            }
        }

        private void timerForMovements_Tick(object sender, EventArgs e)
        {
            if (!statusGame)
            {
                return;
            }

            movement();
        }

        private void Game__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                statusGame = true;
            }
        }
    }
    }
