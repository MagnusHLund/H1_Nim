namespace H1_Nim
{
    internal class Program
    {
        static int sticks = 7;
        static bool playersTurn;
        static bool gameOver;

        static void Main()
        {
            // Creates an int variable called "input"
            int input;

            Random random = new Random();

            // Changes the text color to blue and outputs the amount of sticks
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Pinde på bordet: {sticks}");

            // Creates an infinite while loop
            while (true)
            {
                // Changes the text color to green, as well as outputting some text in the console
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Din tur!");
                Console.WriteLine("Skriv et tal mellem 1-3");

                // Parse the user input to an int and runs the while loop, if its a valid parse.
                while (int.TryParse(Console.ReadLine(), out input))
                {
                    // If input is more than 3, then input should be 3 or less, if there are not 3 sticks.
                    if (input > 3)
                    {
                        if (input < sticks)
                        {
                            input = 3;
                        }
                        else
                        {
                            input = sticks - 1;
                        }

                        // Tells the user that their input has been edited, because it was higher than 3
                        Console.WriteLine($"Dit tal blev redigeret til {input}");
                    }

                    // Changes the text color to blue and reduces the amount of sticks and breaks the while loop
                    Console.ForegroundColor = ConsoleColor.Blue;
                    sticks -= input;
                    break;
                }

                // if sticks are below 1, then then set sticks to 1
                if (sticks <= 0)
                    sticks = 1;

                // Displays the sticks on the table, in the console
                Console.WriteLine($"Pinde på bordet: {sticks}");

                // if the "sticks" variable is 1, then it figures out the winner, based on the playersTurn variable
                if (sticks == 1)
                {
                    if (playersTurn)
                    {
                        Console.WriteLine("Player won!");
                    }
                    else
                    {
                        Console.WriteLine("Computer won!");
                    }

                    // Sets the gameOver boolean variable to true, because the game ended
                    gameOver = true;
                }

                // Changes the players turn to false, as well as breaking out of the loop, if the game is over
                playersTurn = false;
                if (gameOver)
                    break;

                // Changes the text to green and writes in the console
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Computerens tur!");

                // If there are more sticks than 3, then the computer can pick 1, 2 or 3. Else the computer can only pick up to the amount of sticks -1
                if (sticks > 3)
                    sticks -= random.Next(1, 4);
                else
                    sticks -= random.Next(1, sticks);

                // if sticks are below 1, then then set sticks to 1
                if (sticks <= 0)
                    sticks = 1;

                // Displays the sticks on the table, in the console
                Console.WriteLine($"Pinde på bordet: {sticks}");

                // if the "sticks" variable is 1, then it figures out the winner, based on the playersTurn variable
                if (sticks == 1)
                {
                    if (playersTurn)
                    {
                        Console.WriteLine("Player won!");
                    }
                    else
                    {
                        Console.WriteLine("Computer won!");
                    }

                    // Sets the gameOver boolean variable to true, because the game ended
                    gameOver = true;
                }

                // Changes the players turn to true, as well as breaking out of the loop, if the game is over
                playersTurn = true;
                if (gameOver)
                    break;
            }
        }
    }
}
