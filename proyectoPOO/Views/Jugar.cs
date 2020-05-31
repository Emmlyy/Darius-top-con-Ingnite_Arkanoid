using System;
using System.Data;
using System.Windows.Forms;

namespace proyectoPOO
{ 
    public partial class Jugar : UserControl
    {    
        public Jugar()
        {
            InitializeComponent();
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Debe ingresar un usuario para poder jugar!");
            }
            else
            {
                try
                {
                    string sql = "SELECT \"UserID\",\"Points\" FROM public.\"User\" WHERE \"UserID\"='"+txtUsuario.Text+"';";
                    var user = Connection.Query(sql);
                    string name = user.Rows[0][0].ToString();
                    string points = user.Rows[0][1].ToString();
                    MessageBox.Show("Bienvenido: " +name +"\nTus puntos actuales son: "+points);
                }
                catch (Exception)
                {
                    string noSql = "INSERT INTO public.\"User\"(\"UserID\", \"Points\")VALUES ('"+txtUsuario.Text+"', 0);";
                    Connection.noQuery(noSql);
                    MessageBox.Show("Registrado\n"+"Nickname: "+txtUsuario.Text+"\nPuntos: 0");
                }
            }
        }
    }
}