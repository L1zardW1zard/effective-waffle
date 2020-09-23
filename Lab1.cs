using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float amount1, amount2, temp1, temp2;

            do
            {
                Console.WriteLine("Количество литров воды1: (не может быть отрцательным числом)");
                amount1 = float.Parse(Console.ReadLine());
            } while (amount1 < 0);
            do
            {
                Console.WriteLine("Температура воды1: (не может привышать 100 градусов)");
                temp1 = int.Parse(Console.ReadLine());
            } while (temp1 > 101);
            do
            {
                Console.WriteLine("Количество литров воды2: (не может быть отрцательным числом)");
             amount2 = float.Parse(Console.ReadLine());
            } while (amount2 < 0);
            do
            {
                Console.WriteLine("Температура воды2: (не может привышать 100 градусов)");
                temp2 = int.Parse(Console.ReadLine());
            } while (temp2 > 101);

            Calc(amount1, amount2, temp1, temp2);
        }

        static void Calc(float m1, float m2,float t1, float t2)
        {
            float finalMass = m1 + m2;
            float finalTemp = (m1 * t1 + m2 * t2) / finalMass;
            Console.WriteLine("Результат: "+finalMass+"л воды "+finalTemp+" градусов С");
        }
    }
}
