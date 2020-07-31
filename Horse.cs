using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    internal class Horse : Animal
    {
        public override int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Horse(string name, int age, bool gender, int weight) : base(name, age, gender, weight)
        {
        }

        public void Info()//реализовать абстрактный метод
        {
            Console.ReadLine();
            Console.WriteLine("какое животное какой корм ест");
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
