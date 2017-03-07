using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Snippets
{
    class FiveDigits : Play
    {
        static HashSet<int> hash = new HashSet<int>();
        static Random rng = new Random();

        public void Play()
        {
            int magicNumber = 12345;
            int counter = 0;

            while (!hash.Contains(magicNumber))
            {
                getNewNumber();
                Console.WriteLine("Iteration #{0,4} with combination = {1}", counter + 1, hash.ElementAt(counter).ToString("D5"));
                counter++;
                if (counter % 10 == 0) pause();
            }
            Console.ReadKey();
        }
        public void pause()
        {
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey(true);
        }
        public void getNewNumber()
        {
            while (!hash.Add(rng.Next(0, 99999))) ;
        }
    }
}
