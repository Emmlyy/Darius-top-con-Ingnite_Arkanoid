using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace proyectoPOO
{
    public class Connection
    {
        private static string herokuConnectionString = @"
          Host=ec2-34-230-149-169.compute-1.amazonaws.com;
          Port=5432;
          Username=uyuljahpmkxlja;
          Password=4921322ee3865f89021745ab38442443be0959390d1f2cbea47d753fbf38e54e;
          Database=dr4v19hahf06q;
          Pooling=true;
          SSL Mode=Require;
          TrustServerCertificate=True;
        ";
        public static void Query(string textUser)
        {
            NpgsqlConnection db = new NpgsqlConnection(herokuConnectionString);
            db.Open(); 
            Console.Write("Todo bien de momento xd");
            string sql = "SELECT \"UserID\",\"Points\" FROM public.\"User\" WHERE \"UserID\"='"+textUser+"';";
            NpgsqlCommand conect = new NpgsqlCommand(sql,db);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(conect);
            DataTable tableData= new DataTable();
            data.Fill(tableData);
            try
            {
                string user = tableData.Rows[0][0].ToString();
                string points = tableData.Rows[0][1].ToString();
                MessageBox.Show("Bienvenido: "+user+"\nTus puntos actuales son: "+points);
            }
            catch (Exception e)
            {
                if (MessageBox.Show("¿Ingresaste un usuario nuevo, deseas registrarlo?",
                    "Consulta",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    Connection.noQuery(db,textUser);
                }
                
            }
            db.Close();

        }

        public static void noQuery(NpgsqlConnection db,string textUser)
        {
            string sql = "INSERT INTO public.\"User\"(\"UserID\", \"Points\")VALUES ('"+textUser+"', 0);";
            NpgsqlCommand cn = new NpgsqlCommand(sql,db);
            cn.ExecuteNonQuery();
            MessageBox.Show("Registrado\n"+"Nickname: "+textUser+"\nPuntos: 0");
        }
    }
}