using System;
using System.Collections.Generic;

namespace Lab_11
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Student() { }
        public Student(string fn, string ln, int age)
        {
            FirstName = fn;
            LastName = ln;
            Age = age;
        }

        public static bool isOlderThen18(Student student)
        {
            if (student.Age >= 18) return true;
            else return false;
        }
        public static bool isFirstNameBeginFromA(Student student)
        {
            if (student.FirstName.ToCharArray()[0] == 'A') return true;
            else return false;
        }
        public static bool isLastNameLengthMoreThan3(Student student)
        {
            if (student.FirstName.Length > 3) return true;
            else return false;
        }
    }
}
