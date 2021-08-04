using System;

/* Чечулин Денис
 *  
 * 1. 
 * 
 * Написать метод, возвращающий минимальное из трёх чисел.
 * 
 */

namespace Task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.23;
            double b = 12332;
            double c = -1;

            Console.WriteLine($"Числа: {a} | {b} | {c}");
            Console.WriteLine($"Минимальное: {Min(a, b, c)}");
        }

        static double Min(double a, double b, double c)
        {
            if (a <= b && a <= c)
                return a;
            if (b <= a && b <= c)
                return b;
            return c;
        }
    }
}
