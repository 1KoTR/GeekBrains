using System;

/* Чечулин Денис
 *  
 * 6. 
 * 
 * *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
 * «Хорошим» называется число, которое делится на сумму своих цифр. 
 * Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
 * 
 */

namespace Task_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            int startTime = dateTime.Minute * 60 * 1000 + dateTime.Second * 1000 + dateTime.Millisecond;

            int counter = 0;
            for (int number = 1; number <= 1_000_000_000; number++)
            {
                if (number == Sum(number))
                    counter++;
            }

            dateTime = DateTime.Now;
            int endTime = dateTime.Minute * 60 * 1000 + dateTime.Second * 1000 + dateTime.Millisecond;

            Console.WriteLine($"Количество \"хороших\" числе: {counter}\n");

            Console.WriteLine($"Программа работала {endTime - startTime} мс.");
        }

        static int Sum(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
