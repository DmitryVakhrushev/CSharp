using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass
    {

        public event EventHandler OnPropertyChanged;

        string name = "";
        public string Name
        {
            get { return name; }
            set
            {
                //when a user changes a property value we raise the event
                name = value;
                OnPropertyChanged(this, new EventArgs());
            }
        }
    }
}
