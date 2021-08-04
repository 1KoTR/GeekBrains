using System;

/* Чечулин Денис
 * 
 * 5.
 * 
 * а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 * б) Сделать задание, только вывод организовать в центре экрана.
 * в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
 * 
 */

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Денис Чечулин (г. Зеленоградск)";
            int lineLenght = line.Length;

            // a)
            Console.WriteLine($"a) {line}");

            // б) и в)
            Console.WriteLine("а) и в)");

            PrintInCentre(line);

            Console.Read();
        }

        static void PrintInCentre(string ms)
        {
            int centreX = Console.WindowWidth / 2 - ms.Length / 2;
            int centreY = Console.WindowHeight / 2 - 1;

            Console.SetCursorPosition(centreX, centreY);
            Console.Write(ms);
        }
    }
}
