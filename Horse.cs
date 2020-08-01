using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    internal class Horse : Animal
    {
        private int age;
        private int weight;


        public override int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 1 || value > 30)
                {
                    Console.WriteLine("Ошибка ввода, Возраст должен быть от 1 до 30");
                }
                else age = value;
            }
        }

        public override int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 1 || value > 740)
                {
                    Console.WriteLine("Ошибка ввода, Вес должен быть от 1 до 740");
                }
                else weight = value;
            }
        }

        public override string Korm { get; set; }

        public Horse(string name, int age, string gender, int weight, string korm) : base(name, age, gender, weight, korm)
        {
        }

        public override void Eat(Animal animal)
        {
            Console.WriteLine($"{animal.GetType()} {animal.Name} ест: {animal.Korm}");
        }
    }
}
