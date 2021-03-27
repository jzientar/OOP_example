using System;

namespace OOP_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Shooter Doom = new Shooter(1);
            Doom.connect();
            Doom.soloPlay(); 
            Console.WriteLine($"Doom is currently running for " + Doom.gameType + " mode.");
            Doom.stopGame();
            Doom.disconnect();

            Game Game = new Shooter(5);
            IClassGame Shooter = new Shooter(2);
        }
    }
}
