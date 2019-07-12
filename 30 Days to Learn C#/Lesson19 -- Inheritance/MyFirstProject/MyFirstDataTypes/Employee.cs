using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProject.MyFirstDataTypes
{
    // To inherent from Person class use : Person
    // We will get Person's properties and SayHello() method
    // but we don't get a Constructor
    public class Employee : Person
    {
        // let's write the constructor for the Person class
        public Employee(string firstName, string lastName, string position): base (firstName, lastName)
        {
            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("Last Name cannot be null, empty, or whitespace");
            }
            if (string.IsNullOrEmpty(position) || string.IsNullOrWhiteSpace(position))
            {
                throw new ArgumentException("Position cannot be null, empty, or whitespace");
            }

            Position = position; // assigned to simplified get, set methods
        }

        // position of an employee: owner, manager, worker, etc.
        public string Position { get; private set; }

        public override string ToString()
        {
            return base.ToString() + "; " + Position;
        }

        public override string SayHello(string name)
        {
            //return base.SayHello(name);
            return "Hi! how may I help you, " + name + "?";
        }
    }
}
