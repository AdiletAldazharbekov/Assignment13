using System;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm("Crazy Farm", "Kyrgyzstan, Bishkek, Kolbaev str., 43");

            var horse1 = new Horse("Horse 1", 5, true, 100);
            farm.AddHorse(horse1.Name);
            var horse2 = new Horse("Horse 2", 10, true, 200);



            farm.FullInfo();
        }
    }
}
