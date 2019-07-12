using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyFirstProject.MyFirstDataTypes;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(10);
            Circle circle = new Circle(10);

            Console.WriteLine(ShapeUtility.IsPolygon(square));
            Console.WriteLine(ShapeUtility.IsPolygon(circle));
        }
    }
}
