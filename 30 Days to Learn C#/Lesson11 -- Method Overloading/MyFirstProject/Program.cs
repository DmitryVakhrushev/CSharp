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
            Person john = new Person("John","Doe");
            Person jane = new Person("Jane", "Doe");

            // approach with concatenating parameters
            string greetings = (john.SayHello(jane.FtNm + " " + jane.LtNm));
            Console.WriteLine(greetings + "\n");

            // approach with overloading
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(john.SayHello(jane)+"\n");
        }
    }
}
