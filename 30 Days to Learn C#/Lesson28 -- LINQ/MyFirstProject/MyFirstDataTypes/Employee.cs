using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProject.MyFirstDataTypes
{
    // To inherent from Person class use : Person
    // We will get Person's properties and SayHello() method
    // but we don't get a Constructor

    public class Employee : Person, ISalariable, IFirable
    {
        // let's write the constructor for the Person class
        public Employee(string firstName, string lastName, EmployeePosition position, decimal salary)
            : base(firstName, lastName)
        {
            //if (string.IsNullOrEmpty(lastName))
            //{
            //    throw new ArgumentException("Last Name cannot be null, empty, or whitespace");
            //}

            //if (_Salary < 1)
            //{
            //    throw new ArgumentException("salary cannot be less than 1");
            //}

            Position = position; // assigned to simplified get, set methods
            _Salary = salary;
        }

        // position of an employee: owner, manager, worker, etc.
        public EmployeePosition Position { get; private set; }

        public override string ToString()
        {
            return base.ToString() + "; " + Position;
        }

        public override string SayHello(string name)
        {
            //return base.SayHello(name);
            return "Hi! how may I help you, " + name + "?";
        }

        private decimal _Salary;
        public decimal Salary
        {
            get { return _Salary; }
        }

        public void PaySalary()
        {
            // something important
        }

        public void Fire()
        {
            _Salary = 0;
            // some important code
        }
    }
}
