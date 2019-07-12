using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProject.MyFirstDataTypes
{
    class Square: Shape
    {
        public double Length { get; private set; }
        public Square(double sideLength)
        {
            Length = sideLength;
        }

        public override double Area 
        {
            get { return Length * Length; }
        }
    }
}
