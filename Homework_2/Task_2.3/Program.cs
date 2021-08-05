using System;

/* Чечулин Денис
 *  
 * 3. 
 * 
 * С клавиатуры вводятся числа, пока не будет введен 0. 
 * Подсчитать сумму всех нечетных положительных чисел.
 * 
 */

namespace Task_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            double number;
            do
            {
                Console.Write("Введите число: ");
                number = double.Parse(Console.ReadLine());

                if ((int)number == number && number > 0 && number % 2 != 0)
                    sum += (int)number;
            }
            while (number != 0);

            Console.WriteLine($"Сумма нечётных чисел: {sum}");
        }
    }
}
