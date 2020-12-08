using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    abstract class Shape
    {
        public abstract string Color { get; set; }
        public abstract int vertices { get; }
        public abstract string Name { get; }
        public abstract double Perimeter();
        public abstract double Area();
    }

    class RandomValues
    {
        private static Random rand = new Random();
        private static string[] colors = { "Red", "Yellow", "Blue", "Cyan", "Green", "Grey" };
        public static int randomLeght() => rand.Next(10, 666);
        public static string randomColor() => colors[rand.Next(0, 5)];
    }
}
