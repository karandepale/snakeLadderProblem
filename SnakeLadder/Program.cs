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

            // UC2:- Roll the die to get a random number between 1 and 6
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("The player rolled a die and got: " + dieRoll);

            // UC3:- Check for options: No Play, Ladder, or Snake
            int option = random.Next(0, 3); // Randomly select an option (0 = No Play, 1 = Ladder, 2 = Snake)

            switch (option)
            {
                case 0: // No Play
                    Console.WriteLine("No Play. The player stays in the same position.");
                    break;
                case 1: // Ladder
                    Console.WriteLine("Ladder. The player moves ahead by " + dieRoll + " positions.");
                    currentPosition += dieRoll;
                    break;
                case 2: // Snake
                    Console.WriteLine("Snake. The player moves behind by " + dieRoll + " positions.");
                    currentPosition -= dieRoll;
                    break;
            }

            Console.WriteLine("Current Position: " + currentPosition);
        }
    }
}
