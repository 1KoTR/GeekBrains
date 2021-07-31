using System;

/* Чечулин Денис
 * 
 * 1. 
 * 
 * Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
 * В результате вся информация выводится в одну строчку:
 * а) используя склеивание;
 * б) используя форматированный вывод;
 * в) используя вывод со знаком $.
 * 
 */

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует программа «Анкета»");

            Console.Write("Введите Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите Вашу фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Ваш рост: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите Ваш вес: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("а)" + " Name: " + name + " | Surname: " + surname + " | Age: " + age + " | Height: " + height + " | Weight: " + weight);
            Console.WriteLine("б) Name: {0} | Surname: {1} | Age: {2} | Height: {3} | Weight: {4}", name, surname, age, height, weight);
            Console.WriteLine($"в) Name: {name} | Surname: {surname} | Age: {age} | Height: {height} | Weight: {weight}");
        }
    }
}
