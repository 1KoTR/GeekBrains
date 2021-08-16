using System;
using System.Text.RegularExpressions;

/* Чечулин Денис
 *  
 * 1. 
 * 
 * Создать программу, которая будет проверять корректность ввода логина. 
 * Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
 *  - длина: [2, 10]
 *  - буквы латинского алфавита (a-z, A-Z) или цифры (0-9).
 *  - цифра не в начале.
 * а) без использования регулярных выражений;
 * б) **с использованием регулярных выражений.
 * 
 */

namespace Task_5._1
{
    class Account
    {
        public string Login { get; }

        public Account()
        {
            while (true)
            {
                Console.Write("Введите логин: ");
                Login = Console.ReadLine();
                if (NewValidation(Login))
                {
                    CreateAccount();
                    break;
                }
                else
                    Console.WriteLine("Логин некорректный!\n");
            }
        }

        private bool OldValidation(string line)  // а)
        {
            string alphabet = "0123456789abcdefghijklmnopqrstuvwxyz";

            int length = line.Length;
            if ((length >= 2 && length <= 10) && !alphabet[0..10].Contains(line[0]))
            {
                for (int i = 1; i < length; i++)
                    if (!alphabet.Contains(line[i]))
                        return false;
                return true;
            }
            return false;
        }

        private bool NewValidation(string line)  // б)
        {
            int length = line.Length;
            Regex regex = new Regex(@"^[a-z][\da-z]{1,9}$", RegexOptions.IgnoreCase);
            if (regex.IsMatch(line))
                return true;
            return false;
        }

        private void CreateAccount()
        {
            Console.WriteLine("Аккаунт успешно создан!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создайте аккаунт.\n");

            Account account = new Account();
        }
    }
}
