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

        public static DataTable Query(string query)
        {
            NpgsqlConnection db = new NpgsqlConnection(herokuConnectionString);
            DataSet ds = new DataSet();
            db.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query,db);
            da.Fill(ds);
            db.Close();
            return ds.Tables[0];
        }

        public static void noQuery(string _noQuery)
        {
            NpgsqlConnection db = new NpgsqlConnection(herokuConnectionString);
            db.Open();
            NpgsqlCommand noQuery = new NpgsqlCommand(_noQuery, db);
            noQuery.ExecuteNonQuery();
            db.Close();
        }
    }
}