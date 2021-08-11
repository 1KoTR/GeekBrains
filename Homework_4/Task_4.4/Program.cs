using System;
using System.IO;
using Newtonsoft.Json;

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
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("Account.json");

            Console.WriteLine($"\n{account}");
        }
    }
}
