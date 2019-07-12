using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProject.MyFirstDataTypes
{
    public abstract class Shape
    {
        public abstract double Area
        {
            get; // Guarantess that every class that inherits from "Shape" has to overide the Area property
        }
    }
}
