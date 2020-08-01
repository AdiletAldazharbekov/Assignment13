using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    abstract class Animal
    {
        public string Name { get; private set; }
        public string Gender { get; private set; }

        public abstract int Age { get; set; }
        public abstract int Weight { get; set; }
        public abstract string Korm { get; set; }


        public Animal(string name, int age, string gender, int weight, string korm)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
            Korm = korm;
        }

        public abstract void Eat(Animal animal);
    }
}
