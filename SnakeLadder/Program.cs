using System;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int finalPosition = 100;
            Console.WriteLine("Start Position is: 0");
            Random random = new Random();
            int[] playerPositions = new int[2]; // Array to store positions of two players
            int currentPlayer = 0; // Variable to keep track of current player (0 or 1)
            int diceRolls = 0;

            while (playerPositions[currentPlayer] < finalPosition)
            {
                // UC2:- Roll the die to get a random number between 1 and 6
                int dieRoll = random.Next(1, 7);
                Console.WriteLine("Player " + (currentPlayer + 1) + " rolled a die and got: " + dieRoll);

                // UC3:- Check for options: No Play, Ladder, or Snake
                int option = random.Next(0, 3); // Randomly select an option (0 = No Play, 1 = Ladder, 2 = Snake)

                switch (option)
                {
                    case 0: // No Play
                        Console.WriteLine("No Play. Player " + (currentPlayer + 1) + " stays in the same position.");
                        break;
                    case 1: // Ladder
                        Console.WriteLine("Ladder. Player " + (currentPlayer + 1) + " moves ahead by " + dieRoll + " positions.");

                        if (playerPositions[currentPlayer] + dieRoll <= finalPosition)
                            playerPositions[currentPlayer] += dieRoll;
                        break;
                    case 2: // Snake
                        Console.WriteLine("Snake. Player " + (currentPlayer + 1) + " moves behind by " + dieRoll + " positions.");
                        playerPositions[currentPlayer] -= dieRoll;

                        if (playerPositions[currentPlayer] < 0)
                            playerPositions[currentPlayer] = 0; // Restart from position 0 if position goes below 0
                        break;
                }

                diceRolls++;
                Console.WriteLine("Player " + (currentPlayer + 1) + " current position: " + playerPositions[currentPlayer]);

                if (option != 1) // If the player didn't get a ladder, switch to the next player
                    currentPlayer = (currentPlayer + 1) % 2;
            }

            Console.WriteLine("Congratulations! Player " + (currentPlayer + 1) + " has reached the winning position.");
            Console.WriteLine("Number of dice rolls: " + diceRolls);
            Console.WriteLine("Player " + (currentPlayer + 1) + " wins the game.");
        }
    }
}
