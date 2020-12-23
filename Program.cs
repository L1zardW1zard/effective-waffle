using System;


namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1 - Task_1");
                Console.WriteLine("2 - Task_2");
                Console.WriteLine("3 - Task_3");
                Console.WriteLine("4 - Task_4");
                Console.WriteLine("0 - Exit");
                choice = Choice();
                switch (choice)
                {
                    case 1:
                        ReverseInt();
                        break;
                    case 2:
                        ReverseString();
                        break;
                    case 3:
                        ReverseDouble();
                        break;
                    case 4:
                        ReverseStringWithAMagicalSign();
                        break;
                    default:
                        break;
                }
            } while (choice != 0);

        }

        static void Reverse(int number)
        {
            Console.Write("Обратное целое число: ");
            Console.Write(number % 10);
            while ((number /= 10) != 0)
                Console.Write(number % 10);
            Console.WriteLine();
        }

        static void Reverse(string s)
        {
            char[] strArr = s.ToCharArray();
            Console.Write("Ваша строка: ");
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(strArr[i]);
            }
            Console.WriteLine();
        }

        static void Reverse(double doubleNumber)
        {
            string[] splitedStr = doubleNumber.ToString().Split(',');
            Console.Write("Ваш обратный дубль: ");
            for (int j = splitedStr[0].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[0][j]);
            }
            Console.Write(",");
            for (int j = splitedStr[1].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[1][j]);
            }
            Console.WriteLine();
        }

        static void Reverse(string s, char sign)
        {
            if (s.IndexOf(sign) != -1)
            {
                string[] splitedStr = s.Split(sign);

                Console.Write("Ваша обратная строка: ");
                for (int j = splitedStr[0].Length - 1; j >= 0; j--)
                {
                    Console.Write(splitedStr[0][j]);
                }
                Console.Write(sign);
                for (int j = splitedStr[1].Length - 1; j >= 0; j--)
                {
                    Console.Write(splitedStr[1][j]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("В строке нет выбранного знака ");
            }
        }

        static int Choice()
        {
            int choice;

            Console.Write("\nВведите свой вариант: ");

            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Введите правильный номер");
            }
            return choice;
        }

        static void ReverseInt()
        {
            Console.Write("\nВведите число, которое хотите отменить: ");
            int num = 0;
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Введите правильный номер: ");
            }
            Console.Write("Ваш обратный номер: ");
            Console.Write(num % 10);
            while ((num /= 10) != 0)
                Console.Write(num % 10);
            Console.WriteLine();
        }

        static void ReverseString()
        {
            Console.Write("\nВведите строку, которую хотите перевернуть: ");
            string str = Console.ReadLine();
            char[] strArr = str.ToCharArray();
            Console.Write("Обратная строка: ");
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(strArr[i]);
            }
            Console.WriteLine();
        }

        static void ReverseDouble()
        {
            Console.Write("\nВведите двойной, чтобы перевернуть: ");
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введите правильный дубль:");
            }
            string[] splitedStr = number.ToString().Split(',');

            for (int j = splitedStr[0].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[0][j]);
            }
            Console.Write(",");
            for (int j = splitedStr[1].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[1][j]);
            }
        }

        static void ReverseStringWithAMagicalSign()
        {
            Console.Write("\nВведите строку, которую нужно перевернуть: ");
            string magString = Console.ReadLine();
            Console.Write("Какой символ разделит вашу строку: ");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(sign);


            if (magString.IndexOf(sign) != -1)
            {
                string[] splitedStr = magString.Split(sign);

                Console.Write("Обратная строка:");
                for (int j = splitedStr[0].Length - 1; j >= 0; j--)
                {
                    Console.Write(splitedStr[0][j]);
                }
                Console.Write(sign);
                for (int j = splitedStr[1].Length - 1; j >= 0; j--)
                {
                    Console.Write(splitedStr[1][j]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("В строке нет выбранного знака");
            }
        }
    }
}
