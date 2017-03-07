using System;

namespace CSharp_Snippets
{
    class PrimeNumbers : Play
    {

        public void Play()
        {
            bool isValid = false;
            int userInput = 0;
            const int MIN = 2;
            int MAX = Console.WindowWidth - 8;

            Console.WriteLine(
                "{0}{0}" +
                "Prime Numbers{0}" +
                "Finds Prime Numbers between 2 and your input.{0}" +
                "This program is limited by screen width {1}",
                Environment.NewLine, MAX
                );
            while (!isValid)
            {
                Console.Write("Number >>> ");
                isValid = Int32.TryParse(Console.ReadLine(), out userInput);
                if (MAX < userInput || MIN > userInput)
                {
                    isValid = false;
                    Console.WriteLine("Invalid Input, Try another Number");
                }
            }
            Console.WriteLine();

            // Run from 2 to user's input value
            for (int numbers = 2; numbers <= userInput; numbers++)
            {
                // Variables
                bool isPrime = true;
                string eachX = "XX";

                // Prime Number test
                for (int divider = 2; divider < numbers; divider++)
                {
                    eachX += "X";
                    if (numbers % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                // Only prints Prime Numbers
                if (isPrime)
                {
                    Console.WriteLine("{0, 4} : {1}", numbers, eachX);
                }
            }

            Console.ReadKey();
        }
    }
}
