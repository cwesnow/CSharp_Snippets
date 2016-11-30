using System;

namespace CSharp_Snippets
{
    class Calculator
    {
        public static void play(){
            bool validInput = false;
            string operation;
            decimal one = 0m;
            decimal two = 0m;
            decimal ans = 0m;

            do
            {
                Console.WriteLine("Input First Number");
                validInput = decimal.TryParse(Console.ReadLine(), out one);
            } while (validInput == false);

            do
            {
                Console.WriteLine("Which Operation: + - * /");
                operation = Console.ReadLine();
                if (operation == "+" || operation == "-" || operation == "*" || operation == "/") validInput = true;
                else validInput = false;
            } while (validInput == false);


            do
            {
                Console.WriteLine("Input Second Number");
                validInput = decimal.TryParse(Console.ReadLine(), out two);
            } while (validInput == false);

            if (operation == "+") ans = one + two;
            if (operation == "-") ans = one - two;
            if (operation == "*") ans = one * two;
            if (operation == "/")
            {
                if (two > 0) { ans = one / two; }
                else
                {
                    Console.WriteLine("Can't divide by zero");
                    ans = 0;
                }

            }

            Console.WriteLine("Output: {0} {1} {2} = {3}", one, operation, two, ans);

            Console.ReadKey();
        }
    }
}
