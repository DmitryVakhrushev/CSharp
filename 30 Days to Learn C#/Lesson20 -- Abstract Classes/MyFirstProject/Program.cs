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
            Console.WriteLine(square.Area);

            //Shape shape = new Shape();
            Shape shape = new Square(25); 
            Console.WriteLine(shape.Area);
        }
    }
}
