using System;
using System.Windows.Forms;

namespace proyectoPOO
{ 
    public partial class Jugar : UserControl
    {    private TextBox palabra = new TextBox();
        public Jugar()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            palabra = textBox1;
             Connection.Query(palabra.Text);
        }
    }
}