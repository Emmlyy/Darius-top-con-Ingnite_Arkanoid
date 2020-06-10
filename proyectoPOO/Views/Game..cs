using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using proyectoPOO.picturebox;

namespace proyectoPOO
{
    public partial class Game_ : Form
    {
        public const int Xard = 10;
        public const int Yard = 1;
        public int verticalBallMovement;
        public int horizontalBallMovement;
        public int life, points;
        private bool statusGame = false;
        public const int Xtile = 10;
        public const int Ytile = 5;
        private picturebox.picturebox[,] cp;
      /*  private picturebox.PictureBlock[,] Blocks;*/
        public Game_()
        { 
            InitializeComponent();
            life = 3;
            points = 0;
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            statusGame = false;
            horizontalBallMovement = 10;
            verticalBallMovement = -horizontalBallMovement;
        }
private void Game__Load(object sender, EventArgs e)
        {
            loadTiles();
            loadPlayer();
            Life();
         
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
               life -= 1;
               MessageBox.Show("-1 vida");
               Life();
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
           } }

        private void blocks()
        {
            if (pictureBoxBall.Left == 0 || pictureBoxBall.Right == 0)
            {
                horizontalBallMovement = -horizontalBallMovement;
                return;
            }

            if (life == 0)
            {
                Life();
                Application.Exit();
            }

            for (int y = 0; y < Ytile; y++)
            {

                for (int x = 0; x < Xtile; x++)
                {
                    if (pictureBoxBall.Bounds.IntersectsWith(cp[y, x].Bounds) && cp[y, x].Visible == true)
                    {
                        if (cp[y, x].Golpes > 0)
                        {
                            horizontalBallMovement = -horizontalBallMovement;
                            verticalBallMovement = -verticalBallMovement;
                            cp[y, x].Golpes--;
                            changepicture(cp[y, x]);
                            if (cp[y, x].Golpes == 0)
                            {
                                points += 1;
                                cp[y, x].Visible = false;
                                Controls.Remove(cp[y, x]);
                                horizontalBallMovement = -horizontalBallMovement;
                                verticalBallMovement = -verticalBallMovement;

                            }

                          



                        }

                    }

                }
            }
        }

       

        private void changepicture(picturebox.picturebox block)
        {
            
            block.BackgroundImage = Image.FromFile("../../Sprites/1.5.png");
            
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
            lbPoints.Text = points.ToString();
            //detect collision with block
          
            blocks();
           
            /*Player_rebound();*/
            Life();

        }

        private void Game__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                statusGame = true;
            }
        }
        private void Life()
        {
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
    }
    }
