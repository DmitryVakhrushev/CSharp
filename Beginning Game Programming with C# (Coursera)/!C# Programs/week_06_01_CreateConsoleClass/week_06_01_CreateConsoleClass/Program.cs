using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace week_06_01_CreateConsoleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // test standard die
            Die standardDie  = new Die();

            Console.WriteLine("STANDARD DIE");
            Console.WriteLine("Number of sides: " + standardDie.NumSides);
            Console.WriteLine("Top side: " + standardDie.TopSide);
            standardDie.Roll();
            Console.WriteLine("------------------------------------");


            // test D20 die
            Die d20die = new Die(20);

            Console.WriteLine("d20 DIE");
            Console.WriteLine("Number of sides: " + d20die.NumSides);
            Console.WriteLine("Top side: " + d20die.TopSide);
            d20die.Roll();
            Console.WriteLine("------------------------------------\n");

            for (int i = 0; i < 10; i++)
            {
                standardDie.Roll();
                //Console.WriteLine("Top side after Rolling a Die: " + standardDie.TopSide);
                
            }
            GameState myState = GameState.Play;
            Console.WriteLine();
        }
    }
}
