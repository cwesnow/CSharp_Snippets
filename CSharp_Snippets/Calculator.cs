using System;

namespace CSharp_Snippets
{
    /// <summary>
    /// Calculator for the command line
    /// </summary>
    class Calculator
    {
        public static void play(){
            bool validInput = false;
            string operation;
            decimal one = 0m;
            decimal two = 0m;
            decimal ans = 0m;

            Console.Clear();
            Console.WriteLine("{0}Calculator Application{0}{0}", Environment.NewLine);
            
            do
            {
                Console.Write("{0}Input First Number >>>", Environment.NewLine);
                validInput = decimal.TryParse(Console.ReadLine(), out one);
            } while ( !validInput );

            do
            {
                Console.Write("{0}Pick an Operation (+, -, *, / ) >>> ", Environment.NewLine);
                operation = Console.ReadLine();

                if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
                    validInput = true;
                else
                {
                    Console.WriteLine("Error! That is not a valid operation");
                    validInput = false;
                }

            } while ( !validInput );

            do
            {
                Console.Write("{0}Input Second Number >>>", Environment.NewLine);
                validInput = decimal.TryParse(Console.ReadLine(), out two);
            } while ( !validInput );

            if (operation == "/" && two == 0)
                Console.WriteLine("Error! Dividing by Zero is Undefined");
            else {
                if (operation == "+") ans = one + two;
                if (operation == "-") ans = one - two;
                if (operation == "*") ans = one * two;
                if (operation == "/") ans = one / two;
                Console.WriteLine("Output: {0} {1} {2} = {3}", one, operation, two, ans);
            }
                
            Console.ReadKey();
        }
    }
}
