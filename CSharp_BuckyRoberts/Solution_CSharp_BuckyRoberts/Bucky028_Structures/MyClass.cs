using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
        struct Client
        {
            //Constructor
            public Client(string name)
            {
            Name = "";
            Age = 0;
            }   
            public string Name;
            public int Age;

        //We can have methods inside of Structures
        public void ClearClientInfo()
        {
            Name = "";
            Age = 0;
        }
        }
}
