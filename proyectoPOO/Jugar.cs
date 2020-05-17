using System;
using System.Windows.Forms;

namespace proyectoPOO
{
    public partial class Jugar : UserControl
    {
        private TextBox palabra = new TextBox();
        public Jugar()
        {
            InitializeComponent();
        }

        private void Jugar_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            palabra = textBox1;
            
        }
    }
}