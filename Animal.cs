using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    abstract class Animal
    {
        public string Name { get; }
        public bool Gender { get; }

        public int Age { get; }
        public int Weight { get; }

        public Animal()
        {
            Name = Name;
            Age = Age;
            Gender = Gender;
            Weight = Weight;
        }

        public void Eat()
        {
            Console.WriteLine("20");
        }
    }
}
