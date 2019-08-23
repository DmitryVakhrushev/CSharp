using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bucky035_MoreVariableTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //-------------------------
            //UNSIGNED INTEGERS (0-255)

            //byte = 8 bits (1 or 0). The maximum value that 8 bits can hold = 255
            
            //Unsigned Byte: can hold values (0 - 255)
            byte myByte = 255;

            //Signed byte: can hold values from -128 to 127 (range is 255)
            sbyte mySbyte = 127; 

            
            // short, Int16, Int32, Int64 are signed be default

            //two bytes that are put together called "short" = 16 bits
            short myShort = -10; //signed integer
            ushort myUshort = 300; //unsigned integer

            //Another way to represent a "short" is "Int16" - 16-bit integer
            Int16 myInt16 = myShort; //we can assign short to Int16 as they are the same thing
            UInt16 myUInt16 = 345; // unsigned Int16 (positive values only)


            int myInt = 0; //integrer value that is equal to 32-bit integer
            Int32 myInt32 = myInt;
            UInt32 myUInt32 = 1345; // unsigned Int32 (positive values only)


            long myLong = 0; //integrer value that is equal to 64-bit integer
            Int64 myInt64 = myLong;
            UInt64 myUInt64 = 107789; // unsigned Int64 (positive values only)


            //--------------------------
            // Float is a floating point integer. Can represent a very small or very large number

            float myFloat = 2345854213767876; //floats are accurate up to 7 digits long
            MessageBox.Show(myFloat.ToString());

            float myFloat2 = 0.5F; //explictily define a float

            double myDouble1 = 0.5;

            //Char - to represent one charac
            char myChar = 'd'; //use single qoutes

        }
    }
}
