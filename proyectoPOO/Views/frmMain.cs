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
    public partial class frmMain : Form
    {
        private UserControl change;
        private Play jg = new Play();

        public frmMain()
        {
            InitializeComponent();
            //Maximizar ventana
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            
            //???
            jg.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            jg.Dock = DockStyle.Fill;
        }

        private void bntPlayy_Click(object sender, EventArgs e)
        {
            //ocultar los botones de la ventana
            btnPlayy.Visible = false;
            btnPoint.Visible = false;
            btnClosed.Visible = false;
            
            //cambiar el usercontrol
            tableLayoutPanel1.Controls.Remove(change);
            tableLayoutPanel1.Controls.Add(jg, 0, 0);
            change = jg;
            tableLayoutPanel1.SetRowSpan(change,6);
            tableLayoutPanel1.SetColumnSpan(change, 3);   
        }

        private void bntPoint_Click(object sender, EventArgs e)
        {
            //ocultar los botones de la ventana
            btnPlayy.Visible = false;
            btnPoint.Visible = false;
            btnClosed.Visible = false;
            pictureBox1.Hide();
            
            //cambiar userControl
            tableLayoutPanel1.Controls.Remove(change);
            change = new Score();
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Application.Restart();
                
            }
        }
    }
}