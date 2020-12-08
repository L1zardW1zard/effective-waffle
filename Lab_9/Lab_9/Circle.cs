using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Circle : Shape
    {
        private string name;
        private double Radius;
        public override int vertices { get { return 4; } }
        public override string Color { get; set; }
        public override string Name { get { return name; } }

        public Circle(string name)
        {
            this.name = name;
            Color = RandomValues.randomColor();
            Radius = RandomValues.randomLeght();
        }
        public Circle(string name, double radius)
        {
            this.name = name;
            Color = RandomValues.randomColor();
            Radius = radius;
        }
        public Circle(string name, double radius, string color)
        {
            this.name = name;
            Color = color;
            Radius = radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public void Draw()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}, Side: {Radius},Perimeter {Perimeter()}, Square: {Area()}");
        }
    }
}
