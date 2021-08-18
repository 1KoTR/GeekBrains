using System;

/* Чечулин Денис
 *  
 * 3. 
 * 
 * Переделать программу Пример использования коллекций для решения следующих задач:
 * а) Подсчитать количество студентов учащихся на 5 и 6 курсах; +
 * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив); + 
 * в) отсортировать список по возрасту студента; +
 * г) *отсортировать список по курсу и возрасту студента; +
 * 
 */

namespace Task_6._1
{
    class Application
    {
        /// <summary>
        /// Зпускает приложение.
        /// </summary>
        public void Start()
        {
            var student1 = StudentManager.CreateStudent("Денис", "Чечулин", "Евгеньевич", 19, 6);
            var student2 = StudentManager.CreateStudent("Одло", "Бджло", "Вдлорм", 18, 6);
            var student3 = StudentManager.CreateStudent("Щблоти", "Адлорс", "Вдщормри", 17, 4);
            var student4 = StudentManager.CreateStudent("Сдлор", "Пшгсотч", "Тжалпождлоап", 20, 5);
            var student5 = StudentManager.CreateStudent("Клор", "Ямгшо", "Едлослдро", 21, 6);

            Console.WriteLine($"Количество студентов на 5 и 6 курсах: {StudentManager.GetStudentsList("course", 5, 6).Count}\n");  // а)

            int start = 18, end = 20;
            int course = 6;
            var list = StudentManager.GetStudentsList("age", start, end);
            Console.WriteLine($"Количество студентов в возрасте от {start} до {end} лет на {course} курсе: {StudentManager.GetStudentsDictionary("course", list)[course]}\n");  // б)

            Console.WriteLine($"Список студентов:\n" +
                              $"{StudentManager.PrintStudentsList()}\n");

            StudentManager.SortStudentsList("age");  // в)
            Console.WriteLine($"Отсортированный по возрасту список студентов:\n" +
                              $"{StudentManager.PrintStudentsList()}\n");

            StudentManager.SortStudentsList("course");  // г)
            Console.WriteLine($"Отсортированный по курсу и возрасту список студентов:\n" +
                              $"{StudentManager.PrintStudentsList()}\n");
        }

        /// <summary>
        /// Закрывает приложение.
        /// </summary>
        public void Close()
        {
            Environment.Exit(0);
        }
    }
}
