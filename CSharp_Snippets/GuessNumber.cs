using System;

namespace CSharp_Snippets
{
    class GuessNumber
    {
        public static void play()
        {
            int minimum = 1;
            int maximum = 100;
            int guessedNumber;

            intro();

            while (minimum < maximum)
            {
                guessedNumber = guess(minimum, maximum);
                Console.WriteLine("Is your number {0}?", guessedNumber);

                switch (promptCorrectLowHigh())
                {
                    case "CORRECT":
                        minimum = guessedNumber;
                        maximum = guessedNumber;
                        break;
                    
                    case "LOW":
                        minimum = guessedNumber + 1;
                        break;
                    
                    case "HIGH":
                        maximum = guessedNumber - 1;
                        break;
                }
                errorCheck(minimum, maximum);
                
                if(minimum == maximum) win(guessedNumber);
                
                Console.WriteLine("Min: {0} \t Max: {1}", minimum, maximum);                
            }
            Console.ReadKey();
        }

        private static void errorCheck(int low, int high)
        {
            if (low > high)
            {
                Console.WriteLine("Logic Error! There are no more logical guesses.");

            }
        }
        
        private static void intro()
        {
            Console.WriteLine("{0}{0}Welcome to the Game!{0}{0} Pick a number between 1 and 100 and I'll guess it.{0}",
                Environment.NewLine);
        }

        private static int guess(int low, int high)
        {
            return new Random().Next(low, high);
        }

        private static string promptCorrectLowHigh()
        {
            string input = "";

            while (input != "CORRECT" && input != "LOW" && input != "HIGH")
            {
                Console.WriteLine("Am I Correct, Low, or High? : old input was " + input);
                input = Console.ReadLine().ToUpper();
            }
            return input;
        }

        private static void win(int x)
        {
            Console.WriteLine("Your number was {0}!", x);
        }

    }
}