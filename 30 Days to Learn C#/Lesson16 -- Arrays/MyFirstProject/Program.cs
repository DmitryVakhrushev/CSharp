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
            #region Old code
            //Person john = new Person("John","Doe");
            //Person jane = new Person("Jane");

            ////string greetings = john.SayHello(jane);
            ////Console.WriteLine(greetings + "\n");

            //// It will handle the following exceptions:
            //        //Person person = new Person(null, null);
            //        //Person person = new Person(string.Empty, null);
            //        //Person person = new Person(" ", null);

            ////Person person = new Person("Jeremy", null);
            ////Person person = new Person("Jeremy", "  ");

            //Person person = new Person("Jeremy", "daldsjals");
            //Console.WriteLine(person.SayHello("Jeremy" + "\n")); 
            #endregion
            #region oldcode2
            ////*************************************************************
            //// FOR Loop -- you know how many incrementation you know
            //// for (initialization; condition; incrementation)
            //string str = "Hello, World!";
            //for (int counter = 0; counter < str.Length; counter++)
            //{
            //    // "ii" is a good name for the counter as it's easier to find in the text
            //    //int i = counter++; // assigns a value and THEN increment
            //    //int z = ++counter; // increments the value and assign

            //    Console.WriteLine(counter);
            //}


            ////*************************************************************
            //// WHILE Loop -- executes WHILE smth is TRUE
            //int index = str.IndexOf("l");
            //while (index > -1)
            //{
            //    str = str.Remove(index, 1);
            //    index = str.IndexOf("l");
            //}
            //Console.WriteLine(str);


            ////*************************************************************
            //// DO WHILE Loop
            //do
            //{

            //} while (index > -1);



            ////*************************************************************
            //// FOR EACH Loop -- used with arrays or strings
            //// for each character in the string "str" perform some action
            //str = "Hello, World!";
            //foreach (char c in str)
            //{
            //Console.WriteLine(c);
            //} 
            #endregion

            // Create an array
            // DataType [] = new DataType [length];
            char[] foo = new char[5];
            foo[0] = 'H';
            foo[1] = 'e';
            foo[2] = 'l';
            foo[3] = 'l';
            foo[4] = 'o';

            // With FOR Loop
            for (int i = 0; i < foo.Length; i++) { Console.Write(foo[i]); }
            Console.WriteLine();

            // with FOR EACH Loop
            foreach (char x in foo) { Console.Write(x); }
            Console.WriteLine();

            // Another way to populate the array
            // We do not specify the length of the array but populate it at the time of creation
            char[] myArr = new char[] { 'H', 'e', 'l', 'l', 'o', ' ', 'K', 'i', 't', 't','i' };
            Console.WriteLine(myArr);
        }
    }
}
