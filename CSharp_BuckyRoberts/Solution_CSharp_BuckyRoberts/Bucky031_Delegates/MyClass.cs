using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass
    {
        delegate void MyDelegate(string myString);
        public void ShowThoseMessages()
        {
            MyDelegate md = new MyDelegate(ShowMessage);//adding a method to the delegate
            md += ShowAnotherMessage; //adding the second method to the delegate

            md("Adam"); //call All the methods inside of the delegate
        }

        //Method #1
        public void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        //Method #2
        void ShowAnotherMessage(string a)
        {
            System.Windows.Forms.MessageBox.Show(a, "Test");
        }
    }
}
