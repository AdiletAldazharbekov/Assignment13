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
                    Console.WriteLine("Возраст от 1 до 20");
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
                    Console.WriteLine("Вес от 1 до 850");
                }
                else weight = value;
            }
        }
        public Cow(string name, int age, string gender, int weight) : base(name, age, gender, weight)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Животное питается");
        }

        public override void WhatFeed()
        {
            Console.WriteLine("какое животное какой корм ест");
        }
    }
}
