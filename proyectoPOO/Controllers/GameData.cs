namespace proyectoPOO
{
    public class GameData
    {
            public static bool statusGame = false;
        
            public static int dirX = 10, dirY = -dirX, lifes = 3, points = 0;
            public const int Xtile = 10;
            public const int Ytile = 5;
            
            public static void InicializarJuego()
            {
                statusGame = false;
                lifes = 3;
                points = 0;
            }
       
    }
}