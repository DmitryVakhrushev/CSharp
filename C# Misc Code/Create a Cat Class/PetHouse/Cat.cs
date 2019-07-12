using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetHouse
{
    /*
    abstract class  Animal {
        public void play() {
            for (int i = 0; i < 1000; i++)
            {
                this.speak();
                this.run();
                this.speak();
                this.jump();
            }
        }

        public abstract void speak();
        public abstract void run();
        public abstract void jump();

    }

    class Dog : Animal { 
    }*/

    public class Cat
    {
        private string _name;
        public int age;
        public double weight;
        public double stomach;

        public Cat(string catName, int catAge = 5, double kilo = 20)
        {
            this._name = catName;
            this.age = catAge;
            this.weight = kilo;
            this.stomach = 0;
        }

        public string speek()
        {
            if (this.stomach > 0) { return "purrrr"; }
            else { return "meow!!!"; }
        }

        public void feed(int amount)
        {
            // feed a cat
            this.stomach = this.stomach + amount;
        }

        // Age property
        public int getAge()
        {
            return this.age;
        }
        public void setAge(int value)
        {
            this.age = value;
            Console.WriteLine("Age has changed to {0}", value);
        }

        // Weight property
        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
                Console.WriteLine("Weight has changed to {0}", value);
            }
        }

        public string getName()
        {
            // print cat's name
            return this._name;
        }

    }
}
