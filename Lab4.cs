using System;

namespace ConsoleApp2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Element #" + (i + 1));
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your array:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
}
