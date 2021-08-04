using System;

/* Чечулин Денис
 * 
 * 3.
 * 
 * а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
 *    по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)). 
 *    Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
 * б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
 * 
 */

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату X первой точки: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y первой точки: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Введите координату X второй точки: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y второй точки: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // a) 

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"а) Расстояние между точками: {r:F2}");

            // б)

            Console.WriteLine($"б) Расстояние между точками: {Distance(x1, y1, x2, y2):F2}");
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result;
        }
    }
}
