using System;

/* Чечулин Денис
 * 
 * 4.
 * 
 * Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
 * а) с использованием третьей переменной;
 * б) *без использования третьей переменной.
 * 
 */

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // а)
            Console.WriteLine("a)");

            int a1 = 5;
            int b1 = 21;

            Console.WriteLine($" - Сейчас:\ta = {a1}\tb = {b1}");

            int tmpA1 = a1;
            a1 = b1;  // 5
            b1 = tmpA1;  // 21

            Console.WriteLine($" - Теперь:\ta = {a1}\tb = {b1}");

            Console.WriteLine();

            // б)
            Console.WriteLine("б)");

            int a2 = 2;
            int b2 = 9;

            Console.WriteLine($" - Сейчас:\ta = {a2}\tb = {b2}");

            a2 += b2;  // 11
            b2 = -(b2 - a2);  // 2
            a2 -= b2;  // 9

            Console.WriteLine($" - Теперь:\ta = {a2}\tb = {b2}");
        }
    }
}
