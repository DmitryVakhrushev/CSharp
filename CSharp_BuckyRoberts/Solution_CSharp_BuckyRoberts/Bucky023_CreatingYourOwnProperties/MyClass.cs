using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass
    {
        //Constructor
        string myString;
        public MyClass(string catName)
        {
            myString = catName;
        }

        //Access Modifier to your property
        //"Getter" and "Setter"
        public string petsName
        {
            get { return myString; } //allows a user to read from a property
            set
            {
                if (value == "") System.Windows.Forms.MessageBox.Show("You can't do that");
            }

                //allows a user to write to the property (if deleted then it's read only
        }
           
    }
}
