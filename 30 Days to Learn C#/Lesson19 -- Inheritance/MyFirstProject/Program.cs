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
            System.Object x; // we can declare a variable in this way
            Object myVariable1; // or that way
            object myVariable2; // or that way

            object foo = (object)10; // casting
            int bar = (int)foo;

            Console.WriteLine(bar);

            Person jeremy = new Person("Jeremy", "McPeak");
            Console.WriteLine(jeremy.ToString());

            Console.WriteLine(jeremy); // the same result

            object foo2 = (object)jeremy; // we MAY cast jeremy as the object BUT not necesserily
                                          // as the compiler knows that jeremy is a Person object
            
            object foo1 = jeremy; // so we can skip casting
            Console.WriteLine(foo1); // the same result

            // However, here we need explicitly say that foo1 object is the Person object
            Person jeremy2 = (Person)foo1;


            Console.WriteLine("-----------------------------------------------");
            //==============================================
            Employee dmitry = new Employee("Dmitry","Vakhrushev","Database Marketing Analyst");
            Console.WriteLine(dmitry);
            //==============================================
            
            Person customer = new Person("John", "Doe");
            Console.WriteLine(dmitry.SayHello(customer) + "\n");

        }
    }
}
