using System;
using System.Reflection;

/* Чечулин Денис
 *  
 * 1. 
 * 
 * С помощью рефлексии выведите все свойства структуры DateTime.
 * 
 */

namespace Task_8._1
{
    public class Reflector : IReflector
    {

        /// <summary>
        /// Выводит все свойства данной структуры.
        /// </summary>
        /// <typeparam name="T">Тип структуры.</typeparam>
        public void Serialize<T>()
        {
            Console.WriteLine($"Все свойства структуры {typeof(T).ToString().Split(".")[^1]}:");   
            var items = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            foreach (var item in items)
                Console.WriteLine($" - {item.Name}");
        }

        public void Deserialize()
        {
            throw new Exception("Не лезь сюда!");
        }
    }
}
