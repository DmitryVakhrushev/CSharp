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
        private int weight = 60; // NOT available in the inheretance
        protected int roomNumber = 17;
        public string name = "Bob";
        public int age = 10;
        public void ShowMessage(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message);
        }

        public virtual void VirtShowMsg(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message);
        }

    }

    //Inheritance takes all non-private members of the original class to use in another class
    class MySecondClass : MyClass // MyClass is the "base" class
    {
        public string hairColor = "Brown";

        public void MessageBoxSpecial()
        {
            System.Windows.Forms.MessageBox.Show(base.age.ToString());
        }

        public void MessageBoxSpecial2()
        {
            base.ShowMessage(base.name);
            base.ShowMessage(base.roomNumber.ToString());
        }

        //Overriding the class with "new" keyword
        public new void ShowMessage(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "My Title");
        }

        //We can use "override" keywords for "virtual" inhereted methods
        public override void VirtShowMsg(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, "My Title");
        }

    }

}
