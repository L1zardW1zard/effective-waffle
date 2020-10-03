using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double nn, nk, result = 1;
            int count = 0;
            Console.WriteLine("Enter nn: ");
            nn = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter nk: ");
            nk = float.Parse(Console.ReadLine());

            for (int i = 1; i < nk; i++)
            {

                if (0 <= nn && nn <= nk)
                {
                    count++;
                    result *= (3 * nn) + Math.Pow(-1, Math.Pow(nn, 2) + (nn + 1)) * Math.Pow(nn, 2);
                }
            }

            Console.WriteLine("Amount of itterations: " + count + "P=" + result);
        }
    }
}
