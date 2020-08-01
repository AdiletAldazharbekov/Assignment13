
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment13
{
    class Operation
    {
        public static int MainOperation()
        {
            Console.WriteLine("Выберите действие" +
                "\n\t1. Добавить лошадь" +
                "\n\t2. Добавить корову" +
                "\n\t3. Добавить овцу" +
                "\n\t4. Информация о ферме" +
                "\n\tВыход любая другая клавиша");

            var input = Console.ReadLine();
            int.TryParse(input, out int oper);
            Console.Clear();
            return oper;
        }

        public static Array Registration()
        {
            Console.WriteLine("\n\tДля начала нужно создать ферму, введите следующие данные");
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
            string[] fields = new string[] { "Имя", "Возраст", "Пол", "Вес","Корм" };
            for (int i = 0; i < fields.Length; i++)
            {
                while (true)
                {
                    Console.Write($"{fields[i]}: ");
                    var input = Console.ReadLine();

                    if (i==1 || i==3)
                    {
                        if (CheckInt(input))
                        {
                            fields[i] = input;
                            break;
                        }
                    }
                    else
                    {
                        if (Check(input))
                        {
                            fields[i] = input;
                            break;
                        }
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

        public static bool CheckInt(string Input)
        {
            int.TryParse(Input, out int result);

            if (result==0)
            {
                Console.WriteLine("Ошибка, вы ввели пустую строку или буквенные значения\n");
                return false;
            }
            return true;
        }
    }
}
