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
    interface IReflector
    {
        void Serialize<T>();
        void Deserialize();
    }
}
