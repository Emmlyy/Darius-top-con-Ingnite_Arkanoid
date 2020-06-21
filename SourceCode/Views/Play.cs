using System;
using System.Windows.Forms;
using proyectoPOO.Controllers;
using proyectoPOO.Exceptions;
using proyectoPOO.Models;

namespace proyectoPOO.Views
{ 
    public partial class Play : UserControl
    {    
        public Play()
        {
            InitializeComponent();
            
        }
        private void BttnPlay_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("¡Debe registrarse para poder jugar!");
            }
            else
            {
                try
                {
                    //Query to DB
                    User u = new User();
                    if (txtUsuario.Text.Length >= 20)
                    {
                        throw new NameLength("Name Very Long");
                    }

                    u = ControllersGame.Exist(txtUsuario.Text);

                    MessageBox.Show("Bienvenido: " + u.name + ".\n Tus puntos actuales son: " + u.point);
                    Form temp = this.FindForm();
                    temp.Hide();

                    //temp.Dispose();
                    FrmGame game = new FrmGame(u);
                    game.ShowDialog();
                }
                //Custom Exception for Create User
                catch (UserException ex)
                {
                    MessageBox.Show(ex.Message + "Creando...");
                    ControllersGame.Add(txtUsuario.Text);
                    MessageBox.Show("Registrado\n" + "Nickname: " + txtUsuario.Text + "\nPuntos: 0");
                }
                //Custom Exception for Very long name
                catch (NameLength)
                {
                    MessageBox.Show("Nombre demasiado largo");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
        
        private void Play_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Los bloques dan diferente puntaje dependiendo de su color, presionas espacio para iniciar el juego\n" +
                                  "\nPara jugar necesitas Entrar o registrar tu nickname, ¡Disfruta!");
        }
    }
}