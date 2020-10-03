using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Enter m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter k:");
            int k = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, m];

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Random random = new Random();
                    arr[i, j] = random.Next(1, 101);
                }
            }

            Console.WriteLine("Array 1:");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine("");
            }


            int[,] secondArr = new int[n, m];

            Console.WriteLine("Array 2:");

            for (i = 0; i < n; i++)
            {
                if (i == k - 2)
                {
                    for (int x = 0; x < m; x++)   //Как добавить это в массив вообще
                    {
                        Console.Write("0\t");
                    }
                    Console.WriteLine();
                }
                for (j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Array 3:");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < m; j++)
                {
                    if (k == j + 1)
                    {
                        Console.Write("0\t");
                    }
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
