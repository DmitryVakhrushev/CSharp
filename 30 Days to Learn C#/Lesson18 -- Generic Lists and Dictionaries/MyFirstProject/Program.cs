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


            string[] names = new string[]
            {
            "James",
            "John",
            "Jennifer",
            "Jackie"
            };

            List<int> col1 = new List<int>();
            List<string> names1 = new List<string>();

            // the shortcut "var"
            var names2 = new List<string>();

            // we can specify INITIAL capacity
            var names3 = new List<string>(10);

            //-------------------------------------------------------
            // features of the list class
            //-------------------------------------------------------

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("LISTS");
            Console.WriteLine("----------------------------------------------");
            
            List<string> namesList = new List<string>();

            // Adding elements to the list
            namesList.AddRange(names); // populate using an array
            namesList.Add("Dmitry"); // add an element to the list

            // how many elements are in the list
            Console.WriteLine("list has elemets: " + namesList.Count);
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(namesList[0]);

            // Check if an element is in the list
            bool hasName = namesList.Contains("Dmitry");
            Console.WriteLine(hasName);
            Console.WriteLine("---------------------------------------");

            // FindAll method allows to specify a searching criteria inside the list
            // we use Lambda expressions for that
            // find all elements that have the second letter = 'a'
            var newList = namesList.FindAll((s) => s[1] == 'a');
            foreach (var name in newList)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("---------------------------------------");

            // clear out all elemets
            namesList.Clear();
            Console.WriteLine("list has elemets: " + namesList.Count);

            namesList.TrimExcess();
            Console.WriteLine("list has elemets: " + namesList.Count);

            //===============================================================
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("DICTIONARY");
            Console.WriteLine("----------------------------------------------");

            Dictionary<int, string> dict1 = new Dictionary<int, string>();

            var myDict = new Dictionary<int, string>();
            myDict.Add(0, "Jeremy");
            string value = myDict[0]; // because we've used an integer as "Key" it looks exactly like Index notaion

            var dict2 = new Dictionary<string, string>();
            dict2.Add("a", "Dmitry");
            dict2.Add("boo", "Natalia");

            string value2 = dict2["a"]; // as here we use "string" as a "Key"
            Console.WriteLine(dict2["a"]);

            //dict2.ContainsKey("a");
            //dict2.ContainsValue("Dmitry");

            //dict2.Remove("a"); // accepts a "Key" not an Index
            
            // Printing values from Dictionary
            foreach (var keyValuePair in dict2)
            {
                Console.WriteLine(keyValuePair.Key + " = " + keyValuePair.Value);
            }

            //-----------------------------------------------
            Console.WriteLine("\n----------------------------------------------");
            Console.WriteLine("Multivalue Dictionary");
            Console.WriteLine("----------------------------------------------");
            
            var multiValueDict = new Dictionary<string, List<string>>();
            multiValueDict.Add("a", new List<string>());
            multiValueDict["a"].Add("Dmitry");
            multiValueDict["a"].Add("Natalia");

        }
    }
}
