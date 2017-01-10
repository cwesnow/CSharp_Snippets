namespace CSharp_Snippets
{
    class FarenheitToCelsius
    {
        public static void play()
        {
            System.Console.WriteLine("Farenheit to Celsius converter{0}{0}Temperature in Farenheit?", System.Environment.NewLine);
            double number = 0;
            while (!double.TryParse(System.Console.ReadLine(), out number)) ;

            System.Console.WriteLine(
                "{0}° Farenheit is {1}{2} Celsius",
                number, ( (number - 32.0) * 5 / 9).ToString("0.#"),
                (char)176);
            System.Console.ReadLine();
        }
    }
}
