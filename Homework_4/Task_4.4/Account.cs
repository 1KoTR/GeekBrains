using Newtonsoft.Json;
using System;
using System.IO;

/* Чечулин Денис
 *  
 * 4. 
 * 
 * Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. 
 * Создайте структуру Account, содержащую Login и Password.
 * 
 */

namespace Task_4._4
{
    struct Account
    {
        /// <summary>
        /// Логин от аккаутна.
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль от аккаунта.
        /// </summary>
        public string Password { get; set; }

        public Account(string path)
        {
            Login = "";
            Password = "";

            if (!File.Exists(path))
                CreateAccountFile(path);
            else
                LoadFrom(path);

            if (Login != "" && Verification(path))
                Console.WriteLine("\nВы успешно вошли в аккаунт!");
            else
                Console.WriteLine("\nВы не вошли в аккаунт.");
        }

        /// <summary>
        /// Запрашивает логин и пароль для доступа к аккаунту.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <returns></returns>
        bool Verification(string path)
        {
            int attempts = 3;
            while (attempts > 0)
            {
                Console.WriteLine("\nВход в аккаунт.");
                Console.WriteLine($"Осталось попыток: {attempts}\n");
                Console.Write("Введите Ваш логин: ");
                string login = Console.ReadLine();
                Console.Write("Введите Ваш пароль: ");
                string password = Console.ReadLine();

                if (login == Login && password == Password)
                    return true;

                attempts--;
            }
            return false;
        }

        /// <summary>
        /// Создаёт файл с логином и паролем.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        void CreateAccountFile(string path)
        {
            Console.WriteLine("\nАккаунта нет.");
            while (true)
            {
                Console.Write("\nСоздать аккаунт?\nОтвет (Да/Нет): ");
                string answer = Console.ReadLine();
                if (answer == "Да")
                {
                    while (Login == "")
                    {
                        Console.Write("\nВведите логин: ");
                        Login = Console.ReadLine();
                    }
                    while (Password == "")
                    {
                        Console.Write("Введите пароль: ");
                        Password = Console.ReadLine();
                    }
                    SaveTo(path);

                    break;
                }
                else if (answer == "Нет")
                {
                    Console.WriteLine("\nАккаунт не будет создан.");
                    break;
                }
                else
                    Console.WriteLine("\nВведен некорректный ответ.");
            }
        }

        /// <summary>
        /// Сохряняет логин и пароль в файл.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        void SaveTo(string path)
        {
            var json = JsonConvert.SerializeObject(this);
            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Загружает логин и пароль из файла.
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        void LoadFrom(string path)
        {
            this = JsonConvert.DeserializeObject<Account>(File.ReadAllText(path));
        }

        public override string ToString()
        {
            return $"Логин: {Login}\nПароль: {Password}";
        }
    }
}
