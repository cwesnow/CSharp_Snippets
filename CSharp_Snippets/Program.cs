using System;

namespace CSharp_Snippets
{
    class Program
    {
        static void Main()
        {
            int x = 0;

            screenSetup();

            // Main Menu
            Console.WriteLine(
                "{0}Welcome to C#{0}" +
                "{0}[1] SpaceShip - Console Output, Loops{0}" +
                "{0}[2] Calculator - Math{0}" +
                "{0}[3] Guess my Number - Computer guesses your number{0}" +
                "{0}[4] Registration - Enter Date{0}" +
                "{0}[5] OOP - Abstract & Interface{0}" +
                "{0}[6] Auction Posts - Using Lists{0}" +
                "{0}[7] Exception Handling - Number Range"
                , Environment.NewLine
                );
            
            x = getInput();

            Console.Clear();
            
            if (x == 1) { Spaceship.play(); }
            if (x == 2) { Calculator.play(); }
            if (x == 3) { GuessNumber.play(); }
            if (x == 4) { Registration.play(); }
            if (x == 5) { OOP.play(); }
            if (x == 6) { AuctionPosts.play(); }
            if (x == 7) { ThrowException.play(); }
        }

        static void screenSetup()
        {
            Console.Title = "C# Snippets";
        }

        static int getInput()
        {
            int x = 0;
            Int32.TryParse(Console.ReadLine(), out x);
            return x;
        }

    }
}