
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    class Operation
    {
        public static int MainOperation()
        {
            Console.WriteLine("Выберите операцию" +
                "\n\t1. Купить лошадь" +
                "\n\t2. Купить корову" +
                "\n\t3. Купить овцу" +
                "\n\t4. Купить корм" +
                "\n\tВыход любая другая клавиша");

            var input = Console.ReadLine();
            int.TryParse(input, out int oper);
            Console.Clear();
            return oper;
        }

        public static Array Registration()
        {
            Console.WriteLine("\n\tДля начало нужно создать ферму, введите следующие данные");
            string[] fields = new string[] { "Название фермы", "Адрес фермы" };
            for (int i = 0; i < fields.Length; i++)
            {
                while (true)
                {
                    Console.Write($"{fields[i]}: ");
                    var input = Console.ReadLine();
                    if (Check(input))
                    {
                        fields[i] = input;
                        break;
                    }
                }
            }
            Console.Clear();
            return fields;
        }

        public static Array AddAnimal ()
        {
            Console.WriteLine("\tНеобходимо ввести данные животного\n");
            string[] fields = new string[] { "Имя", "Возраст", "Пол", "Вес" };
            for (int i = 0; i < fields.Length; i++)
            {
                while (true)
                {
                    Console.Write($"{fields[i]}: ");
                    var input = Console.ReadLine();
                    if (Check(input))
                    {
                        fields[i] = input;
                        break;
                    }
                }
            }
            Console.Clear();
            return fields;
        }

        public static bool Check(string Input)
        {
            if (string.IsNullOrWhiteSpace(Input))
            {
                Console.WriteLine("Ошибка, вы ввели пустую строку\n");
                return false;
            }
            return true;
        }
    }
}
