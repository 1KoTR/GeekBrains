using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
    static class StudentManager
    {
        /// <summary>
        /// Список студентов.
        /// </summary>
        private static List<Student> StudentsList = new List<Student>();

        /// <summary>
        /// Добавляет студента в общий список.
        /// </summary>
        /// <param name="student">Студент.</param>
        public static void AddStudent(Student student)
        {
            StudentsList.Add(student);
        }

        /// <summary>
        /// Возвращает список студентов.
        /// </summary>
        /// <param name="studentsList">Список сдутентов.</param>
        /// <returns>Возвращает список студентов.</returns>
        public static List<Student> GetStudentsList(List<Student> studentsList = null)
        {
            if (studentsList != null)
                return studentsList;
            return StudentsList;
        }
        /// <summary>
        /// Возвращает список студентов соответствующих заданым значениям.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="value">Значение.</param>
        /// <param name="studentsList">Список сдутентов.</param>
        /// <returns>Возвращает список студентов.</returns>
        public static List<Student> GetStudentsList(string key, int value, List<Student> studentsList = null)
        {
            studentsList = GetStudentsList(studentsList);
            List<Student> outStudentsList = new List<Student>();
            switch (key)
            {
                case "age":
                    foreach (var student in studentsList)
                    {
                        if (value == student.Age)
                            outStudentsList.Add(student);
                    }
                    break;
                case "course":
                    foreach (var student in studentsList)
                    {
                        if (value == student.Course)
                            outStudentsList.Add(student);
                    }
                    break;
                default:
                    throw new Exception($"Неккоректный ключ: {key}");
            }
            return outStudentsList;
        }
        /// <summary>
        /// Возвращает список студентов соответствующих заданым значениям.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="start">начальное значение.</param>
        /// <param name="end">Конечное значение.</param>
        /// <param name="studentsList">Список сдутентов.</param>
        /// <returns>Возвращает список студентов.</returns>
        public static List<Student> GetStudentsList(string key, int start, int end, List<Student> studentsList = null)
        {
            studentsList = GetStudentsList(studentsList);
            List<Student> outStudentsList = new List<Student>();
            switch (key)
            {
                case "age":
                    foreach (var student in studentsList)
                    {
                        int age = student.Age;
                        if (start <= age && age <= end)
                            outStudentsList.Add(student);
                    }
                    break;
                case "course":
                    foreach (var student in studentsList)
                    {
                        int course = student.Course;
                        if (start <= course && course <= end)
                            outStudentsList.Add(student);
                    }
                    break;
                default:
                    throw new Exception($"Неккоректный ключ: {key}");
            }
            return outStudentsList;
        }
        /// <summary>
        /// Возвращает список студентов соответствующих заданым значениям.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="line">Начало строки.</param>
        /// <param name="studentsList">Список сдутентов.</param>
        /// <returns>Возвращает список студентов.</returns>
        public static List<Student> GetStudentsList(string key, string line, List<Student> studentsList = null)
        {
            studentsList = GetStudentsList(studentsList);
            List<Student> outStudentsList = new List<Student>();
            switch (key)
            {
                case "name":
                    foreach (var student in studentsList)
                        if (student.Name.StartsWith(line))
                            outStudentsList.Add(student);
                    break;
                case "surname":
                    foreach (var student in studentsList)
                        if (student.Surname.StartsWith(line))
                            outStudentsList.Add(student);
                    break;
                case "patronymic":
                    foreach (var student in studentsList)
                        if (student.Patronymic.StartsWith(line))
                            outStudentsList.Add(student);
                    break;
                default:
                    throw new Exception($"Неккоректный ключ: {key}");
            }
            return outStudentsList;
        }

        /// <summary>
        /// Возвращает словарь студентов содержащий ключ и количество студентов с этим ключем.
        /// </summary>
        /// <param name="key">Ключ.</param>
        /// <param name="studentsList">Список сдутентов.</param>
        /// <returns></returns>
        public static Dictionary<int, int> GetStudentsDictionary(string key, List<Student> studentsList = null)
        {
            var dictionary = new Dictionary<int, int>();
            switch (key)
            {
                case "age":
                    foreach (var student in GetStudentsList(studentsList))
                    {
                        int age = student.Age;
                        if (dictionary.ContainsKey(age))
                            dictionary[age]++;
                        else
                            dictionary[age] = 1;
                    }
                    break;
                case "course":
                    foreach (var student in GetStudentsList(studentsList))
                    {
                        int course = student.Course;
                        if (dictionary.ContainsKey(course))
                            dictionary[course]++;
                        else
                            dictionary[course] = 1;
                    }
                    break;
                default:
                    throw new Exception($"Неккоректный ключ: {key}");
            }
            return dictionary;
        }

        /// <summary>
        /// Сортирует список студентов по заданному ключу.
        /// </summary>
        /// <param name="key">Ключ.</param>
        public static void SortStudentsList(string key)
        {
            List<Student> studentsList = GetStudentsList();
            Student tmpStudent;
            int length = studentsList.Count;
            switch (key)
            {
                case "age":
                    for (int i = 0; i < length; i++)
                        for (int j = i + 1; j < length; j++)
                            if (studentsList[i].Age + studentsList[i].Course > studentsList[j].Age + studentsList[j].Course)
                            {
                                tmpStudent = studentsList[i];
                                studentsList[i] = studentsList[j];
                                studentsList[j] = tmpStudent;
                            }
                    break;
                case "course":
                    for (int i = 0; i < length; i++)
                        for (int j = i + 1; j < length; j++)
                            if (studentsList[i].Course > studentsList[j].Course)
                            {
                                tmpStudent = studentsList[i];
                                studentsList[i] = studentsList[j];
                                studentsList[j] = tmpStudent;
                            }
                    break;
                default:
                    throw new Exception($"Неккоректный ключ: {key}");
            }
        }

        /// <summary>
        /// Создаёт студента из заданных значений.
        /// </summary>
        /// <param name="name">Имя студента.</param>
        /// <param name="surname">Фамилия студента.</param>
        /// <param name="patronymic">Отчество студента.</param>
        /// <param name="age">Возраст студента.</param>
        /// <param name="course">Курс студента.</param>
        /// <returns>Возвращает студента.</returns>
        public static Student CreateStudent(string name, string surname, string patronymic, int age, int course)
        {
            Student student = new Student() 
            {
                Name = name,
                Surname = surname,
                Patronymic = patronymic,
                Age = age,
                Course = course
            };
            AddStudent(student);
            return student;
        }

        /// <summary>
        /// Проверяет соответствие значения заданному регулярному выражению.
        /// При несоответствии выдаёт исключение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="pattern">Регулярное выражение.</param>
        /// <returns>Возвращает значение.</returns>
        public static string GetValue(string value, string pattern)
        {
            if (!new Regex(pattern).IsMatch(value))
                throw new Exception($"Неккоректное значение: {value}");
            return value;
        }

        /// <summary>
        /// Создаёт строку со всем списком студентов для вывода.
        /// </summary>
        /// <param name="studentsList">Список студентов.</param>
        /// <returns>Возвращает строку.</returns>
        public static string PrintStudentsList(List<Student> studentsList = null)
        {
            string line = "";
            studentsList = GetStudentsList(studentsList);
            for (int i = 0; i < studentsList.Count; i++)
                line += $"{i + 1}.\t{studentsList[i]}\n";
            return line;
        }
    }
}
