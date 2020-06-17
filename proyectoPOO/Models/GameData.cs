namespace proyectoPOO
{
    public static class GameData
    {
            public static bool statusGame = false;
            public static int lifes = 3, points = 0;

            public static void InicializarJuego()
            {
                statusGame = false;
                lifes = 3;
                points = 0;
            }
       
    }
}