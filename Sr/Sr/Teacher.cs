using System;
using System.Collections.Generic;

namespace sr_1
{
    class Teacher
    {
        public int Age;
        public int Exp;
        public string Subject;
        public string Sex;

        public Teacher(int age, int exp, string subject = null, string sex = null)
        {
            Age = age;
            Exp = exp;
            Subject = subject;
            Sex = sex;
        }
        public void showInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Exp: {Exp}");
            Console.WriteLine($"Subject: {Subject}");
            Console.WriteLine($"Sex: {Sex}");
        }
    }
}