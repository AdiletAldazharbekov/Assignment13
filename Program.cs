using System;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа \"Ферма\"");

            var fields = (string[])Operation.Registration();
            Farm farm = new Farm (fields[0], fields[1]);

            while (true)
            {
                var input = Operation.MainOperation();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("+ Лошадь");
                        var fieldsHorse = (string[])Operation.AddAnimal();
                        Horse horse = new Horse(fieldsHorse[0], Convert.ToInt32(fieldsHorse[1]), fieldsHorse[2], Convert.ToInt32(fieldsHorse[3]), fieldsHorse[4]);
                        farm.AddHorse(horse);
                        break; 
                    case 2:
                        Console.WriteLine("+ Корова");
                        var fieldsCow = (string[])Operation.AddAnimal();
                        Cow cow = new Cow(fieldsCow[0], Convert.ToInt32(fieldsCow[1]), fieldsCow[2], Convert.ToInt32(fieldsCow[3]), fieldsCow[4]);
                        farm.AddCow(cow);
                        break;
                    case 3:
                        Console.WriteLine("+ Баран");
                        var fieldsSheep = (string[])Operation.AddAnimal();
                        Sheep sheep = new Sheep(fieldsSheep[0], Convert.ToInt32(fieldsSheep[1]), fieldsSheep[2], Convert.ToInt32(fieldsSheep[3]), fieldsSheep[4]);
                        farm.AddSheep(sheep);
                        break;
                    case 4:
                        Console.WriteLine("Информация о ферме");
                        farm.FullInfo();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
                if (input == 0) break;
            }
        }
    }
}
