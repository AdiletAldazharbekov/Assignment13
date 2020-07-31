using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    class Farm
    {
        public string FarmName { get; private set; }
        public string FarmAdress { get; private set; }

        private List<string> Horses { get; set; }
        private List<string> SheepFlock { get; set; }
        private List<string> Cows { get; set; }

        public Farm(string farmName, string farmAdress)
        {
            FarmName = farmName;
            FarmAdress = farmAdress;

        }
         public void AddHorse(string name)
        {
            //AddHorse() добавляет Horse в табу
            Horses.Add(name);
        }

        public void AddCow(string name)
        {
            // AddCow(); добавляет Cow в стадо
            Cows.Add(name);
        }

        public void AddSheep(string name)
        {
            // AddSheep(); добавляет Sheep в стадо
            SheepFlock.Add(name);
        }

        public void FullInfo()
        {
            // Полная информация о ферме(Название фермы, адрес и вывести по отдельности всех животных)
            Console.WriteLine($"\tФерма: {FarmName}\n\tАдрес: {FarmAdress}\n\tСостав фермы:\n\n");
            //List<string> animals = new List<string>();
           
            //foreach (var a in Horses)
            //{
            //    Console.WriteLine(a);
            //}
            //foreach (var a in Cows)
            //{
            //    Console.WriteLine(a);
            //}
            //foreach (var a in SheepFlock)
            //{
            //    Console.WriteLine(a);
            //}
        }
    }
}


//Нужно чтобы пользователь выбирал через консоль какое животное добавить в ферму и так же вывод полной информации о ферме.