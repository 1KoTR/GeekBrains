using System;

/* Чечулин Денис
 *  
 * 4. 
 * 
 * Реализовать метод проверки логина и пароля. 
 * На вход метода подается логин и пароль. 
 * На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
 * С помощью цикла do while ограничить ввод пароля тремя попытками.
 * 
 */

namespace Task_2._4
{
    class Program
    {
        static string Login = "root";
        static string Password = "GeekBrains";

        static void Main(string[] args)
        {
            int counter = 3;
            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();

                Console.WriteLine();

                if (Verification(login, password))
                {
                    Console.WriteLine("Вы смогли войти!");
                    break;
                }
                counter--;
                Console.WriteLine($"Вы ввели неправильный логин или пароль!\nОсталось попыток: {counter}\n");
            }
            while (counter != 0);

            if (counter == 0)
                Console.WriteLine("Вы не смогли войти!\nВозвращайтесь в другой раз.");
        }

        static bool Verification(string login, string password)
        {
            if (login == Login && password == Password)
                return true;
            return false;
        }
    }
}
