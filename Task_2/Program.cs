using System;

/* Чечулин Денис
 * 
 * 2. 
 * 
 * Ввести вес и рост человека.
 * Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
 * где m — масса тела в килограммах, h — рост в метрах.
 * 
 */

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            double imt = weight / (height * height);

            Console.WriteLine($"Ваш индекс массы тела (ИМТ): {imt}");
        }
    }
}
