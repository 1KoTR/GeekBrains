using System;

/* Чечулин Денис
 *  
 * 1. 
 * 
 * С помощью рефлексии выведите все свойства структуры DateTime.
 * 
 */

namespace Task_8._1
{
    interface IReflection
    {
        void Serialize();
        void Deserialize();
    }

    class Reflection : IReflection
    {
        public void Serialize()
        {

        }

        public void Deserialize()
        {
            throw new Exception("Не лезь сюда!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
