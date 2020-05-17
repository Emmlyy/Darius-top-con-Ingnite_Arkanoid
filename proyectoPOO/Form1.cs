using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoPOO
{
    public partial class Form1 : Form
    {
        private UserControl change;
        private Jugar jg = new Jugar();
        private Puntaje pun = new Puntaje();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            button3.Hide();
            pictureBox1.Hide();
            tableLayoutPanel1.Controls.Add(jg,2,4);
            change = jg;
            tableLayoutPanel1.SetRowSpan(change,6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            throw new System.NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro(a) que desea salir del sistema?",
                "Consulta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}