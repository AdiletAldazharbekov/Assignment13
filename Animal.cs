using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    abstract class Animal
    {
        public string Name { get; set; }
        public bool Gender { get; set; }

        public int Age { get; set; }
        public int Weight { get; set; }

        public Animal(string name, int age, bool gender, int weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
        }

        public void Eat()
        {
            Console.WriteLine("20");
        }
    }
}
