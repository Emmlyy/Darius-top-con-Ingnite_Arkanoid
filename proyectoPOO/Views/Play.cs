﻿using System;
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
                    string sql = "SELECT \"UserID\",\"Points\" FROM public.\"User\" WHERE \"UserID\"='"+txtUsuario.Text+"';";
                    var user = Connection.Query(sql);
                    string name = user.Rows[0][0].ToString();
                    string points = user.Rows[0][1].ToString();
                    MessageBox.Show("Bienvenido: " +name +"\nTus puntos actuales son: "+points);
                    Form temp = this.FindForm();
                    temp.Hide();
                    //temp.Dispose();
                    FrmGame game = new FrmGame();
                    game.ShowDialog();
                }
                catch (Exception)
                {
                    //Agregar Usuario a la BD
                    string noSql = "INSERT INTO public.\"User\"(\"UserID\", \"Points\")VALUES ('"+txtUsuario.Text+"', 0);";
                    Connection.noQuery(noSql);
                    MessageBox.Show("Registrado\n"+"Nickname: "+txtUsuario.Text+"\nPuntos: 0");
                }
            }
        }
    }
}