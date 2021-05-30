using System;

namespace RegexSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput;

            do
            {
                Console.Write("Regex: ");
                userinput = Console.ReadLine();
                Console.WriteLine(Calc(userinput));
            } while (true);
        }

        public static string Calc(string reg)
        {
            throw new NotImplementedException();
        }
    }
}
