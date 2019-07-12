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
            List<string> names = new List<string>
            {
                "Jeremy",
                "Jeffrey",
                "John",
                "Jennifer",
                "Jackie",
                "Julianne"
            };


//-------------------------------------------------
            var namesWithE = names.FindAll(
                delegate(string name)
                {
                    return name.IndexOf("e") == 1; // select any name that has "e" as the secind letter
                }
                );

            foreach (var name in namesWithE)
            {
                Console.WriteLine(name);
            }

        }

    }
}

        //---------------------------------------------------------------
        /* 
                    var namesWithE = names.FindAll(FindNamesWithE);

                    foreach (var name in namesWithE)
                    {
                        Console.WriteLine(name);
                    }

                }

                static bool FindNamesWithE(string name)
                {
                    return name.IndexOf("e") == 1; // select any name that has "e" as the secind letter
                }

        
        //---------------------------------------------------------------
    }
}

        */