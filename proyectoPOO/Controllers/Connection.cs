using System.Data;
using Npgsql;

namespace proyectoPOO.Controllers
{
    public static class Connection
    {
        private static string ConnectionString = @"
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
            NpgsqlConnection db = new NpgsqlConnection(ConnectionString);
            DataSet ds = new DataSet();
            db.Open();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query,db);
            da.Fill(ds);
            db.Close();
            return ds.Tables[0];
        }

        public static void NoQuery(string stringnoQuery)
        {
            NpgsqlConnection db = new NpgsqlConnection(ConnectionString);
            db.Open();
            NpgsqlCommand noQuery = new NpgsqlCommand(stringnoQuery, db);
            noQuery.ExecuteNonQuery();
            db.Close();
        }
    }
}