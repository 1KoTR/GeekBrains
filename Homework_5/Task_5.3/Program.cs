using System;
using System.Collections.Generic;
using System.Linq;

/* Чечулин Денис
 *  
 * 3. 
 * 
 * *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
 * Например: badc являются перестановкой abcd.
 * 
 */

namespace Task_5._3
{
    static class Text
    {
        /// <summary>
        /// Проверяет является ли одна строка первая перестановкой второй.
        /// </summary>
        /// <param name="firstLine">Первая строка.</param>
        /// <param name="secondLine">Вторая строка.</param>
        /// <returns>Возвращает истину, если строка является перестановкой, иначе ложь.</returns>
        static public bool IsPermutation(string firstLine, string secondLine)
        {
            if (SortLine(firstLine) == SortLine(secondLine))
                return true;
            return false;
        }

        /// <summary>
        /// Сортирует данную строку в порядки возрастания.
        /// </summary>
        /// <param name="line">Строка.</param>
        /// <returns>Возвращает отсортированную строку.</returns>
        static public string SortLine(string line)
        {
            char[] charArray = line.ToCharArray();
            Array.Sort(charArray);

            return new string(charArray);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = "/b-/фa=dcфыууу-4+=выa1-aф/9 s";
            string secondLine = "a 4aууb--ыу-+1фвффы==ca9///sd";
            
            if (Text.IsPermutation(firstLine, secondLine))
                Console.WriteLine("Перестановка!");
            else
                Console.WriteLine("Не перестановка!");
        }
    }
}
