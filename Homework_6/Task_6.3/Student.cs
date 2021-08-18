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
    class Student
    {
        /// <summary>
        /// Имя студента.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = StudentManager.GetValue(value, @"^[А-Я][а-я]+$"); }
        }
        private string _name;

        /// <summary>
        /// Фамилия студента.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set { _surname = StudentManager.GetValue(value, @"^[А-Я][а-я]+$"); }
        }
        private string _surname;

        /// <summary>
        /// Отчество студента.
        /// </summary>
        public string Patronymic
        {
            get { return _patronymic; }
            set { _patronymic = StudentManager.GetValue(value, @"^[А-Я][а-я]+$"); }
        }
        private string _patronymic;

        /// <summary>
        /// Полное имя студента.
        /// </summary>
        public string Fullname
        {
            get { return $"{_surname} {_name} {_patronymic}"; }
        }

        /// <summary>
        /// Возвраст студента.
        /// </summary>
        public int Age
        {
            get { return _age; }
            set { _age = int.Parse(StudentManager.GetValue(value.ToString(), @"^[\d]{1,3}$")); }
        }
        private int _age;

        /// <summary>
        /// Курс студента.
        /// </summary>
        public int Course
        {
            get { return _course; }
            set { _course = int.Parse(StudentManager.GetValue(value.ToString(), @"^[\d]$")); }
        }
        private int _course;

        public override string ToString()
        {
            return $"ФИО: {Fullname} | Возраст: {Age} | Курс: {Course}";
        }
    }
}
