using System;
using System.IO;

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
    static class StaticClass
    {
        /// <summary>
        /// Находит два подряд идущих элемента, только один из которых делится на 3.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Возвращает числа таких пар.</returns>
        public static int FindNumberOfPairs(int[] array)  // а)
        {
            int counter = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int firstNumber = array[i];
                int secondNumber = array[i + 1];
                if ((firstNumber % 3 == 0 && secondNumber % 3 != 0) || (secondNumber % 3 == 0 && firstNumber % 3 != 0))
                    counter++;
            }
            return counter;
        }

        /// <summary>
        /// Заполняет массив случайными числами или числами из файла.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="path"></param>
        public static int[] FillArray(int[] array, string path = "")
        {
            if (path == "")
            {
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                    array[i] = rnd.Next(-10_000, 10_001);
            }
            else
                array = LoadFrom(path);
            return array;
        }

        /// <summary>
        /// Получает строку чисел из массива.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>Возвращает строку чисел через пробел.</returns>
        public static string CreateLine(int[] array)
        {
            string line = "";
            foreach (var number in array)
                line += $"{number} ";
            return line[0..(line.Length - 1)];
        }

        /// <summary>
        /// Сохраняет массив чисел в файл.
        /// </summary>
        /// <param name="path"></param>
        public static void SaveTo(string path, string line)
        {
            File.WriteAllText(path, line);
        }

        /// <summary>
        /// Возвращет массив чисел из файла.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Возвращает массив чисел.</returns>
        public static int[] LoadFrom(string path)  // б)
        {
            if (!File.Exists(path))  // в)
                throw new Exception("Файл не найден.");

            string[] strArray = File.ReadAllText(path).Split();

            int length = strArray.Length;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
                array[i] = Convert.ToInt32(strArray[i]);
            return array;
        }
    }
}
