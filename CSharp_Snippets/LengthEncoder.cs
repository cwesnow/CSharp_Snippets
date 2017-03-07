using System;
using System.Text;

namespace CSharp_Snippets
{
    class LengthEncoder : Play
    {
        public void Play()
        {
            bool running = true;

            Console.Title = "Encoder V 1.0";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;

            while (running)
            {
                Menu();

                switch (getChoice("Enter a number:"))
                {
                    case "1":
                        decompress();
                        break;

                    case "2":
                        compress();
                        break;

                    case "3":
                        CompressionRatio();
                        break;

                    case "4":
                        running = false;
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }

        string getChoice(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        void Menu()
        {
            Console.Clear();
            Console.WriteLine(
                "Run Length Encoder {0}" +
                "{1} {0}" +
                "1. Decompress compressed string {0}" +
                "2. Compress a decompressed string {0}" +
                "3. Compression ratio{0}4. Quit {0}" +
                "{1}",
                Environment.NewLine,
                "------------------------------------"
                );
        }

        void decompress()
        {
            string cString = getChoice("Enter compressed string: ");

            if (Validate(cString))
            {
                Console.WriteLine("Decompressed string: {0}", decompress(cString));
            }
            else
            {
                Console.WriteLine("Invalid input: It should be an even amount of characters long, with numbers between each character.");
            }
        }

        string decompress(string inputString)
        {
            StringBuilder sb = new StringBuilder();

            for (int x = 0; x < inputString.Length / 2; x++)
            {
                int y;
                int.TryParse(inputString.Substring(x * 2 + 1, 1), out y);
                while (y > 0)
                {
                    sb.Append(inputString[x * 2]);
                    y--;
                }
            }

            return sb.ToString();
        }

        bool Validate(string inputstring)
        {
            int position = 1;
            Boolean valid = true;
            if (inputstring.Length % 2 != 0)
            {
                valid = false;
            }
            else
            {
                while (position < inputstring.Length)
                {
                    if (inputstring[position] < '1' || inputstring[position] > '9')
                    {
                        valid = false;
                    }
                    position = position + 2;
                }
            }
            return valid;
        }

        void compress()
        {
            string dString = getChoice("Enter de-compressed string: ");
            Console.WriteLine("Compressed string: {0}", compress(dString));
        }

        string compress(string input)
        {
            // HELLO --> H1 E1 L2 O1 4 sequences... 
            StringBuilder sb1 = new StringBuilder(input + " ");
            StringBuilder sb2 = new StringBuilder();
            int count = 0;

            for (int x = 0; x < sb1.Length - 1; x++)
            {
                count++;

                if (sb1[x] != sb1[x + 1])
                {
                    sb2.Append(sb1[x]);
                    sb2.Append(count);
                    count = 0;
                }
            }

            return sb2.ToString();
        }

        void CompressionRatio()
        {
            string dString = getChoice("Enter uncompressed string: ");
            string cString = getChoice("Enter compressed string: ");
            Console.WriteLine("Space Savings: {0}%", (CompressionRatio(dString, cString) * 100).ToString("0"));
        }

        double CompressionRatio(string decompressed, string compressed)
        {
            return compressed.Length / (double)decompressed.Length;
        }
    }

}