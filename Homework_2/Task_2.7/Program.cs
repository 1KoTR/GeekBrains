using System;

/* Чечулин Денис
 *  
 * 7. 
 * 
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
 * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 * 
 */

namespace Task_2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursion(1, 30);
        }

        static void Recursion(int a, int b)
        {
            Console.Write($"{a} ");
            if (a < b)
                Recursion(++a, b);
        }
    }
}
