﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProject.MyFirstDataTypes
{
    public static class ShapeUtility
    {
        public static bool IsPolygon(Shape shape)
        {
            return shape.Sides >= 3;
        }
    }
}
