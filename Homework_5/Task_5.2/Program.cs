using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

/* Чечулин Денис
 *  
 * 2. 
 * 
 * Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
 * а) Вывести только те слова сообщения, которые содержат не более n букв. + 
 * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ. + 
 * в) Найти самое длинное слово сообщения. + 
 * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения. + 
 * д) ***Создать метод, который производит частотный анализ текста. 
 *    В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
 *    Здесь требуется использовать класс Dictionary. +
 * 
 */

namespace Task_5._2
{
    static class Message
    {
        /// <summary>
        /// Упрощает заданный текст.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <returns>Возвращает упрощенный текст.</returns>
        public static string SimplifyText(string text)
        {
            return Regex.Replace(text, @"[^\sa-zа-я]", "", RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Убирает из текста все слова, которые больше заданной длины.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <param name="length">Максимальная длина.</param>
        /// <returns>Возвращает исправленый текст.</returns>
        public static string LimitWordLength(string text, int length)  // а)
        {
            string outText = "";
            string[] words = SimplifyText(text).Split();
            foreach (var word in words)
                if (word.Length <= length)
                    outText += $"{word} ";
            return outText;
        }

        /// <summary>
        /// Убирает из текста все слова, которые оканчиваются на заданный символ.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <param name="symbol">Символ.</param>
        /// <returns>Возвращает исправленый текст.</returns>
        public static string DeleteWords(string text, char symbol)  // б)
        {
            string outText = "";
            string[] words = SimplifyText(text).Split();
            foreach (var word in words)
                if (word != "" && word[word.Length - 1] != symbol)
                    outText += $"{word} ";
            return outText;
        }  

        /// <summary>
        /// Находит максимальную длину слова в тексте.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <returns>Возвращает максимальную длину слова в тексте.</returns>
        public static int MaxWordLength(string text)  // в)
        {
            int maxlength = 0;
            string[] words = SimplifyText(text).Split();
            foreach (var word in words)
            {
                int length = word.Length;
                if (maxlength < length)
                    maxlength = length;
            }
            return maxlength;
        }

        /// <summary>
        /// Создаёт слово из самый длинных слов текста.
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <returns>Возвращает слово из самый длинных слов текста.</returns>
        public static string CreateWord(string text)  // г)
        {
            StringBuilder sb = new StringBuilder();
            string[] words = SimplifyText(text).Split();
            int maxLength = MaxWordLength(text);
            foreach (var word in words)
                if (word.Length == maxLength)
                    sb.Append(word);
            return sb.ToString();
        }

        /// <summary>
        /// Подсчитывает количество слов из заданного массива в тексте. 
        /// </summary>
        /// <param name="text">Текст.</param>
        /// <param name="words">Массив слов.</param>
        /// <returns>Возвращает словарь с количеством слов.</returns>
        public static Dictionary<string, int> AmountsOfWords(string text, string[] words)  // Д)
        {
            string[] tWords = SimplifyText(text).ToLower().Split();

            var dictionary = new Dictionary<string, int>();
            foreach (var word in words)
            {
                dictionary.Add(word, 0);
                foreach (var tWord in tWords)
                    if (word == tWord)
                        dictionary[word]++;
            }
            return dictionary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "Это обычненький текст. Текст простенький и сожержит слова, чтобы было понятненько, что делает статический класс Message; Сегодня, кстати, 2021 год!";

            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine(Message.LimitWordLength(text, 6));
            Console.WriteLine();
            Console.WriteLine(Message.DeleteWords(text, 'о'));
            Console.WriteLine();
            Console.WriteLine($"Максимальная длинна слова: {Message.MaxWordLength(text)}");
            Console.WriteLine();
            Console.WriteLine(Message.CreateWord(text));
            Console.WriteLine();
            var dict = Message.AmountsOfWords(text, new string[] { "это", "что", "текст" });
            Console.WriteLine($"Количество слов \"текст\" в тексте: {dict["текст"]}");
        }
    }
}
