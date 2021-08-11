using System;

/* Чечулин Денис
 *  
 * 1. 
 * 
 * Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
 * Заполнить случайными числами. 
 * Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3. 
 * В данной задаче под парой подразумевается два подряд идущих элемента массива.
 * 
 * Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
 * 
 */

namespace Task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20];

            myArray = Fill(myArray);
            Print(myArray);
            Console.WriteLine($"\nКоличество пар: {Check(myArray)}");
        }

        static int[] Fill(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-10_000, 10_001);
            return array;
        }

        static int Check(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int num1 = array[i];
                int num2 = array[i + 1];
                if ((num1 % 3 == 0 && num2 % 3 != 0) || (num2 % 3 == 0 && num1 % 3 != 0))
                    counter++;
            }
            return counter;
        }

        static void Print(int[] array)
        {
            Console.Write("Массив: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");
            Console.WriteLine();
        }
    }
}
