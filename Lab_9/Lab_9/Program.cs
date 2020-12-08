using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    interface IDraw
    {
        void Draw();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("circle_test");

            Square quadrate = new Square("square_test",16,"Blue");

            Triangle triangle = new Triangle("triangle_test", 8);

            Picture picture = new Picture();

            picture.Add(circle);
            picture.Add(quadrate);
            picture.Add(triangle);
            picture.Add(new Square("testsq"));

            picture.Draw();

            Console.WriteLine("///////////////////////");
            Console.WriteLine("Deleting some stuff...");
            Console.WriteLine("///////////////////////");
            picture.RemoveByName("square_test");
            picture.RemoveByArea(2000);
            picture.RemoveByType(typeof(Circle));

            picture.Draw();

            Painter.Draw((IDraw)circle);
            Painter.Draw((IDraw)quadrate);
            Painter.Draw(picture);
        }
    }
}
