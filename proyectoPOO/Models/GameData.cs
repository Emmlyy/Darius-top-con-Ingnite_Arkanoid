namespace proyectoPOO.Models
{
    public static class GameData
    {
            public static bool statusGame = false;
            public static int lifes = 3, points = 0;

            public static void InitializeGame()
            {
                statusGame = false;
                lifes = 3;
                points = 0;
            }
       
    }
}