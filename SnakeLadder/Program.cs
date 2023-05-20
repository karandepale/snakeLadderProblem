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
            int diceRolls = 0;

            while (currentPosition < finalPosition)
            {
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

                        if (currentPosition + dieRoll <= finalPosition)
                            currentPosition += dieRoll;
                        break;
                    case 2: // Snake
                        Console.WriteLine("Snake. The player moves behind by " + dieRoll + " positions.");
                        currentPosition -= dieRoll;

                        if (currentPosition < 0)
                            currentPosition = 0; // Restart from position 0 if position goes below 0
                        break;
                }

                diceRolls++;
                Console.WriteLine("Current Position: " + currentPosition);
            }

            Console.WriteLine("Congratulations! The player has reached the winning position.");
            Console.WriteLine("Number of dice rolls: " + diceRolls);
        }
    }
}
