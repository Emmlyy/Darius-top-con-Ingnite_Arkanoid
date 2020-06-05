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
            jg.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jg.Dock = DockStyle.Fill;
        }

        private void bntPlayy_Click(object sender, EventArgs e)
        {
            btnPlayy.Visible = false;
            btnPoint.Visible = false;
            btnClosed.Visible = false;
            tableLayoutPanel1.Controls.Remove(change);
            tableLayoutPanel1.Controls.Add(jg, 0, 0);
            change = jg;
            tableLayoutPanel1.SetRowSpan(change,6);
            tableLayoutPanel1.SetColumnSpan(change, 3);   
        }

        private void bntPoint_Click(object sender, EventArgs e)
        {
            btnPlayy.Visible = false;
            btnPoint.Visible = false;
            btnClosed.Visible = false;
            pictureBox1.Hide();
            tableLayoutPanel1.Controls.Remove(change);
            change = new Puntaje();
            change.Dock = DockStyle.Fill;
            tableLayoutPanel1.Controls.Add(change, 0, 0);
            tableLayoutPanel1.SetRowSpan(change,6);
            tableLayoutPanel1.SetColumnSpan(change, 3);  
        }

        private void bntClosed_Click(object sender, EventArgs e)
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