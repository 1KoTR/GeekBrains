using System;
using System.IO;

/* Чечулин Денис
 *  
 * 5. 
 * 
 * а) Реализовать библиотеку с классом для работы с двумерным массивом. 
 *    + Реализовать конструктор, заполняющий массив случайными числами. 
 *    + Создать методы, которые возвращают сумму всех элементов массива, 
 *    + сумму всех элементов массива больше заданного, 
 *    + свойство, возвращающее минимальный элемент массива, 
 *    + свойство, возвращающее максимальный элемент массива, 
 *    - метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out).
 * *б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
 * **в) Обработать возможные исключительные ситуации при работе с файлами.
 * 
 */

namespace TwoDimensionalArrayLib
{
    public class TwoDimensionalArray
    {
        public int this[int row, int column]
        {
            get { return TDArray[row, column]; }
            set { TDArray[row, column] = value; }
        }
        private int[,] TDArray;

        /// <summary>
        /// Количество рядов.
        /// </summary>
        public int Row { get; }
        /// <summary>
        /// Количество столбцов.
        /// </summary>
        public int Column { get; }
        /// <summary>
        /// Максимальное число.
        /// </summary>
        public int MaxValue
        { 
            get 
            {
                int max = int.MinValue;
                foreach (var num in TDArray)
                    if (max < num)
                        max = num;
                return max;
            } 
        }
        /// <summary>
        /// Минимальное число.
        /// </summary>
        public int MinValue
        {
            get
            {
                int min = int.MaxValue;
                foreach (var num in TDArray)
                    if (min > num)
                        min = num;
                return min;
            }
        }

        #region Конструкторы.

        /// <summary>
        /// Создает пустой двумерный массив.
        /// </summary>
        /// <param name="row">Количество рядов.</param>
        /// <param name="column">Количество столбцов.</param>
        public TwoDimensionalArray(int row, int column)
        {
            TDArray = new int[row, column];

            Row = row;
            Column = column;
        }

        /// <summary>
        /// Создает двумерный массив и заполняет все его элементы заданным числом.
        /// </summary>
        /// <param name="row">Количество рядов.</param>
        /// <param name="column">Количество столбцов.</param>
        /// <param name="num">Заданное число.</param>
        public TwoDimensionalArray(int row, int column, int num = 0) : this(row, column)
        {
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                    TDArray[i, j] = num;
        }

        /// <summary>
        /// Создает двумерный массив и заполняет его случайными числами в заданном диапозоне. 
        /// Максимальное число не входит в диапозн.
        /// </summary>
        /// <param name="row">Количество рядов.</param>
        /// <param name="column">Количество столбцов.</param>
        /// <param name="min">Минимальное число диапозона.</param>
        /// <param name="max">Максимально число диапозона.</param>
        public TwoDimensionalArray(int row, int column, int min, int max) : this(row, column)
        {
            Random rnd = new Random();
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                    TDArray[i, j] = rnd.Next(min, max);
        }

        /// <summary>
        /// Создаёт двумерный массив из файла.
        /// </summary>
        /// <param name="row">Количество рядов.</param>
        /// <param name="column">Количество столбцов.</param>
        /// <param name="path">Путь к файлу.</param>
        public TwoDimensionalArray(int row, int column, string path) : this(row, column)
        {
            LoadFrom(path);
        }

        #endregion

        #region Методы.

        /// <summary>
        /// Находит длину числа.
        /// </summary>
        /// <param name="num">Число.</param>
        /// <returns>Возвращает длину числа.</returns>
        public int NumberLength(int num)
        {
            int length = 0;
            while (num != 0)
            {
                num /= 10;
                length++;
            }
            return length;
        }

        /// <summary>
        /// Ищет иднекс заданного числа в массиве.
        /// </summary>
        /// <param name="num">Число.</param>
        /// <returns>Возвращает индекс заданного числа. Если число не было найдено, то возвращает -1.</returns>
        public int IndexOfNumber(int num)
        {
            int index = 0;
            foreach (var n in TDArray)
                if (num != n)
                    index++;
                else
                    break;
            return index >= TDArray.Length ? -1 : index;
        }

        /// <summary>
        /// Подсчитывает сумму всех элементов массива, которые больше заданного числа.
        /// </summary>
        /// <param name="min">Минимальное число суммы.</param>
        /// <returns>Возвращает сумму элементов массива.</returns>
        public int Sum(int min = int.MinValue)
        {
            int sum = 0;
            foreach (var num in TDArray)
                if (num > min)
                    sum += num;
            return sum;
        }

        /// <summary>
        /// Сохраняет массив в файл в виде строки или таблицы. 
        /// </summary>
        /// <param name="path">Путь к файлу.</param>
        /// <param name="inLine">Формат сохранения.</param>
        public void SaveTo(string path)
        {
            File.WriteAllText(path, ToString());
        }

        public void LoadFrom(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Файл не найден по заданному пути.");

            string[] strNums = File.ReadAllText(path).Split();

            int[] nums = new int[strNums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                string strNum = strNums[i];
                if (!int.TryParse(strNum, out int num))
                    throw new FormatException("Неккоректное значение в файле.");
                nums[i] = num;
            }
        }

        public override string ToString()
        {
            string text = "";
            for (int i = 0; i < TDArray.GetLength(0); i++)
            {
                for (int j = 0; j < TDArray.GetLength(1); j++)
                    text += $"{TDArray[i, j], 6}";
                text += "\n";
            }
            return text;
        }

        #endregion
    }
}
