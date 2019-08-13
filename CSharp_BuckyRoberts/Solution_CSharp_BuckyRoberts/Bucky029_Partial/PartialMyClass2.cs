using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
        partial class MyClass
        {
            public string HairColor = "Brown";
            public bool Glasses = false;

        partial void Message(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        public void ShowMessage(string message)
        {
            Message(message);
        }

    }
}
