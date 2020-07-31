using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    internal class Cow : Animal
    {
        public Cow(string name, int age, bool gender, int weight) : base(name, age, gender, weight)
        {
        }

        public override int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void Info()//реализовать абстрактный метод
        {
            Console.WriteLine("какое животное какой корм ест");
        }
    }
}
