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
            Console.WriteLine(john.SayHello("Chebika" + "\n\n"));

            Console.WriteLine("the value in the _firstname variable = " + john.FtNm + "\n");

            john.FtNm = "I have just changes the FIRST NAME";
            Console.WriteLine("First Name: " + john.FtNm);
            Console.WriteLine("Last Name: " + john.LtNm + "\n\n");

            Person jane = new Person("Jane", "Doe");
            string greetings = (john.SayHello(jane.FtNm + " " + jane.LtNm));
            Console.WriteLine(greetings + "\n");

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(john.SayHello(jane)+"\n");

            
            

        }
    }
}
