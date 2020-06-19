using System;
using System.Collections.Generic;
using System.Data;

namespace proyectoPOO
{
    public static class ControllersGame
    {
        public static List<User> Top()
        {
            string sql = "SELECT \"UserID\", \"Points\" FROM public.\"User\" ORDER BY \"Points\"" +
                         " DESC FETCH FIRST 10 ROWS ONLY;";
            List<User> list = new List<User>();
            DataTable dt= Connection.Query(sql);
            foreach (DataRow fila in dt.Rows)
            {
                User u= new User();
                u.name = fila[0].ToString();
                u.point=Convert.ToInt32(fila[1].ToString());
                list.Add(u);
            }
            return list;
        }

        public static User Exist(string nameU)
        {
            string sql = $"SELECT \"UserID\",\"Points\" FROM public.\"User\" WHERE \"UserID\"='" + nameU + "';";
            var user = Connection.Query(sql);

            if (user == null)
            {
                throw new UserException("no existe el usuario");
            }
            User u=new User();
            u.name= user.Rows[0][0].ToString();
            u.point= Convert.ToInt32(user.Rows[0][1].ToString());
            

            return u;
        }

        public static void Add(string nameU)
        {
            string noSql = "INSERT INTO public.\"User\"(\"UserID\", \"Points\")VALUES ('"+nameU+"', 0);";
            Connection.noQuery(noSql);
            
        }

        public static void Update(User u)
        {
            string noSql = $"UPDATE \"User\" SET \"Points\"= \"Points\" + {GameData.points} WHERE \"UserID\" = '{u.name}';";
            Connection.noQuery(noSql);
        }
    }
}