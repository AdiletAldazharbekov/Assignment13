using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    class Farm
    {
        public string FarmName { get; private set; }
        public string FarmAdress { get; private set; }

        private List<Horse> Horses = new List<Horse>();
        private List<Sheep> SheepFlock = new List<Sheep>();
        private List<Cow> Cows = new List<Cow>();

        public Farm(string farmName, string farmAdress)
        {
            FarmName = farmName;
            FarmAdress = farmAdress;
        }

        public void AddHorse(Horse horse) => Horses.Add(horse);

        public void AddCow(Cow cow) => Cows.Add(cow);

        public void AddSheep(Sheep sheep) => SheepFlock.Add(sheep);

        public void FullInfo()
        {
            // Полная информация о ферме(Название фермы, адрес и вывести по отдельности всех животных)
            Console.WriteLine($"\tФерма: {FarmName}\n\tАдрес: {FarmAdress}\n\nСостав фермы:");
            
            Console.WriteLine("\nЛошади");
            foreach (var horse in Horses) Console.WriteLine($"Имя: {horse.Name} \tВозраст: {horse.Name} \tПол: {horse.Gender} \tВес: {horse.Weight} \tКорм: {horse.Korm}");

            Console.WriteLine("\nКоровы");
            foreach (var cow in Cows) Console.WriteLine($"Имя: {cow.Name} \tВозраст: {cow.Name} \tПол: {cow.Gender} \tВес: {cow.Weight} \tКорм: {cow.Korm}");

            Console.WriteLine("\nОвцы");
            foreach (var sheep in SheepFlock) Console.WriteLine($"Имя: {sheep.Name} \tВозраст: {sheep.Name} \tПол: {sheep.Gender} \tВес: {sheep.Weight} \tКорм: {sheep.Korm}");
        }
    }
}