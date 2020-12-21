using System;
using System.Collections.Generic;
using System.Linq;

namespace sr_1
{
    class Teachers
    {
        private List<Teacher> teachers = new List<Teacher>();

        public Teachers()
        {
            teachers.Add(new Teacher(33, 3, "Math", "Male"));
            teachers.Add(new Teacher(35, 5, "English", "Female"));
            teachers.Add(new Teacher(42, 12, "Physics", "Female"));
            teachers.Add(new Teacher(49, 4, "PE", "Female"));
            teachers.Add(new Teacher(53, 14, "Math", "Male"));
        }

        public void showInfoAboutTeachers()
        {
            foreach (var p in teachers)
                p.showInfo(); 
        }
        private void showInfoAboutTeachersFromIndex(in List<sbyte> index)
        {
            for (var i = 0; i < index.Count(); i++)
                teachers[index.ElementAt(i)].showInfo();
        }
        private List<sbyte> indexTeachersWithAge(int age)
        {
            List<sbyte> listIndex = new List<sbyte>();
            for (var i = 0; i < 5; i++)
                if (teachers[i].Age == age)
                    listIndex.Add((sbyte)i);

            return listIndex;
        }
        private List<sbyte> indexTeachersWithExp(int exp)
        {
            List<sbyte> listIndex = new List<sbyte>();
            for (var i = 0; i < 5; i++)
                if (teachers[i].Exp == exp)
                    listIndex.Add((sbyte)i);

            return listIndex;
        }
        private List<sbyte> indexTeachersWithSubject(string subject)
        {
            List<sbyte> listIndex = new List<sbyte>();
            for (var i = 0; i < 5; i++)
                if (teachers[i].Subject == subject)
                    listIndex.Add((sbyte)i);
            return listIndex;
        }
        private List<sbyte> indexTeachersBySex(string sex)
        {
            List<sbyte> listIndex = new List<sbyte>();
            for (var i = 0; i < 5; i++)
                if (teachers[i].Sex == sex)
                    listIndex.Add((sbyte)i);
            return listIndex;
        }
        private List<sbyte> uniteListsOfIndex(in List<sbyte> lb_1, in List<sbyte> lb_2)
        {
            List<sbyte> result = new List<sbyte>();
            if (lb_1.Count != 0 || lb_2.Count != 0)
            {
                foreach (sbyte elem in lb_1)
                    result.Add(elem);
                foreach (sbyte elem in lb_2)
                    result.Add(elem);
            }
            return result;
        }
        private List<sbyte> MyDistinct(in List<sbyte> lb)
        {
            List<sbyte> result = lb;
            for (var i = 0; i < result.Count; i++)
                for (var j = 0; j < result.Count; j++)
                    if (result[i] == result[j] && i != j)
                        result.RemoveAt(j);
            return result;
        }
        private List<sbyte> createListFromDublicatesOfIndex(in List<sbyte> lb)
        {
            List<sbyte> result = new List<sbyte>();
            for (var i = 0; i < lb.Count; i++)
                for (var j = 0; j < lb.Count; j++)
                    if (lb[i] == lb[j] && i != j)
                    {
                        result.Add(lb[i]);
                        break;
                    }
            return MyDistinct(in result);
        }
        public void findCar(byte amount, int age, int exp = 0, string subject = null, string sex = null)
        {
            var carsWithColor = indexTeachersWithAge(age);
            var carsWithYearOfMade = indexTeachersWithExp(exp);
            var carsWithPrice = indexTeachersWithSubject(subject);
            var carsWithEnginePower = indexTeachersBySex(sex);

            List<sbyte> result = uniteListsOfIndex(in carsWithColor, in carsWithYearOfMade);
            result = uniteListsOfIndex(in result, in carsWithPrice);
            result = uniteListsOfIndex(in result, in carsWithEnginePower);
            if (amount != 3)
                result = createListFromDublicatesOfIndex(in result);

            if (result.Count() != 0)
                showInfoAboutTeachersFromIndex(in result);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n-пока учителей с такими параметрами нет");
            }
        }

    }
}