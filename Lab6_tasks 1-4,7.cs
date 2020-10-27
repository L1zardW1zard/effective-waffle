using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //Task1_2(input); //Done?
            //Task3(input);   //Done?
            //Task4(input);   //Done?
            Console.ReadLine();
        }


        static void Task1_2(string input)  // Так же подходит под задание 7
        {
            Console.WriteLine("Task1_2");
            string str = input;
            char[] arr = str.ToCharArray();
            
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }

        static void Task3(string input)
        {
            Console.WriteLine("Task3");
            string str = input.ToString();
            char[] arr = str.ToCharArray();
            int k = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == '.')
                {
                    k = i;
                }
            }

            for (int i = k - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }

            Console.Write(arr[k]);

            for (int i = arr.Length - 1; i > k; i--)
            {
                Console.Write(arr[i]);
            }
        }

        static void Task4(string input)
        {
            Console.WriteLine("Task4");
            string str = input.ToString();
            char[] arr = str.ToCharArray();
            int k = 0;

            char magicSymbol=char.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == magicSymbol)
                {
                    k = i;
                }
            }

            for (int i = k - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }

            Console.Write(arr[k]);

            for (int i = arr.Length - 1; i > k; i--)
            {
                Console.Write(arr[i]);
            }
        }

    }
}
