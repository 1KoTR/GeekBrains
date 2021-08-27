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
    class Application
    {
        public void Run(Reflector reflector)
        {
            reflector.Serialize<DateTime>();
        }

        public void Stop()
        {
            Console.ReadKey(true);
            Environment.Exit(0);
        }
    }
}
