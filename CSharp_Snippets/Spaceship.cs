using System;

namespace CSharp_Snippets
{
    class Spaceship
    {
        public static void play()
        {
            Console.Clear();

            // Version 1.0 - The direct approach
            Console.WriteLine("Making a spaceship with a Console.WriteLine( \"Spaceship\");");

            Console.WriteLine(
                "   /**\\       {0}" +
                "  //**\\\\     {0}" +
                " ///**\\\\\\   {0}" +
                "+=*=*=*=*+     {0}" +
                "|./\\../\\.|   {0}" +
                "|/\\/\\/\\/\\| {0}" +
                "|\\/\\/\\/\\/| {0}" +
                "|.\\/..\\/.|   {0}" +
                "+=*=*=*=*+     {0}" +
                "|\\/\\/\\/\\/| {0}" +
                "|.\\/..\\/.|   {0}" +
                "|./\\../\\.|   {0}" +
                "|/\\/\\/\\/\\| {0}" +
                "+=*=*=*=*+     {0}" +
                "   /**\\       {0}" +
                "  //**\\\\     {0}" +
                " ///**\\\\\\   {0}"
                , Environment.NewLine
                );

            Console.ReadKey();
            Console.Clear();

            //Version 2.0 - Basic Programatic Solution
            //Improvements: Easier to fix a single Line typo than multiple lines, a quick reference change fixes sequencing mistakes
            Console.WriteLine("Making a spaceship using several string Variables");

            string A = "   /**\\";
            string B = "  //**\\\\";
            string C = " ///**\\\\\\";
            string D = "+=*=*=*=*+";
            string E = "|./\\../\\.|";
            string F = "|/\\/\\/\\/\\|";
            string G = "|\\/\\/\\/\\/|";
            string H = "|.\\/..\\/.|";

            Console.WriteLine(
                "{0}{8}" +
                "{1}{8}" +
                "{2}{8}" +
                "{3}{8}" +
                "{4}{8}" +
                "{5}{8}" +
                "{6}{8}" +
                "{7}{8}" +
                "{3}{8}" +
                "{6}{8}" +
                "{7}{8}" +
                "{4}{8}" +
                "{5}{8}" +
                "{3}{8}" +
                "{0}{8}" +
                "{1}{8}" +
                "{2}{8}"
                , A, B, C, D, E, F, G, H, Environment.NewLine
            );

            Console.ReadKey();
            Console.Clear();

            // Version 3.0 - An overly complicated example
            // This would not be fun to maintain or fix later
            // Challenge: Create the spaceship using loops
            Console.WriteLine("Making a spaceship with Loops");

            for (int y = 2; y < 20; y++)
            {
                // Output:    /**\   
                if (y == 2 || y == 16)
                {
                    for (int x = 1; x < 11; x++)
                    {
                        if (x < 4 || x > 7) Console.Write(" ");
                        else if (x < 5) Console.Write("/");
                        else if (x == 5 || x == 6) Console.Write("*");
                        else if (x > 6) Console.Write("\\");
                    }
                }

                // Output:   //**\\   
                if (y == 3 || y == 17)
                {
                    for (int x = 1; x < 11; x++)
                    {
                        if (x < 3 || x > 8) Console.Write(" ");
                        else if (x < 5) Console.Write("/");
                        else if (x == 5 || x == 6) Console.Write("*");
                        else if (x > 6) Console.Write("\\");
                    }
                }

                // Output:  ///**\\\
                if (y == 4 || y == 18)
                {
                    for (int x = 1; x < 11; x++)
                    {
                        if (x < 2 || x > 9) Console.Write(" ");
                        else if (x < 5) Console.Write("/");
                        else if (x == 5 || x == 6) Console.Write("*");
                        else if (x > 6) Console.Write("\\");
                    }
                }

                // Output: +=*=*=*=*+
                if (y % 5 == 0)
                {
                    for (int x = 1; x < 11; x++)
                    {
                        if (x == 1 || x == 10) Console.Write("+");
                        else if (x % 2 == 0) Console.Write("=");
                        else Console.Write("*");
                    }
                }

                // Output: |./\\../\\.|
                if (y == 6 || y == 13)
                {
                    for (int x = 1; x < 11; x++)
                    {
                        if (x == 1 || x == 10) Console.Write("|");
                        else if (x == 2 || x == 5 || x == 6 || x == 9) Console.Write(".");
                        else if (x == 3 || x == 7) Console.Write("/");
                        else Console.Write("\\");
                    }
                }

                // Output: |/\\/\\/\\/\\|
                if (y == 7 || y == 14)
                {
                    for (int x = 1; x < 11; x++)
                    {
                        if (x == 1 || x == 10) Console.Write("|");
                        else if (x % 2 == 0) Console.Write("/");
                        else Console.Write("\\");
                    }
                }

                // Output: |\\/\\/\\/\\/|
                if (y == 8 || y == 11)
                {
                    for (int x = 1; x < 11; x++)
                    {
                        if (x == 1 || x == 10) Console.Write("|");
                        else if (x % 2 == 0) Console.Write("\\");
                        else Console.Write("/");
                    }
                }

                // Output: |.\\/..\\/.|
                if (y == 9 || y == 12)
                {
                    for (int x = 1; x < 11; x++)
                    {
                        if (x == 1 || x == 10) Console.Write("|");
                        else if (x == 2 || x == 5 || x == 6 || x == 9) Console.Write(".");
                        else if (x == 3 || x == 7) Console.Write("\\");
                        else Console.Write("/");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
