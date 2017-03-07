using System;

namespace CSharp_Snippets
{

    class Program
    {
        static void Main()
        {
            const int QUIT = 0; // Sentinal Value, Exit Code

            screenSetup();

            // Main Menu
            Console.WriteLine(
                "{0}C# Examples{0}{0}" +
                "[0] Quit program{0}" +
                "[1] SpaceShip - Console Output, Loops{0}" +
                "[2] Calculator - Math{0}" +
                "[3] Guess my Number - Computer guesses your number{0}" +
                "[4] Registration - Enter Date{0}" +
                "[5] OOP - Abstract & Interface{0}" +
                "[6] Auction Posts - Using Lists{0}" +
                "[7] Exception Handling - Number Range{0}" +
                "[8] Farenheit conversion to Celsius{0}" +
                "[9] Encoder{0}" +
                "[10] Prime Numbers{0}" +
                "[11] 5 Unique Numbers{0}" +
                "[12] Dictionary of Stats{0}" +
                "[13] Equation Solver"
                , Environment.NewLine
                );

            switch (getInput(0, 13))
            {
                case QUIT: Environment.Exit(0); break;
                case 1: new Spaceship().Play(); break;
                case 2: new Calculator().Play(); break;
                case 3: new GuessNumber().Play(); break;
                case 4: new Registration().Play(); break;
                case 5: new OOP().Play(); break;
                case 6: new AuctionPosts().Play(); break;
                case 7: new ThrowException().Play(); break;
                case 8: new FarenheitToCelsius().Play(); break;
                case 9: new LengthEncoder().Play(); break;
                case 10: new PrimeNumbers().Play(); break;
                case 11: new FiveDigits().Play(); break;
                case 12: new DictionaryStats().Play(); break;
                case 13: new Equation().Play(); break;
                default:
                    Console.WriteLine("Invalid number! Try another option or use {0} to quit.", QUIT);
                    Console.ReadKey();
                    break;
            }
            Main();
        }

        static void screenSetup()
        {
            Console.ResetColor();
            Console.Title = "C# Examples";
            Console.Clear();
        }

        static int getInput(int min, int max)
        {
            int x = 0;
            bool inputValid;
            do
            {
                Console.Write("{0}Input Number:", Environment.NewLine);
                inputValid = Int32.TryParse(Console.ReadLine(), out x);
                if (x < min || x > max) inputValid = false;
            }
            while (!inputValid);
            return x;
        }

    } // class
} // namespace