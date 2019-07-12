using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirstProject.MyFirstDataTypes
{
    public class Person
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        
        public Person(string firstName, string lastName = "")
        {
            // validating the firstName in the Constructor
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrWhiteSpace(firstName))
            {
                // if the string is null, whitespace, or empty we want to throw a new exception
                // if this excecutes ALL code execution WILL STOP

                throw new ArgumentException("firstName cannot be null, empty, or whitespace");
            }

            // validating the lastName in the Constructor
            if ((lastName == null || lastName.Trim() == string.Empty)  && lastName != string.Empty)
            {
                throw new ArgumentException("lastName cannot be null or whitespace");
            }

            FirstName = firstName;
            LastName = lastName;
        }

        // Overload 1
        public string SayHello(string name)
        {
            // check for null
            // empty
            // whitespace

            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                // if the string is null, whitespace, or empty we want to throw a new exception
                // if this excecutes ALL code execution WILL STOP
                
                throw new ArgumentException("name cannot be null, empty, or whitespace");
            }
            return "Hello there, " + name;
        }

        // Overload 2
        public string SayHello(Person person)
        {
            if (person == null)
            {
                // throwing an exception
                // exceptions are bsically "errors"
                throw new ArgumentNullException("person cannot be null");
            }
            
            return SayHello(person.FirstName + " " + person.LastName);
        }
    }
}
