using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Snippets
{
    class Registration
    {
        public static void play()
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
    }
}
