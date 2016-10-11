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
                "{0}[2] Calculator - Math" +
                "{0}[3] Registration - Enter Date{0}" +
                "{0}[4] OOP{0} - Abstract & Interface", Environment.NewLine
                );
            
            x = getInput();

            Console.Clear();
            
            if (x == 1) { spaceship(); }
            if (x == 2) { calculator(); }
            if (x == 3) { registration(); }
            if (x == 4) { oop(); }
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

        static void spaceship()
        {
            Console.Clear();

            // Version 1.0 - The direct approach
            Console.WriteLine("Making a spaceship with all Console.WriteLines");

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
            Console.WriteLine("Making a spaceship with Variables");

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
                        else if (x%2 == 0) Console.Write("/");
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

        static void calculator()
        {
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
                else {
                    Console.WriteLine("Can't divide by zero");
                    ans = 0; }
                
            }

            Console.WriteLine("Output: {0} {1} {2} = {3}", one, operation, two, ans);

            Console.ReadKey();
        }

        static void registration()
        {
            Console.Clear();
            Console.WriteLine("Registration");

            // copy
            string input = ""; // Save Input
            bool isInputGood = false; // Passed Validation - T/F

            Console.Write(
                "Welcome... blah blah blah" + "\r\n" +
                "Enter Data... blah blah blah" + "\r\n" +
                "What's your First Name: "
                );

            while (isInputGood == false)
            {

                // Waits for user input
                input = Console.ReadLine();

                // Validate Input - Simple empty string check
                if (input != null && input.Length != 0) isInputGood = true;
            }
            string FirstName = input; // Now we save the good input
            isInputGood = false; // Reset input validation


            // string input = "";
            // bool isInputGood = false;
            do
            {
                Console.Write(
                    "Please enter reservation date in DD/MM/YYYY format. " +
                    "Check In: "
                );

                input = Console.ReadLine();

                try
                {
                    // Requires System.Globalization;
                    DateTime.ParseExact(
                        input, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                    isInputGood = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong Format, please try again");
                }

            }
            while (isInputGood == false);

            string CheckIn = input;
            Console.WriteLine("Date entered: {0}", CheckIn);
            Console.ReadKey();
        }
        
        static void oop()
        {
            Console.Clear();
            Console.WriteLine("OOP Design Principals");

            // Default Values Example
            Person owner = new Person();

            Person friend = new Person("Jimmy", "Pizza");
            Dog pet1 = new Dog("Dog","Dog Food");
            Cat pet2 = new Cat("Cat","Cat Food");

            // Abstract Class made sure every object had a Name and a Diet property
            // Interface made sure every class uses same Method()

            // Test: owner Object has null or empty values
            Console.WriteLine(
                owner.speak()
                );

            // Test: owner Object has a Name
            owner.changeName("Owner");
            Console.WriteLine(
                 owner.speak()
                );

            // Test: owner Object has a Diet
            owner.changeDiet("CheeseBurgers");
            Console.WriteLine(
                owner.speak()
                );
            

            Console.WriteLine(
                friend.speak()
            );

            Console.WriteLine(
                pet1.myNameDiet() +
                " I say " +
                pet1.speak()
                );

            Console.WriteLine(
                pet2.myNameDiet() +
                " I say " +
                pet2.speak()
                );
            
            Console.ReadKey();
        }
    }

}
