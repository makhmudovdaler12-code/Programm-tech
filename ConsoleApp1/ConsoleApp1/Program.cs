using System.Collections.Generic;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // Коллекция базового типа — сюда кладём разных наследников.
            List<Component> components = new List<Component>
            {
                new CPU("INT-I9", "Intel i9", 50000m, 8),
                new RAM("KNG-32", "Kingston 32GB", 12000m, 32)
            };

            // Перебираем по одному и печатаем отчёт.
            foreach (Component c in components)
            {
                // Шапка: [CPU] Intel i9, 50000, type: CPU
                Console.WriteLine(c.ToString());

                // Цена с налогом
                Console.WriteLine($"  price with tax: {c.PriceWithTax}");

                // Установка (полиморфный вызов — каждый наследник сам знает как)
                c.Install();

                // Проверяем, умеет ли объект разгоняться
                if (c is IOverclockable oc)
                {
                    // Да, умеет — вызываем
                    oc.Overclock();
                }
                else
                {
                    // Нет — сообщаем
                    Console.WriteLine($"{c.Model} cannot be overclocked.");
                }

                // Разделитель
                Console.WriteLine(new string('-', 40));

            }
        }
    }
}