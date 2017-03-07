using System;

namespace CSharp_Snippets
{
    class Equation : Play
    {
        // P = Parenthesis
        // E = Exponents
        // M = Multiplication
        // D = Division
        // A = Addition
        // S = Subtraction
        public void solve(string input)
        {
            // Split each part into individual solutions
            string[] expressions = input.Split('=');

            foreach (var section in expressions)
            {
                Console.WriteLine("Analyzing: " + section);

                if (section.Contains("*"))
                {
                    Console.WriteLine("The answer is {0}.", Binary('*', section));
                }
                else if (section.Contains("/"))
                {
                    Console.WriteLine("The answer is {0}.", Binary('/', section));
                }
                else if (section.Contains("+"))
                {
                    Console.WriteLine("The answer is {0}.", Binary('+', section));
                }
                else if (section.Contains("-"))
                {
                    Console.WriteLine("The answer is {0}.", Binary('-', section));
                }

            }
        }

        public string Binary(char symbol, string expression)
        {
            int A;
            bool isAgood = int.TryParse(expression.Substring(0, expression.IndexOf(symbol)).Replace('+', ' '), out A);
            int B;
            bool isBgood = int.TryParse(expression.Substring(expression.IndexOf(symbol) + 1).Replace('+', ' '), out B);
            if (isAgood && isBgood)
            {
                if (symbol.Equals('*')) return (A * B).ToString();
                if (symbol.Equals('/')) { if (B == 0) return "Division by Zero is undefined"; else return (A / B).ToString() + " " + A % B + "/" + B; }
                if (symbol.Equals('+')) return (A + B).ToString();
                if (symbol.Equals('-')) return (A - B).ToString();
            }
            return "could not perform this " + symbol + " operation performed on the " + expression;
        }

        public void Play()
        {
            Console.WriteLine(
                "This program can solve BINARY problems\n" +
                "Examples: A + B, A - B, A * B, and A / B\n\n" +
                "Enter a simple Equation to solve: ");
            solve(Console.ReadLine());
            Console.ReadKey();
        }

    }
}
