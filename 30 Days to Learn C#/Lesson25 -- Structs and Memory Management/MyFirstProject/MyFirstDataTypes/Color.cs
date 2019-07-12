using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProject.MyFirstDataTypes
{
    public struct Color
    {
        //create R(red), G(green), B(blue) properties
        // the datatype is "byte"
        public byte R { get; private set; }
        public byte G { get; private set; }
        public byte B { get; private set; }


        // Constructor to set instance properties
        public Color(byte red, byte green, byte blue)
        {
            R = red;
            G = green;
            B = blue;
        }


        // static methods
        public static Color Red
        {
            get { return new Color(255, 0, 0); }
        }

        public static Color Green
        {
            get { return new Color(0, 255, 0); }
        }

        public static Color Blue
        {
            get { return new Color(0, 0, 255); }
        }

        public static Color Black
        {
            get { return new Color(0, 0, 0); }
        }

        public static Color White
        {
            get { return new Color(255, 255, 255); }
        }

    }
}
