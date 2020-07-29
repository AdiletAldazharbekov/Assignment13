using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    class Farm
    {
        public string FarmName { get; set; }
        public string FarmAdress { get; set; }

        private List<string> Horses { get; set; }
        private List<string> SheepFlock { get; set; }
        private List<string> Cows { get; set; }

        public Farm(string farmName, string farmAdress)
        {
            FarmName = farmName;
            FarmAdress = farmAdress;

        }
         public void AddHorse()
        {
            //AddHorse() добавляет Horse в табун
        }

        public void AddCow()
        {
            // AddCow(); добавляет Cow в стадо
        }

        public void AddSheep()
        {
            // AddSheep(); добавляет Sheep в стадо
        }

        public void FullInfo()
        {
            // Полная информация о ферме(Название фермы, адрес и вывести по отдельности всех животных)
        }
    }
}


//Нужно чтобы пользователь выбирал через консоль какое животное добавить в ферму и так же вывод полной информации о ферме.