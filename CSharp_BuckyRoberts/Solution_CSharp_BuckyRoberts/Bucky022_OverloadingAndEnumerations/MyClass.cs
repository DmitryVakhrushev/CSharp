using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace //You can rename the namespace as needed
{
    class MyClass
    {

        //################# Method Overloading #################
        public static void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        public static void ShowMessage(int message)
        {
            System.Windows.Forms.MessageBox.Show(message.ToString());
        }

        //################# Enumerations #################
        enum Names // integer array
        {
            Adam, Joe, Bob
        }

        Names eNum = Names.Adam;

        enum Names2 : byte // byte array
        {
            Adam = 1,
            Joe = 4,
            Bob
        }



    }
}
