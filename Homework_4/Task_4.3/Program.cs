using System;

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
    class Program
    {
        static void Main(string[] args)
        {
            SingleDimensionalArray myArray = new SingleDimensionalArray(length: 15, start: 10, step: 3);

            myArray[0] = 1;
            myArray[6] = 1;
            myArray[1] = 123;
            myArray[3] = 123;
            myArray[5] = -123;

            Console.WriteLine($"Начальный массив: {myArray}");
            Console.WriteLine();
            Console.WriteLine($"Маrcимальное число: {myArray.MaxValue}");
            Console.WriteLine($"Количество таких чисел: {myArray.MaxCount}");
            Console.WriteLine();
            Console.WriteLine($"Количество элементов массива, равных второму элементу: {myArray.AmountOfElements[myArray[1]]}");
            Console.WriteLine();
            Console.WriteLine($"Сумма всех чисел: {myArray.Sum()}");
            Console.WriteLine();
            Console.WriteLine($"Копия начального массива, но числа умножены на 3: {myArray.Multi(3)}");
            Console.WriteLine($"Копия начального массива, но числа поменяли свой знак: {myArray.Inverse()}");
        }
    }
}
