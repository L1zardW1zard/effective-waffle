using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            input = Console.ReadLine();
            Console.WriteLine("Your input: " + input);
            Console.WriteLine("Result: " + Check(input));
        }

        static bool Check(string input)
        {
            if (input.Length > 2 && ((float.Parse(input) % 2) == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
