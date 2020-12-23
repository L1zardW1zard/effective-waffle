using System;

//Вариант 3
namespace lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrValue = { 432, 534, 21, 543, -4 };
            printInt32Array(arrValue);
            Console.WriteLine();
            Console.WriteLine("Мин: ");
            arrValue.findMin();
            Console.WriteLine("Макс: ");
            arrValue.findMax();
        }
        private static void printInt32Array(in int[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");
        }
    }

    public static class intArrayExtension
    {
        public static double findMin(this int[] value)
        {
            int min = value[0];
            for (int i = 0; i < value.Length; i++)
            {
                if (min > value[i])
                {
                    min = value[i];
                }
            }
            Console.WriteLine(min);
            return min;
        }

        public static double findMax(this int[] value)
        {
            int max = value[0];
            for (int i = 0; i < value.Length; i++)
            {
                if (max < value[i])
                {
                    max = value[i];
                }
            }
            Console.WriteLine(max);
            return max;
        }
    }
}
