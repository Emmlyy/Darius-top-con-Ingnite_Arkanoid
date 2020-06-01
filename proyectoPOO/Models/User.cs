namespace proyectoPOO
{
    public class User
    {
        public string name { get; set; }
        public  int point { get; set; }

        public User()
        {
        }

        public User(string name, int point)
        {
            this.name = name;
            this.point = point;
        }
    }
}