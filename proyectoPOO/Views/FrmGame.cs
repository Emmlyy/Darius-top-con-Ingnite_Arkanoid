using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using proyectoPOO.picturebox;

namespace proyectoPOO
{
    public partial class FrmGame : Form
    {
        //borrar?
        public const int Xard = 10;
        public const int Yard = 1;
        
        public int verticalBallMovement;
        public int horizontalBallMovement;
        
        //cambiar esto ya que creo q tambien tiene q ir desde GameData
        public const int Xtile = 10;
        public const int Ytile = 5;
        
        //Elementos visuales de la ventana
        private picturebox.picturebox[,] cp;
        private Label points;
        private Panel scores;
        private PictureBox[] life;
        
      /*  private picturebox.PictureBlock[,] Blocks;*/
      
        public FrmGame()
        { 
            InitializeComponent();
            
            //Maximizar pantalla
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            
            //explicar para que es
            horizontalBallMovement = 10;
            verticalBallMovement = -horizontalBallMovement;
        }
    private void Game__Load(object sender, EventArgs e)
        {
            LoadTiles();
            LoadPlayer();
            LoadPanel();
        }
     
        private void LoadPlayer()
        {
            //PLATAFORMA
            Player.BackgroundImage = Image.FromFile("../../Sprites/Player.png");
            Player.BackgroundImageLayout = ImageLayout.Stretch;
            Player.Top = (Height - Player.Height )- 80;
            Player.Left = (Width / 2)-(Player.Width/2);
            
            //PELOTA
            pictureBoxBall.BackgroundImage = Image.FromFile("../../Sprites/Ball.png");
            Player.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxBall.Top = (Player.Top - pictureBoxBall.Height );
            pictureBoxBall.Left = (Width / 2);
            
        }

        
        private void LoadTiles()
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

        private void Movement()
        {
            pictureBoxBall.Top += -verticalBallMovement;
            pictureBoxBall.Left += horizontalBallMovement;
            
           if (pictureBoxBall.Bottom > this.ClientSize.Height)
           {
               //REINICIAR 
               pictureBoxBall.Top = (Player.Top - pictureBoxBall.Height );
               GameData.statusGame = false;
               GameData.lifes -= 1;
               MessageBox.Show("-1 vida");
               timer1.Stop();
               UptadeLife();
               
               if (GameData.lifes == 0)
               {
                   timer1.Stop();
                 //TERMINAR JUEGO
               }
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

        private void Blocks()
        {
            if (pictureBoxBall.Left == 0 || pictureBoxBall.Right == 0)
            {
                horizontalBallMovement = -horizontalBallMovement;
                return;
            }

            /* 
             if (GameData.lifes == 0)
            {
                Application.Exit(); 
            }*/

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
                            Changepicture(cp[y, x]);
                            if (cp[y, x].Golpes == 0)
                            {
                                GameData.points += 1;
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
        
        private void Changepicture(picturebox.picturebox block)
        {
            
            block.BackgroundImage = Image.FromFile("../../Sprites/1.5.png");
            
        }


        private void Game__MouseMove(object sender, MouseEventArgs e)
        {
            if (!GameData.statusGame)
            {
                if (e.X < (Width - Player.Width))
                {
                    Player.Left = e.X;
                    pictureBoxBall.Left = Player.Left + (Player.Width / 2) - (pictureBoxBall.Width / 2);
                }
            }
            if (e.X < (Width - Player.Width))
            {
                Player.Left = e.X;
                
            }
        }

        private void TimerForMovements_Tick(object sender, EventArgs e)
        {
            if (!GameData.statusGame)
            {
                return;
            }

            Movement();
            //detect collision with block
            Blocks();

        }

        private void Game__KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                GameData.statusGame = true;
                timer1.Start();
            }
            
        }

        private void LoadPanel()
        {
           
            // Instanciar panel
            scores = new Panel();

            // Setear elementos del panel
            scores.Width = Width;
            scores.Height = (int)(Height * 0.07);
            scores.Top = scores.Left = 0;
            scores.BackColor = Color.Black;
            
            life = new PictureBox[GameData.lifes];

            for(int i = 0; i < GameData.lifes; i++)
            {
                // Instanciacion de pb
                life[i] = new PictureBox();

                life[i].Height = life[i].Width = scores.Height;

                life[i].BackgroundImage = Image.FromFile("../../Sprites/Heart.png");
                life[i].BackgroundImageLayout = ImageLayout.Stretch;

                life[i].Top = 0;

                if (i == 0)
                     life[i].Left = 20;
                else
                {
                    life[i].Left = life[i - 1].Right + 5;
                }
            }
            

            // Instanciar labels
            points = new Label();

            // Setear elementos de los labels
            points.ForeColor = Color.White;
            points.Text = GameData.lifes.ToString();
            points.Left = Width - 100;
            points.Font= new Font("Times New Roman",24);
            
            scores.Controls.Add(points);

            foreach(var pb in life)
            {
                scores.Controls.Add(pb);
            }

            Controls.Add(scores); 
        }
        
        private void UptadeLife()
        {
            scores.Controls.Remove(life[GameData.lifes]);
            life[GameData.lifes] = null;
        }
    }
    }
