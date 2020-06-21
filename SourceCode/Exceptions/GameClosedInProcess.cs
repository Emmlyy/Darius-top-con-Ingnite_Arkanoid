using System;

namespace proyectoPOO.Exceptions
{
    public class GameClosedInProcess : Exception
    {
        public GameClosedInProcess(string message) : base(message)
        {
            
        }
    }
}