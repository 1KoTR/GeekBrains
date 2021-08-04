using System;

/* Чечулин Денис
 *  
 * 2. 
 * 
 * Написать метод подсчета количества цифр числа.
 * 
 */

namespace Task_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 901230.000400012019m;

            Console.WriteLine($"Число: {a}");
            Console.WriteLine($"Его длина: {NumberLenght(a)}");
        }

        static int NumberLenght(decimal number)
        {
            int numberLenght = 0;

            long longNumber = (long)number;

            // Выносит цифры числа за запятую. Делает из decimal - long
            while (longNumber != number)
            {
                number *= 10;
                longNumber = (long)number;
            }

            // Считает количество цифр в числе.
            while (longNumber > 0)
            {
                longNumber /= 10;
                numberLenght++;
            }

            return numberLenght;
        }
    }
}
