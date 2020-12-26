using System;
using System.Collections.Generic;

// Вариант 27(2)

namespace Lab_11
{
    delegate void myDelegate(Car car);
    delegate bool stDeleg(Student student);

    class Program
    {
        public static void showStudent(in List<Student> ls)
        {
            foreach (var student in ls)
            {
                Console.WriteLine($"\tFirstName - {student.FirstName}");
                Console.WriteLine($"\tLastName - {student.LastName}");
                Console.WriteLine($"\tAge - {student.Age}");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            Sto sto = new Sto();
            Console.WriteLine("\tЗадание 1\n");
            myDelegate my_Delegate = new myDelegate(sto.WheelAlignerDone);
            my_Delegate += sto.paintingDone;
            my_Delegate(car);
            car.showInfo();

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tЗадание 2\n");

            List<Student> group = new List<Student>();
            group.Add(new Student("Anton", "Atamas", 18));
            group.Add(new Student("Valeriy", "Bilous", 18));
            group.Add(new Student("Valera", "Dmytryshyn", 19));
            group.Add(new Student("Bohdan", "Daniliuk", 19));
            group.Add(new Student("Dmytro", "Vdovin", 17));
            group.Add(new Student("Bohdan", "Student", 18));
            group.Add(new Student("Vitaliy", "Voloshyn", 21));
            group.Add(new Student("Eduard", "Petrenko", 18));
            group.Add(new Student("Artem", "Iluchenko", 24));
            group.Add(new Student("Dana", "Prokopets", 18));

            List<Student> results = new List<Student>();
            stDeleg del;

            //Задание 2.8

            Console.WriteLine();
            del = Student.isOlderThen18;
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tЗадание 2.8\n");
            results.Clear();
            del = Student.isFirstNameBeginFromA;
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 50));
            results.Clear();
            del = Student.isLastNameLengthMoreThan3;
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tЗадание 2.9\n");
            results.Clear();
            del = student => student.Age >= 18;
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 50));
            results.Clear();
            del = student => student.FirstName.ToCharArray()[0] == 'A';
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 50));
            results.Clear();
            del = student => student.FirstName.Length > 3;
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tЗадание 2.10\n");
            results.Clear();
            del = student => student.Age >= 20 && student.Age <= 25;
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tЗадание 2.11\n");
            results.Clear();
            del = student => student.FirstName == "Valeriy";
            results = group.FindStudent(del);
            showStudent(in results);

            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tЗадание 2.12\n");
            results.Clear();
            del = student => student.LastName == "Petrenko";
            results = group.FindStudent(del);
            showStudent(in results);

            Console.ReadKey();
        }
    }
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> ls, stDeleg del)
        {
            List<Student> tempList = new List<Student>();
            foreach (var student in ls)
            {
                if (del.Invoke(student))
                    tempList.Add(student);
            }
            return tempList;
        }
    }
}
