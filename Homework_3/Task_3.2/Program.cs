using System;

/* Чечулин Денис
 *  
 * 2. 
 * 
 * а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
 *    Требуется подсчитать сумму всех нечётных положительных чисел.
 *    Сами числа и сумму вывести на экран, используя tryParse.
 * 
 */

namespace Task_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number, counter = 0;
            do
            {
                counter++;
                number = GetNumber($"Введите число №{counter}: ", "Неверное значение!");
                if (number % 2 != 0)
                    sum += number;

            } while (number != 0);
            Console.WriteLine($"Сумма нечётных чисел: {sum}");
        }

        static int GetNumber(string text = "", string msg = "")
        {
            int number = 0;
            while (true)
            {
                Console.Write(text);
                if (int.TryParse(Console.ReadLine(), out number))
                    return number;
                else
                    Console.WriteLine($"{msg}");
            }
        }
    }
}
