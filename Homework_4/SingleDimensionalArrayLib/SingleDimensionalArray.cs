using System;
using System.Collections.Generic;
using System.Text;

/* Чечулин Денис
 *  
 * 3. 
 * 
 * а) Дописать класс для работы с одномерным массивом. 
 *    + Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
 *    + Создать свойство Sum, которое возвращает сумму элементов массива.
 *    + Метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений). 
 *    + Метод Multi, умножающий каждый элемент массива на определённое число. 
 *    + Свойство MaxCount, возвращающее количество максимальных элементов.
 * б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
 * в) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
 * 
 */

namespace Task_4._3
{
    public class SingleDimensionalArray
    {
        private int[] SDArray;

        public int this[int index]
        {
            get { return SDArray[index]; }
            set { SDArray[index] = value; }
        }

        /// <summary>
        /// Длина массива.
        /// </summary>
        public int Length { get; }
        /// <summary>
        /// Количество наибольших чисел.
        /// </summary>
        public int MaxCount 
        {
            get { return AmountOfElements[MaxValue]; } 
        }
        /// <summary>
        /// Наибольшее число.
        /// </summary>
        public int MaxValue 
        {
            get 
            {
                int max = int.MinValue;
                foreach (var number in SDArray)
                    if (max < number)
                        max = number;
                return max;
            } 
        }
        /// <summary>
        /// Возвращает количество элементов массива, равных заданному числу.
        /// </summary>
        public Dictionary<int, int> AmountOfElements
        {
            get 
            {
                var elements = new Dictionary<int, int>();
                foreach (var number in SDArray)
                    if (elements.ContainsKey(number))
                        elements[number]++;
                    else
                        elements.Add(number, 1);
                return elements; 
            }
        }

        /// <summary>
        /// Создаёт одномерный массив и заполняет его числами от начального значения с заданным шагом.
        /// </summary>
        /// <param name="length">Длина массива.</param>
        /// <param name="start">Начальное значение.</param>
        /// <param name="step">Шаг.</param>
        public SingleDimensionalArray(int length, int start = 0, int step = 1)
        {
            SDArray = new int[length];
            for (int i = 0; i < length; i++)
                SDArray[i] = start + i * step;

            Length = length;
        }

        /// <summary>
        /// Суммирует все числа массива.
        /// </summary>
        /// <returns>Возвращает сумму чисел массива.</returns>
        public int Sum()
        {
            int sum = 0;
            foreach (var number in SDArray)
                sum += number;
            return sum;
        }

        /// <summary>
        /// Умножает все числа массива на заданный множитель.
        /// </summary>
        /// <param name="factor">Множитель.</param>
        /// <returns>Возвращает копию массива с умноженными значениями.</returns>
        public SingleDimensionalArray Multi(int factor)
        {
            SingleDimensionalArray array = new SingleDimensionalArray(Length);
            for (int i = 0; i < Length; i++)
                array[i] = SDArray[i] * factor;
            return array;
        }

        /// <summary>
        /// Изменяет знак всем числам массива.
        /// </summary>
        /// <returns>Возвращает копию массива с инверсированными значениями.</returns>
        public SingleDimensionalArray Inverse()
        {
            SingleDimensionalArray array = new SingleDimensionalArray(Length);
            for (int i = 0; i < Length; i++)
                array[i] = -SDArray[i];
            return array;
        }

        public override string ToString()
        {
            string line = "";
            foreach (var number in SDArray)
                line += $"{number} ";
            return line[0..(line.Length - 1)];
        }
    }
}
