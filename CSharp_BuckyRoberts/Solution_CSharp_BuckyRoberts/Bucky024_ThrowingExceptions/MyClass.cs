using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace MyNamespace
{
    class MyClass
    {

        static Exception myException = new Exception("You can't set this string equal to an empty string");
        public static void CheckString(string myString)
        {
            try
            {
                if (myString == "") throw myException;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
           
    }
}
