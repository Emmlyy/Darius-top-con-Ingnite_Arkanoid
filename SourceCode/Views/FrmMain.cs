using System;
using System.Windows.Forms;

namespace proyectoPOO.Views
{
    public partial class FrmMain : Form
    {
        private UserControl change;
        private Play jg = new Play();

        public FrmMain()
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
        private void BttnPlayy_Click(object sender, EventArgs e)
        {
            //Hide Buttons
            bttnPlayy.Visible = false;
            bttnPoint.Visible = false;
            bttnClosed.Visible = false;
            
            //change usercontrol
            pnl.Controls.Remove(change);
            pnl.Controls.Add(jg, 0, 0);
            change = jg;
            pnl.SetRowSpan(change,6);
            pnl.SetColumnSpan(change, 3);   
        }
        private void BttnPoint_Click(object sender, EventArgs e)
        {
            //Hide Buttons
            bttnPlayy.Visible = false;
            bttnPoint.Visible = false;
            bttnClosed.Visible = false;
            pic.Hide();
            
            //change userControl
            pnl.Controls.Remove(change);
            change = new Score();
            change.Dock = DockStyle.Fill;
            pnl.Controls.Add(change, 0, 0);
            pnl.SetRowSpan(change,6);
            pnl.SetColumnSpan(change, 3);  
        }
        private void BttnClosed_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro(a) que desea salir del sistema?",
                "Consulta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                Application.Restart();
            }
        }
    }
}