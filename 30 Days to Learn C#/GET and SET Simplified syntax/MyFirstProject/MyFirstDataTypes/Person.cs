using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProject.MyFirstDataTypes
{
    public class Person
    {
        // using simplified syntax for GET and SET methods
        public string FtNameProperty { get; private set; }
        public string LtNameProperty { get; private set; }

        public Person(string firstName, string lastName)
        {
            FtNameProperty = firstName;
            LtNameProperty = lastName;
        }

        // Overload 1
        public string SayHello(string name)
        {
            return "Hello " + name;
        }

        // Overload 2
        public string SayHello(Person x)
        {
            return "Hello " + x.FtNameProperty + " " + x.LtNameProperty + "!!!\n";
        }
    }
}
