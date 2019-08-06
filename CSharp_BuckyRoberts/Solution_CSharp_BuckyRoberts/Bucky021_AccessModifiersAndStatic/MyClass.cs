using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace //You can rename the namespace as needed
{
    class MyClass
    {
        string NewName;
        //This is a Class construstor the we defined
        public MyClass(string name)
        {
            NewName = name;

        }

        //This is a method inside of the Class
        public string publicName()
        {
            return NewName;
        }

        public static void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

    }
}
