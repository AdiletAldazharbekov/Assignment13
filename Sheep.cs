using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    internal class Sheep : Animal
    {
        public override int Age { get => Age; set => Age = value; }
        public override int Weight { get => Weight; set => Weight = value; }

        public Sheep(string name, int age, bool gender, int weight) : base(name, age, gender, weight)
        {
        }
        
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void WhatFeed()
        {
            Console.WriteLine("какое животное какой корм ест");
        }
    }
}
