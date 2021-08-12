using System;
using TwoDimensionalArrayLib;

/* Чечулин Денис
 *  
 * 5. 
 * 
 * а) Реализовать библиотеку с классом для работы с двумерным массивом. 
 *    + Реализовать конструктор, заполняющий массив случайными числами. 
 *    + Создать методы, которые возвращают сумму всех элементов массива, 
 *    + сумму всех элементов массива больше заданного, 
 *    + свойство, возвращающее минимальный элемент массива, 
 *    + свойство, возвращающее максимальный элемент массива, 
 *    - метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
 * *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 * **в) Обработать возможные исключительные ситуации при работе с файлами.
 * 
 */

namespace Task_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDimensionalArray myArray = new TwoDimensionalArray(row: 5, column: 10, min: -100, max: 101);

            Console.WriteLine("Начальный массив: ");
            Console.WriteLine(myArray);

            myArray.SaveTo("myArray1.txt");

            Console.WriteLine($"Длина массива: {myArray.Length}");
            Console.WriteLine();
            Console.WriteLine($"Минимальное число: {myArray.MinValue}");
            Console.WriteLine($"Максимальное число: {myArray.MaxValue}");
            Console.WriteLine();
            Console.WriteLine($"Индекс числа {myArray.MaxValue}: {myArray.IndexOfNumber(myArray.MaxValue, out int index)}");
            Console.WriteLine($"Индекс числа {myArray.MaxValue}: {index}");
            Console.WriteLine();
            Console.WriteLine($"Сумма чисел, которые больше 50: {myArray.Sum(50)}");
            Console.WriteLine();

            var myArrrayFromFile = new TwoDimensionalArray(row: 6, column: 15);
            myArrrayFromFile.LoadFrom("myArray.txt");

            Console.WriteLine("Массив из файла: ");
            Console.WriteLine(myArrrayFromFile);
        }
    }
}
