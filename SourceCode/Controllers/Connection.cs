using System.Data;
using Npgsql;

namespace proyectoPOO.Controllers
{
    public static class Connection
    {
        private static string ConnectionString = 
            "Server=127.0.0.1;Port=5432;User Id=postgres;Password=uca;Database=Arkanoid";

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