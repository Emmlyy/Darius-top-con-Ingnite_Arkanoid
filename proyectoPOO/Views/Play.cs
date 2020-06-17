using System;
using System.Data;
using System.Windows.Forms;

namespace proyectoPOO
{ 
    public partial class Play : UserControl
    {    
        public Play()
        {
            InitializeComponent();
        }


        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un usuario para poder jugar!");
            }
            else
            {
                try
                {

                    //Consultar en la BASE DE DATOS
                    User u = new User();
                    u = ControllersGame.Exist(txtUsuario.Text);

                    MessageBox.Show("Bienvenido: " + u.name + "\nTus puntos actuales son: " + u.point);
                    Form temp = this.FindForm();
                    temp.Hide();

                    //temp.Dispose();
                    FrmGame game = new FrmGame(u);
                    game.ShowDialog();
                }
                //hacemos una excepcion personalizada aqui mejor??
                catch (UserException ex)
                {
                    MessageBox.Show(ex.Message + "creando...");
                    ControllersGame.Add(txtUsuario.Text);
                    
                    MessageBox.Show("Registrado\n"+"Nickname: "+txtUsuario.Text+"\nPuntos: 0");
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
    }
}