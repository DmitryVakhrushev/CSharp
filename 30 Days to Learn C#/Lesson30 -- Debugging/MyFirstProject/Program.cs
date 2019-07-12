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
            WriteTimestable(2);
        }

        static void WriteTimestable(int multiplier)
        {
            for (int i = 1; i < 13; i++)
            {
                string str = string.Format("{0} * {1} = {2}", i, multiplier, i * multiplier);
                
                Console.WriteLine(str);
            }
        }


    }
}
