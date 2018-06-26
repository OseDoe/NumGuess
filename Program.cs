using System;

namespace NumberGuesser
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Starter function
            GetAppInfo();
            GreetUser();

            while (true)
            {
                // Set number to guess randomly
                Random rndm = new Random();
                int correctNumber = rndm.Next(1, 11);

                // Set user guess
                int guess = 0;

                // Game loop
                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Validate number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "That's not a number, please try again!");

                        // Keep asking
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "That's not the right number! Try again!");
                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You guessed the number!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
            }
        }

        private static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Inform about wrong number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }

        // Ask users name and greet
        private static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }


        // Start
        private static void GetAppInfo()
        {
            // Set app vars
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jose";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

    }
}
