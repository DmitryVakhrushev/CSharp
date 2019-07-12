using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("Curious", 10, 7.2);
            
            Console.WriteLine("Cat's age is " + cat1.age);

            Console.WriteLine("Cat's stomach = " + cat1.stomach);

            Console.WriteLine("Cat's name is " + cat1.getName());

            Console.WriteLine("Cat's age is " + cat1.getAge());

            Console.WriteLine(cat1.Weight);
            cat1.Weight = 99.2;
            Console.WriteLine(cat1.Weight);

            Console.WriteLine("Speek: " + cat1.speek());

            cat1.feed(12);
            Console.WriteLine(cat1.stomach);
            Console.WriteLine("Speek again: " + cat1.speek());

            Console.ReadLine();

            Random rand = new Random();
            for (int i = 1; i < 10; i++)
            {
                double x = rand.NextDouble()*800;
                int a = (int)x;
                if (a > (800-32))
                {
                a = 800-32;
                }
                
                Console.WriteLine(a);
            }


        }
    }
}
