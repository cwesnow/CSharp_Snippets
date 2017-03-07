using System;

namespace CSharp_Snippets
{
    /// <summary>
    /// Builds a Spaceship inside a Console Screen
    /// </summary>
    class Spaceship : Play
    {
        /// <summary>
        /// Program draws a spaceship 3 different ways
        /// </summary>
        public void Play()
        {
            Console.Clear();

            // Version 1.0 - The direct approach
            Console.WriteLine("Making a spaceship with a Console.WriteLine( \"Spaceship\");");
            spaceship1();
            Console.ReadKey();
            Console.Clear();

            //Version 2.0 - Basic Programatic Solution
            //Improvements: Easier to fix a single Line typo than multiple lines, a quick reference change fixes sequencing mistakes
            Console.WriteLine("Making a spaceship using several string Variables");
            spaceship2();
            Console.ReadKey();
            Console.Clear();

            // Version 3.0 - An overly complicated example
            // This would not be fun to maintain or fix later
            // Challenge: Create the spaceship using loops
            Console.WriteLine("Making a spaceship with Loops");
            spaceship3();
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Draw a Spaceship
        /// </summary>
        public void spaceship1()
        {
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
        }

        /// <summary>
        /// Draw a Spaceship using a String Variables
        /// </summary>
        public void spaceship2()
        {

            string A = "   /**\\";
            string B = "  //**\\\\";
            string C = " ///**\\\\\\";
            string D = "+=*=*=*=*+";
            string E = "|./\\../\\.|";
            string F = "|/\\/\\/\\/\\|";
            string G = "|\\/\\/\\/\\/|";
            string H = "|.\\/..\\/.|";

            //Using WriteLine("{0}{2}", arg0, arg1, arg2); for simplification
            Console.WriteLine(
                "{0}{8}" + //A
                "{1}{8}" + //B
                "{2}{8}" + //C
                "{3}{8}" + //D
                "{4}{8}" + //E
                "{5}{8}" + //F
                "{6}{8}" + //G
                "{7}{8}" + //H
                "{3}{8}" + //D
                "{6}{8}" + //G
                "{7}{8}" + //H
                "{4}{8}" + //E
                "{5}{8}" + //F
                "{3}{8}" + //D
                "{0}{8}" + //A
                "{1}{8}" + //B
                "{2}{8}"   //C
                , A, B, C, D, E, F, G, H, Environment.NewLine);
        }

        /// <summary>
        /// Draw a Spaceship using a Loop
        /// </summary>
        public void spaceship3()
        {
            for (int y = 2; y < 20; y++)
            {
                #region Line A
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
                #endregion
                #region Line B
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
                #endregion
                #region Line C
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
                #endregion
                #region Line D
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
                #endregion
                #region Line E
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
                #endregion
                #region Line F
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
                #endregion
                #region Line G
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
                #endregion
                #region Line H
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
                #endregion
                Console.WriteLine();
            }
        }
    }
}
