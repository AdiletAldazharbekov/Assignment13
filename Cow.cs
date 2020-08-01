using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    internal class Cow : Animal
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
                if (value < 1 || value > 20)
                {
                    Console.WriteLine("Ошибка ввода, Возраст должен быть от 1 до 20");
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
                if (value < 1 || value > 850)
                {
                    Console.WriteLine("Ошибка ввода, Вес должен быть от 1 до 850");
                }
                else weight = value;
            }
        }

        public override string Korm { get; set; }

        public Cow(string name, int age, string gender, int weight, string korm) : base(name, age, gender, weight, korm)
        {
        }

        public override void Eat(Animal animal)
        {
            Console.WriteLine($"{animal.GetType()} Корм: {animal.Korm}");
        }
    }
}
