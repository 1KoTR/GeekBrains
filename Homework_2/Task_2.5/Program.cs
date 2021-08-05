using System;

/* Чечулин Денис
 *  
 * 5. 
 * 
 * а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
 *    нужно ли человеку похудеть, набрать вес или всё в норме.
 * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 * 
 */

namespace Task_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Вашу массу (кг): ");
            double mass = double.Parse(Console.ReadLine());

            Console.Write("Введите Ваш рост (см): ");
            double height = double.Parse(Console.ReadLine()) / 100;

            double bmi = mass / (height * height);

            Console.WriteLine($"\nВаш индекс массы тела: {bmi:F2}\n");

            // а)
            double newBmi;
            if (bmi < 18.5)
            {
                newBmi = bmi - 18.5;
                Console.WriteLine("Вы худой!");
            }
            else if (bmi <= 25)
            {
                newBmi = 0;
                Console.WriteLine("Вы нормальный!");
            }
            else
            {
                newBmi = bmi - 25;
                Console.WriteLine("Вы толстый!");
            }

            // б)
            double newMass = newBmi * height * height;
            if (newBmi > 0)
                Console.WriteLine($"Вам следует похудеть на {newMass:F2} кг.");
            else if (newBmi < 0)
                Console.WriteLine($"Вам следует потолстеть на {-newMass:F2} кг.");
        }
    }
}
