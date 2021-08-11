using System;

/* Чечулин Денис
 *  
 * 2. 
 * 
 * Реализуйте задачу 1 в виде статического класса StaticClass;
 * а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
 * б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
 * в)*Добавьте обработку ситуации отсутствия файла на диске.
 * 
 */

namespace Task_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20];
            myArray = StaticClass.FillArray(myArray);

            string line = StaticClass.CreateLine(myArray);
            StaticClass.SaveTo("Array.txt", line);

            Console.WriteLine($"Массив: {line}");
            Console.WriteLine($"Количество пар: {StaticClass.FindNumberOfPairs(myArray)}");
        }
    }
}
