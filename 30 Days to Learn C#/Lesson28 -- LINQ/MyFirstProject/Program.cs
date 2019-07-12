using System;
using System.Collections.Generic;
using System.Text;

using System.Linq; // Language INtegrated Query (LINQ)

using MyFirstProject.MyFirstDataTypes;

namespace MyFirstProject
{

    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> employees = new Employee[] {
                new Employee("John","Doe",EmployeePosition.Owner, 200000),
                new Employee("Jim","Donald",EmployeePosition.Manager, 100000),
                new Employee("Jane","Dixie",EmployeePosition.SalesClerk, 25000),
                new Employee("Jackie","Dame",EmployeePosition.SalesClerk, 25000),
                new Employee("Jeff","Draper",EmployeePosition.Stocker, 18000),
                new Employee("Jessica","Donroe",EmployeePosition.Stocker, 18000)
        };


            // Query Syntax
            var query = from employee in employees
                        where employee.FirstName == "John"
                        select employee;

            foreach (var x in query)
            {
                Console.WriteLine(x.FullName);
            }


            // Using extension method
            var query2 = employees.Where(e => e.FirstName == "John");



            // Doing it without LINQ
            var emps = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "John")
                {
                    emps.Add(employee);
                }
            }

            //-----------------------------------
            // Advanced

            // Query Syntax
            var query3 = from employee in employees
                        group employee by employee.Position;

            foreach (var group in query3)
            {
                Console.WriteLine(group.Key);
                foreach (var employee in group)
                {
                    Console.WriteLine(employee.FullName);
                }
                Console.WriteLine();
            }

            //---------------------------
            var query4 = employees.GroupBy(e => e.Position);
            foreach (var group in query4)
            {
                Console.WriteLine(group.Key);
                foreach (var employee in group)
                {
                    Console.WriteLine(employee.FullName);
                }
                Console.WriteLine();
            }


        }
    }
}
