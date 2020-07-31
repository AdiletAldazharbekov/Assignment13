using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    abstract class Animal
    {
        public string Name { get; set; }
        public bool Gender { get; set; }

        public abstract int Age { get; set; }
        public abstract int Weight { get; set; }

        public Animal(string name, int age, bool gender, int weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
        }

        public abstract void Eat();
    }
}
