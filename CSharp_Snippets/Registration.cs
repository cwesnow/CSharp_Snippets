using System;

namespace CSharp_Snippets
{
    class Registration
    {
        public static void play()
        {
            string input = ""; // Temporary Input holder
            string Name = "";
            string CheckIn = "";

            Console.Clear();
            Console.WriteLine("{0}Registration{0}", Environment.NewLine);

            bool isInputGood = false; // Passed Validation - T/F

            Console.Write(
                "Welcome to the world famous Tzar Towers!{0}" +
                "Please leave your name and a reservation day for later servicing.{0}{0}" +
                "Reservation Name: ", Environment.NewLine
                );

            while (isInputGood == false)
            {

                // Waits for user input
                input = Console.ReadLine();

                // Validate Input - Simple empty string check
                if (input != null && input.Length > 5) isInputGood = true;
                else Console.WriteLine("To better serve our customers, we ask for names longer than 5 characters long.  Thank you");
            }
            Name = input; // Save valid input
            
            isInputGood = false; // Reset input validation
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
                catch (Exception)
                {
                    Console.WriteLine("Wrong Format, please try again");
                }

            }
            while (isInputGood == false);
            CheckIn = input; // Save valid input
            
            // Simple output
            Console.WriteLine("We have {0} reserved on the {1}",
                Name, CheckIn);

            // Basic output - Better user acceptance
            Console.WriteLine("We have {0} reserved on day {1} of month {2} in year {3}.",
                Name, CheckIn.Substring(0, 2), CheckIn.Substring(3,2), CheckIn.Substring(6)
                );

            // Advanced output - Great user acceptance, but adds complexity and time
            Console.WriteLine("We have {0} reserved on {1} {2}, {3}",
                Name,
                getMonth(CheckIn),
                getDay(CheckIn),
                getYear(CheckIn)
                );
            Console.ReadKey();
        }

        private static string getDay(string date)
        {
            string day = date.Substring(0, 2);
            if (day.Substring(0, 1) == "0") day = day.Substring(1);

            switch (day)
            {
                case "1":
                case "21":
                case "31":
                    return day + "st";
                case "2":
                case "22":
                    return day + "nd";
                case "3":
                case "23":
                    return day + "rd";
                default:
                    return day + "th";
            }
        }

        private static string getMonth(string date)
        {
            string month = date.Substring(3, 2);
            if (month.Substring(0, 1) == "0") month = month.Substring(1);
            switch (month)
            {
                case "1":
                    return "January";
                case "2":
                    return "February";
                case "3":
                    return "March";
                case "4":
                    return "April";
                case "5":
                    return "May";
                case "6":
                    return "June";
                case "7":
                    return "July";
                case "8":
                    return "August";
                case "9":
                    return "September";
                case "10":
                    return "October";
                case "11":
                    return "November";
                case "12":
                    return "December";
            }
            return month;
        }

        private static string getYear(string date)
        {
            string year = date.Substring(6);
            return year;
        }
    }
}
