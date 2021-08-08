using System;

/* Чечулин Денис
 *  
 * 1. 
 * 
 * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 * в) Добавить диалог с использованием switch демонстрирующий работу класса.
 * 
 */

namespace Task_3._1
{
    struct StructComplex
    {
        readonly double a, b;

        public StructComplex(double re = 0, double im = 0)
        {
            a = re;
            b = im;
        }

        #region Операторы

        public static StructComplex operator +(StructComplex x, StructComplex y)
        {
            return new StructComplex(re: x.a + y.a, im: x.b + y.b);
        }

        public static StructComplex operator -(StructComplex x)
        {
            return new StructComplex(re: -x.a, im: -x.b);
        }

        public static StructComplex operator -(StructComplex x, StructComplex y)
        {
            return new StructComplex(re: x.a - y.a, im: x.b - y.b);
        }

        #endregion

        public override string ToString()
        {
            if (a == 0 && b == 0)
                return "0";
            if (a == 0)
                return b > 0 ? $"{b}i" : $"{b}i";
            if (b == 0)
                return $"{a}";
            return b > 0 ? $"{a} + {b}i" : $"{a} - {-b}i";
        }
    }

    class ClassComplex
    {
        readonly public double a, b;

        public ClassComplex(double re = 0, double im = 0)
        {
            a = re;
            b = im;
        }

        #region Операторы

        public static ClassComplex operator +(ClassComplex x, ClassComplex y)
        {
            return new ClassComplex(re: x.a + y.a, im: x.b + y.b);
        }

        public static ClassComplex operator -(ClassComplex x)
        {
            return new ClassComplex(re: -x.a, im: -x.b);
        }

        public static ClassComplex operator -(ClassComplex x, ClassComplex y)
        {
            return new ClassComplex(re: x.a - y.a, im: x.b - y.b);
        }

        public static ClassComplex operator *(ClassComplex x, ClassComplex y)
        {
            return new ClassComplex(re: x.a * y.a - x.b * y.b, im: x.b * y.a + x.a * y.b);
        }

        public static ClassComplex operator /(ClassComplex x, ClassComplex y)
        {
            return new ClassComplex(re: (x.a * y.a + x.b * y.b) / (y.a * y.a + y.b * y.b), im: (x.b * y.a - x.a * y.b) / (y.a * y.a + y.b * y.b));
        }

        #endregion

        public override string ToString()
        {
            if (a == 0 && b == 0)
                return "0";
            if (a == 0)
                return b > 0 ? $"{b}i" : $"{b}i";
            if (b == 0)
                return $"{a}";
            return b > 0 ? $"{a} + {b}i" : $"{a} - {-b}i";
        }
    }

    class Numbers
    {
        public static double GetNumber(string text = "", string msg = "")
        {
            double number = 0;
            while (true)
            {
                Console.Write(text);
                if (double.TryParse(Console.ReadLine(), out number))
                    return number;
                else
                    Console.WriteLine($"{msg}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // а)
            StructComplex sX = new StructComplex(3, 2);
            StructComplex sY = new StructComplex(13, 22);
            Console.WriteLine($"sX = {sX}\nsY = {sY}\n");

            Console.WriteLine($"-sX = {-sX}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"sX + sY = {sX + sY}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"sX - sY = {sX - sY}");
            Console.WriteLine($"sY - sX = {sY - sX}");

            Console.WriteLine("\n--------------------\n");

            // б)
            ClassComplex cX = new ClassComplex(2, 4);
            ClassComplex cY = new ClassComplex(14, 17);
            Console.WriteLine($"cX = {cX}\ncY = {cY}\n");

            Console.WriteLine($"-cX = {-cX}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"cX + cY = {cX + cY}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"cX - cY = {cX - cY}");
            Console.WriteLine($"cY - cX = {cY - cX}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"cX * cY = {cX * cY}");

            Console.WriteLine("\n--------------------\n");

            // в) 
            ClassComplex x = new ClassComplex(Numbers.GetNumber("Введите вещественную часть (Re) числа X: ", "Неверное значение!"),
                                              Numbers.GetNumber("Введите мнимую часть (Im) числа X: ", "Неверное значение!"));
            ClassComplex y = new ClassComplex(Numbers.GetNumber("Введите вещественную часть (Re) числа Y: ", "Неверное значение!"),
                                              Numbers.GetNumber("Введите мнимую часть (Im) числа Y: ", "Неверное значение!"));

            Console.WriteLine($"\nX = {x}\nY = {y}\n");

            while (true)
            {
                Console.Write("Введите тип операции (+, -, *, /): ");
                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($"\nX + Y = {x + y}");
                        break;
                    case "-":
                        Console.WriteLine($"\nX - Y = {x - y}");
                        break;
                    case "*":
                        Console.WriteLine($"\nX * Y = {x * y}");
                        break;
                    case "/":
                        Console.WriteLine($"\nX / Y = {x / y}");
                        break;
                    default:
                        Console.WriteLine("Неверное значение!");
                        break;
                }

                Console.WriteLine("\nНажмите Escape, чтобы выйти из программы.");
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    break;
            }
        }
    }
}
