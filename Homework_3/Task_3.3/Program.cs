using System;

/* Чечулин Денис
 *  
 * 3. 
 * 
 * *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. 
 * Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
 * Написать программу, демонстрирующую все разработанные элементы класса.
 * 
 * Добавить свойства типа int для доступа к числителю и знаменателю;
 * Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; 
 * ** Добавить проверку, чтобы знаменатель не равнялся 0. 
 * Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); 
 * *** Добавить упрощение дробей.
 * 
 */

namespace Task_3._3
{
    class Fraction
    {
        public int m { get; set; }
        public int n { get; set; }
        public double Decimal { get; }

        public Fraction(int numerator = 0, int denominator = 1)
        {
            m = numerator;
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен 0.", "denominator = 0");
            n = denominator;

            Decimal = (double)m / n;
        }

        public static Fraction Simplify(Fraction x)
        {
            int tmpM = x.m > 0 ? x.m : -x.m, tmpN = x.n > 0 ? x.n : -x.n;
            while (tmpM != tmpN)
            {
                if (tmpM > tmpN)
                    tmpM -= tmpN;
                else
                    tmpN -= tmpM;
            }
            return new Fraction(numerator: x.m / tmpM, denominator: x.n / tmpM);
        }

        #region Операторы

        public static Fraction operator +(Fraction x, Fraction y)
        {
            Fraction z = new Fraction(numerator: x.m * y.n + y.m * x.n, denominator: x.n * y.n);
            return Simplify(z);
        }

        public static Fraction operator -(Fraction x)
        {
            Fraction z = new Fraction(numerator: -x.m, denominator: x.n);
            return Simplify(z);
        }

        public static Fraction operator -(Fraction x, Fraction y)
        {
            Fraction z = new Fraction(numerator: x.m * y.n - y.m * x.n, denominator: x.n * y.n);
            return Simplify(z);
        }

        public static Fraction operator *(Fraction x, Fraction y)
        {
            Fraction z = new Fraction(numerator: x.m * y.m, denominator: x.n * y.n);
            return Simplify(z);
        }

        public static Fraction operator /(Fraction x, Fraction y)
        {
            Fraction z = new Fraction(numerator: x.m * y.n, denominator: x.n * y.m);
            return Simplify(z);
        }

        #endregion

        public override string ToString()
        {
            if (m == 0)
                return "0";
            if (n == 1)
                return $"{m}";
            if ((m > 0 && n < 0))
                return $"-{m}/{-n}";
            return $"{m}/{n}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var x = new Fraction(1, 3);
            var y = new Fraction(2, 4);
            Console.WriteLine($"X = {x} = {Fraction.Simplify(x)}\nY = {y} = {Fraction.Simplify(y)}\n");

            Console.WriteLine($"Знаменатель X: {x.m}. Числитель X: {x.n}\nЗнаменатель Y: {y.m}. Числитель Y: {y.n}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Десятичная дробь X: {x.Decimal}\nДесятичная дробь Y: {y.Decimal}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"X + Y = {x + y}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"-X = {-x}\n-Y = {-y}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"X - Y = {x - y}");
            Console.WriteLine($"Y - X = {y - x}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"X * Y = {x * y}");
            Console.WriteLine("--------------------");
            Console.WriteLine($"X / Y = {x / y}");
            Console.WriteLine($"Y / X = {y / x}");
        }
    }
}
