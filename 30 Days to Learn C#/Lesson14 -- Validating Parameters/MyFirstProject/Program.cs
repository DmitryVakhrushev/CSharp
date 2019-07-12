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
            Person jane = new Person("Jane");

            //string greetings = john.SayHello(jane);
            //Console.WriteLine(greetings + "\n");

            // It will handle the following exceptions:
                    //Person person = new Person(null, null);
                    //Person person = new Person(string.Empty, null);
                    //Person person = new Person(" ", null);

            //Person person = new Person("Jeremy", null);
            //Person person = new Person("Jeremy", "  ");

            Person person = new Person("Jeremy", "daldsjals");
            Console.WriteLine(person.SayHello("Jeremy" + "\n"));


            
        }
    }
}
