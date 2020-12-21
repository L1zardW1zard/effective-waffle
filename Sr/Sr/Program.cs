using System;

namespace sr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 10

            var teachers = new Teachers();
            bool exist = true;

            int Age = 0;
            int Exp = 0;
            string Subject = null;
            string Sex= null;

            byte amount = 0;
            string tempForInput;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Добро пожаловать");
            Console.WriteLine("Хотите вибрать учителя по параметрах?");
            Console.WriteLine("Yes(Да), No(Нет, покажите мне всех)");
            Console.Write("Введите y или n: ");
            Console.ForegroundColor = ConsoleColor.White;
            tempForInput = Console.ReadLine();

            if (tempForInput == "y")
            {
                while (exist)
                {
                    amount = 0;
                    tempForInput = null;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine();
                    Console.WriteLine("Вы можете вибрать учителя по следующим параметрам:");
                    Console.WriteLine("Age,Experience,Subject,Sex");
                    Console.Write("-Если ви хотите пропустить какую-то характеристику введите знак - \n\n");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Введите возраст ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-") {
                        tempForInput = null;
                        amount++;
                    }
                    else
                    {
                        Age = Convert.ToInt32(tempForInput);
                        tempForInput = null;
                    }
                       

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Введите опыт работы: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else Exp = Convert.ToInt32(tempForInput);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Введите преподаваемый предмет: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else Subject = tempForInput;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("Введите пол: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    if (tempForInput == "-")
                    {
                        tempForInput = null;
                        amount++;
                    }
                    else Sex = tempForInput;

                    teachers.findCar(amount, Age, Exp, Subject, Sex);

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\nВыбрать занаво?");
                    Console.WriteLine("Yes, No(Виход из программи)");
                    Console.Write("  Введите y или n:  ");
                    Console.ForegroundColor = ConsoleColor.White;
                    tempForInput = Console.ReadLine();
                    exist = tempForInput == "y" ? true : false;
                }
            }
            else
            {
                teachers.showInfoAboutTeachers();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                exist = false;
            }

        }
    }
}

