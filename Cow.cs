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

        public void Info()//реализовать абстрактный метод
        {
            Console.WriteLine("какое животное какой корм ест");
        }
    }
}
