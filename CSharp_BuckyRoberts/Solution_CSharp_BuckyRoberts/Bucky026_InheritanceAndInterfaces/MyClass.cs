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
        public string name = "Bob";
        public int age = 10;
        public virtual void ShowMessage(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message);
        }
    }


    //inside of this interface you can create names for methods, properties, indexers, and events
    interface IMyInterface
    {
        void MyVoid();

    }

    //Inheritance takes all non-private members of the original class to use in another class
    class MySecondClass : MyClass, IMyInterface // MyClass is the "base" class
    {
        public string hairColor = "Brown";
        public override void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "My Title");
        }

        public void MyVoid()
        {
            base.ShowMessage("My void");
        }
    }
}