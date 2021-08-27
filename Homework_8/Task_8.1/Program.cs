/* Чечулин Денис
 *  
 * 1. 
 * 
 * С помощью рефлексии выведите все свойства структуры DateTime.
 * 
 */

namespace Task_8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var application = new Application();
            var reflector = new Reflector();
            application.Run(reflector);
            application.Stop();
        }
    }
}
