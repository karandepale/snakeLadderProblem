using System;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentPosition = 0;
            int finalPosition = 100;
            Console.WriteLine("Start Position is: " + currentPosition);
            Random random = new Random();

            // UC2:-  Roll the die to get a random number between 1 and 6
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("The player rolled a die and got: " + dieRoll);
        }
    }
}
