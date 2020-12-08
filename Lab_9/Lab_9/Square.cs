using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    class Square : Shape
    {
        private string name;
        private double Side;
        public override int vertices { get { return 4; } }
        public override string Color { get; set; }
        public override string Name { get { return name; } }

        public Square(string name)
        {
            this.name = name;
            Color = RandomValues.randomColor();
            Side = RandomValues.randomLeght();
        }
        public Square(string name, double side)
        {
            this.name = name;
            Color = RandomValues.randomColor();
            Side = side;
        }
        public Square(string name, double side, string color)
        {
            this.name = name;
            Color = color;
            Side = side;
        }
        public override double Perimeter()
        {
            return 4 * Side;
        }
        public override double Area()
        {
            return Side * Side;
        }

        public void Draw()
        {
            Console.WriteLine($"Name: {Name}, Color: {Color}, Side: {Side},Perimeter {Perimeter()}, Square: {Area()}");
        }
    }
}
