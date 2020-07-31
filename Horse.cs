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
                    Console.WriteLine("Возраст от 1 до 30");
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
                    Console.WriteLine("Вес от 1 до 740");
                }
                else weight = value;
            }
        }
        public Horse(string name, int age, string gender, int weight) : base(name, age, gender, weight)
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
