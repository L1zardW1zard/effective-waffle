using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Triangle : Shape
    {
        private string name;
        private double Side;
        public override int vertices { get { return 4; } }
        public override string Color { get; set; }
        public override string Name { get { return name; } }

        public Triangle(string name)
        {
            this.name = name;
            Color = RandomValues.randomColor();
            Side = RandomValues.randomLeght();
        }
        public Triangle(string name, double side)
        {
            this.name = name;
            Color = RandomValues.randomColor();
            Side = side;
        }
        public Triangle(string name, double side, string color)
        {
            this.name = name;
            Color = color;
            Side = side;
        }

        public override double Perimeter()
        {
            return 3 * Side;
        }
        public override double Area()
        {
            return (Math.Sqrt(3) / 4) * (Side * Side);
        }
        public void Draw()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}, Side: {Side},Perimeter {Perimeter()}, Square: {Area()}");
        }
    }
}
