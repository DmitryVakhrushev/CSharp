using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProject.MyFirstDataTypes
{
    public class Person
    {
        private string _firstname;
        private string _lastname;

        public Person(string firstName, string lastName = "")
        {
            this._firstname = firstName;
            this._lastname = lastName;
        }

        //Writing "GET" and "SET" methods
        public string FtNm
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string LtNm
        {
            get { return _lastname; }
        }

        public string SayHello(string name)
        {
            return "Hello there, " + name;
        }

        public string SayHello(Person person)
        {
            return SayHello(person._firstname + " " + person._lastname);
        }

        //public string SayHello(Person person)
        //{
        //    return "Hello, " + person._firstname + " " + person._lastname;
        //}

    }
}
