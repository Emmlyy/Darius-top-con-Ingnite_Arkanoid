using System;
using System.Drawing;
using System.Windows.Forms;
using proyectoPOO.Controllers;
using proyectoPOO.Exceptions;
using proyectoPOO.Models;

namespace proyectoPOO.Views
{
    public partial class FrmGame : Form
    {
        //Movements of ball
        public int verticalBallMovement, horizontalBallMovement;
        public User user = new User();//Model of Player
        
        //number of rows and columns of blocks
        public const int Xtile = 10, Ytile = 5;
        
        //Visual elements of the WindowsForm
        private Pic[,] cp;
        private Label lblPoints;
        private Panel pnlScores;
        private PictureBox[] picLife;
      
        public FrmGame(User u)
        { 
            InitializeComponent();
            user = u;
            
            //Maximize window
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            
            //Used for the initial movement of the ball
            horizontalBallMovement = 7;
            verticalBallMovement = -horizontalBallMovement;
        }
        private void Game_Load(object sender, EventArgs e)
        {
            LoadTiles();
            LoadPlayer();
            LoadPanel();
        }
     
        private void LoadPlayer()
        {
            //Plataform
            Player.BackgroundImage = Image.FromFile("../../Sprites/Player.png");
            Player.BackgroundImageLayout = ImageLayout.Stretch;
            Player.Top = (Height - Player.Height )- 80;
            Player.Left = (Width / 2)-(Player.Width/2);
            
            //Ball
            Ball.BackgroundImage = Image.FromFile("../../Sprites/Ball.png");
            Player.BackgroundImageLayout = ImageLayout.Stretch;
            Ball.Top = (Player.Top - Ball.Height );
            Ball.Left = (Width / 2);
            
        }
        //Set Blocks
        private void LoadTiles()
        {
           
            int PHeigt = (int) (Height  * 0.3) / Ytile;
            int pwidth = Width / Xtile;
            cp =  new Pic[Ytile,Xtile];
            
            for (int i=0; i < Ytile; i++)
            {
                for (int j = 0; j < Xtile; j++)
                {
                    cp[i,j] = new Pic();
                    if (i == 0)
                        cp[i, j].Hits = 2;
                    else
                        cp[i, j].Hits = 1;

                    cp[i, j].Height = PHeigt;
                    cp[i, j].Width = pwidth;
                    
                    //position de left  y top
                    cp[i, j].Left = j * pwidth;
                    cp[i, j].Top = i * PHeigt +60;
                    
                    cp[i,j].BackgroundImage = Image.FromFile("../../Sprites/" + ( i + 1 ) + ".png");
                    cp[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                    cp[i, j].Tag = (i+1).ToString();
                    //ADD rows and columns to the form
                    Controls.Add(cp[i, j]);
                }
                
                
            }
        }
        //Infinite Movement
        private void Movement()
        {
            //Position
            Ball.Top += -verticalBallMovement;
            Ball.Left += horizontalBallMovement;
            //When the ball touches the window's bottom edge a life is lost    
            if (Ball.Bottom > this.ClientSize.Height)
            {
                //Restart 
                LoadPlayer();
                GameData.statusGame = false;
                GameData.lifes -= 1;//life lost
                UptadeLife();
                MessageBox.Show("-1 vida");
                if (GameData.lifes == 0)
                {
                    dtptimerForMovements.Stop();
                    EndGame();
                    //End Game
                }
            }
            //Negative VerticalMovement
            else if (Ball.Top < 0)
            {
                verticalBallMovement = -verticalBallMovement; 
            }
            //Negative HorizontalMovement
            else if (Ball.Right > this.ClientSize.Width)
            {
               horizontalBallMovement = -horizontalBallMovement;
            }
            //for the lateral edges
            else if (Ball.Left < 0)
            {
               horizontalBallMovement = -horizontalBallMovement;
            }
            //For the ball when it touch the platform
            if (Ball.Bounds.IntersectsWith(Player.Bounds)==true)
            {
               verticalBallMovement = -verticalBallMovement;
            } }
        //When the game is over to win or lose
        private void EndGame()
        {
            ControllersGame.Update(user);//Update points
            Form temp = this.FindForm();
            temp.Controls.Clear();
            if (MessageBox.Show("¿Desea jugar otra partida?",
                "Consulta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Reload Data al newForm
                GameData.InitializeGame();
                //Application.Restart();
                LoadTiles();
                LoadPlayer();
                LoadPanel();
                temp.Close();
                FrmGame newGame = new FrmGame(user);
                newGame.Show();
            }
            else
            {
                //Restart App!
                Application.Restart();
            }
        }
        //For Collisions
        private void Blocks()
        {
            for (int y = 0; y < Ytile; y++)
            {
                for (int x = 0; x < Xtile; x++)
                {
                    if (Ball.Bounds.IntersectsWith(cp[y, x].Bounds) && cp[y, x].Visible == true)
                    {
                        //Invert movement when there is Collision
                        verticalBallMovement = -verticalBallMovement;
                        if (cp[y, x].Hits > 0)
                        {
                            cp[y, x].Hits--;
                            Changepicture(cp[y, x]);
                            if (cp[y, x].Hits == 0)
                            {
                                switch (cp[y,x].Tag)
                                {
                                    case "5":
                                        GameData.points += 1;
                                        break;
                                    case "4" :
                                        GameData.points += 2;
                                        break;
                                    case "3":
                                        GameData.points += 3;
                                        break;
                                    case "2":
                                        GameData.points += 4;
                                        break;
                                    case "1":
                                        GameData.points += 5;
                                        break;
                                    default:
                                        GameData.points += 1;
                                        break;
                                }
                                lblPoints.Text = GameData.points.ToString();//Update points in WindowsForm
                                cp[y, x].Visible = false;
                                Controls.Remove(cp[y, x]);
                                //when you win 
                                if (GameData.points == 150)
                                {
                                    dtptimerForMovements.Stop();
                                    MessageBox.Show("Felicidades, has ganado!");
                                    EndGame();
                                }
                            }
                            
                            return;
                        }

                    }

                }
            }
        }
        //For to change image to the last blocks line
        private void Changepicture(Pic block)
        {
            block.BackgroundImage = Image.FromFile("../../Sprites/1.5.png");
        }
        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            Player.Left = e.X -( Player.Width/2);
            if (!GameData.statusGame)
            {
                if (e.X < (Width - Player.Width))
                {
                    Player.Left = e.X -( Player.Width/2);
                    Ball.Left = Player.Left + (Player.Width / 2) - (Ball.Width / 2);
                    Ball.Top = (Player.Top - Ball.Height );
                }
            }
            if (e.X < (Width - Player.Width))
            {
                Player.Left = e.X -( Player.Width/2);
                
            }
        }
        private void TimerForMovements_Tick(object sender, EventArgs e)
        {
            if (!GameData.statusGame)
            {
                return;
            }
            //movement of the ball
            Movement();
            //detect collision with block
            Blocks();

        }
        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                GameData.statusGame = true;
            }
            
        }
        private void LoadPanel()
        {
           
            // instantiate panel
            pnlScores = new Panel();

            // Set panel elements
            pnlScores.Width = Width;
            pnlScores.Height = (int)(Height * 0.07);
            pnlScores.Top = pnlScores.Left = 0;
            pnlScores.BackColor = Color.Black;
            
            picLife = new PictureBox[GameData.lifes];

            for(int i = 0; i < GameData.lifes; i++)
            {
                // Instantiate pictureBox
                picLife[i] = new PictureBox();

                picLife[i].Height = picLife[i].Width = pnlScores.Height;

                picLife[i].BackgroundImage = Image.FromFile("../../Sprites/Heart.png");
                picLife[i].BackgroundImageLayout = ImageLayout.Stretch;

                picLife[i].Top = 0;

                if (i == 0)
                     picLife[i].Left = 20;
                else
                {
                    picLife[i].Left = picLife[i - 1].Right + 5;
                }
            }
            

            // instance labels
            lblPoints = new Label();

            // Set elements of the labels
            lblPoints.ForeColor = Color.White;
            lblPoints.Text = GameData.points.ToString();
            lblPoints.Left = Width - 100;
            lblPoints.Height = pnlScores.Height;
            lblPoints.Font= new Font("Times New Roman",28F);
            
            pnlScores.Controls.Add(lblPoints);

            foreach(var pb in picLife)
            {
                pnlScores.Controls.Add(pb);
            }

            Controls.Add(pnlScores); 
        }
        private void UptadeLife()
        {
            pnlScores.Controls.Remove(picLife[GameData.lifes]);
            picLife[GameData.lifes] = null;
        }

        private void FrmGame_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                if (GameData.lifes<=3 && GameData.lifes>=0 && GameData.points>0)
                {
                    throw new GameClosedInProcess("Have 1+ Points");
                }
            }
            catch (GameClosedInProcess)
            {
                dtptimerForMovements.Stop();
                if (MessageBox.Show($"¿Desea guardar sus puntos actuales? Actualemente tienes: {GameData.points} puntos",
                    "Consulta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    ControllersGame.Update(user);
                    Application.Exit(); 
                }
            }
        }

       
    }
    }
