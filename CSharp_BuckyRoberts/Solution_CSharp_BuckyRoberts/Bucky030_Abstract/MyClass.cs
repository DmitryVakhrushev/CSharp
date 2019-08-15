using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace MyNamespace
{
    abstract class MyClass
    {
        public string Name = "Adam";
        public int Age = 15;
        public static void Message(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }


        public abstract void ShowMessage(string message);
        
        class MySecondClass : MyClass
        {
            public override void ShowMessage(string message)
            {
                System.Windows.Forms.MessageBox.Show(message);
            }
        }

    }

}
