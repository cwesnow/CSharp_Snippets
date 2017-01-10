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
                "[9] Encoder"
                , Environment.NewLine
                );

            switch (getInput(0,9)) {
                case QUIT: Environment.Exit(0); break;
                case 1: Spaceship.play(); break;
                case 2: Calculator.play(); break;
                case 3: GuessNumber.play(); break;
                case 4: Registration.play(); break;
                case 5: OOP.play(); break;
                case 6: AuctionPosts.play(); break;
                case 7: ThrowException.play(); break;
                case 8: FarenheitToCelsius.play(); break;
                case 9: LengthEncoder.play(); break;

                default:
                    Console.WriteLine("Invalid number! Try another option or use {0} to quit.", QUIT);
                    Console.ReadKey();
                    break;
            }

            Console.Clear();
            Main();
        }

        static void screenSetup()
        {
            Console.Title = "C# Examples";
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
            while ( !inputValid );
            return x;
        }

    } // class
} // namespace