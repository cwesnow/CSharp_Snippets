﻿using System;

namespace CSharp_Snippets
{
    class GuessNumber : Play
    {
        public void Play()
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
                if (minimum == maximum) win(minimum);
            }

            Console.ReadKey();
        }

        private void errorCheck(int low, int high)
        {
            if (low > high)
            {
                Console.WriteLine("Logic Error! There are no more logical guesses.");

            }
        }

        private void intro()
        {
            Console.WriteLine("{0}{0}Welcome to the Game!{0}{0} Pick a number between 1 and 100 and the computer will guess it.{0}",
                Environment.NewLine);
        }

        private int guess(int low, int high)
        {
            return new Random().Next(low, high);
        }

        private string promptCorrectLowHigh()
        {
            string input = "";

            do
            {
                Console.WriteLine("Is my guess Correct, Low, or High?");
                input = Console.ReadLine().ToUpper();
            }
            while (input != "CORRECT" && input != "LOW" && input != "HIGH");

            return input;
        }

        private void win(int x)
        {
            Console.WriteLine("Your number is {0}!", x);
        }

    }
}