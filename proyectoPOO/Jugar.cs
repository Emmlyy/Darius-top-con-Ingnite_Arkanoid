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
            string sql = "SELECT \"UserID\",\"Points\" FROM public.\"User\" WHERE \"UserID\"='"+txtUsuario.Text+"';";
            Connection.Query(txtUsuario.Text);
        }
    }
}