using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProject.MyFirstDataTypes
{
    public static class ShapeUtility
    {
        public static bool IsPolygon(Shape shape)
        {
            // Rule 1: anything that we defined in the static class has to be static
            // Rule 2: we cannot create an instance pf the static class
            // Rule 3: we cannot inherent from the static class (as we can inherent instance information)

            return shape.Sides >= 3;
        }
    }
}
