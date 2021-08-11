using System;

/* Чечулин Денис
 *  
 * 3. 
 * 
 * а) Дописать класс для работы с одномерным массивом. 
 *    - Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом. 
 *    - Создать свойство Sum, которое возвращает сумму элементов массива.
 *    - Метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений). 
 *    - Метод Multi, умножающий каждый элемент массива на определённое число. 
 *    - Свойство MaxCount, возвращающее количество максимальных элементов.
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
            SingleDimensionalArray myArray = new SingleDimensionalArray(length: 10);
            Console.WriteLine(myArray);
            Console.WriteLine(myArray.Inverse());
            Console.WriteLine(myArray.Multi(2));
            myArray[0] = 123;
            myArray[2] = 123;
            Console.WriteLine(myArray.MaxValue);
            Console.WriteLine(myArray.MaxCount);
        }
    }
}
