using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class MyClass
    {

        string[] myArray = { "Adam", "Bob", "Joe" };
        
        //Indexer
        public string this[int index]
        {
            get { return myArray[index]; }
            set { myArray[index] = value; }
        }

    }
}
