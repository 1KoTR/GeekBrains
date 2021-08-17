using System;
using System.Collections.Generic;
using System.Linq;

/* Чечулин Денис
 *  
 * 4. 
 * 
 * На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней школы. 
 * В первой строке сообщается количество учеников N, которое не меньше 10, но не превосходит 100, каждая из следующих N строк имеет следующий формат:
 *      <Фамилия> <Имя> <оценки>,
 * где <Фамилия> — строка, состоящая не более чем из 20 символов, 
 * <Имя> — строка, состоящая не более чем из 15 символов,
 * <оценки> — через пробел три целых числа, соответствующие оценкам по пятибалльной системе. 
 * <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом. Пример входной строки:
 *      Иванов Петр 4 5 3
 * Требуется написать как можно более эффективную программу, которая будет выводить на экран фамилии и имена трёх худших по среднему баллу учеников.
 * Если среди остальных есть ученики, набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
 * 
 */

namespace Task_5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int N = int.Parse(Console.ReadLine());

            string[] names = new string[N];
            float[] averageMarks = new float[N];
            for (int i = 0; i < N; i++)
            {
                string line = Console.ReadLine();

                int length = line.Length;
                int[] marks = ToInt(line[(length - 5)..].Split());

                names[i] = line[..(length - 6)];
                averageMarks[i] = (marks[0] + marks[1] + marks[2]) / 3f;
            }

            float[] tmpArray = new float[N];
            Array.Copy(averageMarks, tmpArray, N);
            Array.Sort(tmpArray);

            for (int i = 0; i < N; i++)
                if (averageMarks[i] == tmpArray[0] || averageMarks[i] == tmpArray[1] || averageMarks[i] == tmpArray[2])
                    Console.WriteLine(names[i]);
        }

        /// <summary>
        /// Делает из данного массива строк массив чисел.
        /// </summary>
        /// <param name="strArray">Массив строк.</param>
        /// <returns>Возвращает массив чисел.</returns>
        static int[] ToInt(string[] strArray)
        {
            int length = strArray.Length;
            int[] intArray = new int[length];
            for (int i = 0; i < length; i++)
                intArray[i] = int.Parse(strArray[i]);
            return intArray;
        }
    }
}
