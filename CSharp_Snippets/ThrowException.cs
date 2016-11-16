using System;

namespace CSharp_Snippets
{
    class ThrowException
    {
        public static void play()
        {
            bool isCreditGood = false;
            int credit = 0;

            Console.WriteLine("Input Credit Score");
            Int32.TryParse(Console.ReadLine(), out credit);

            try
            {
                isCreditGood = checkCredit(credit);

                if (isCreditGood)
                {
                    Console.WriteLine("Your credit is good!");
                }
                else
                {
                    Console.WriteLine("Your credit is bad!");
                }
 
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.GetType().FullName);
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

        private static bool checkCredit(int score)
        {
            if (350 > score || score > 850) throw new System.ArgumentOutOfRangeException();
            return (650 <= score && score <= 850);
        }
    }
}