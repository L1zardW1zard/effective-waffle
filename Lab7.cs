using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            int choice;
            List<char> chars = new List<char>();

            do
            {
                Console.WriteLine("1 - Add new element");
                Console.WriteLine("2 - Show element with id");
                Console.WriteLine("3 - Copy list to array");
                Console.WriteLine("4 - Exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new element:");
                        char temp = char.Parse(Console.ReadLine());
                        chars.Add(temp);
                        break;
                    case 2:
                        Console.WriteLine("Enter element id:");
                        int elementID = int.Parse(Console.ReadLine());
                        if (elementID < chars.Count)
                        {
                            Console.WriteLine("Chosen element:" + chars[elementID]);
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                        break;
                    case 3:
                        char[] arr = new char[chars.Count];
                        chars.CopyTo(arr);
                        Console.WriteLine("Your array:");
                        for (int i = 0; i < chars.Count; i++)
                        {
                            Console.Write(arr[i]+"\t");
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            } while (running);
        }
    }
}
