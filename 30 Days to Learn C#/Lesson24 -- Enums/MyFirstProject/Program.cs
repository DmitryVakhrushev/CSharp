using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyFirstProject.MyFirstDataTypes;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("John", "Doe", EmployeePosition.Manager, 200000);
        }
    }
}
