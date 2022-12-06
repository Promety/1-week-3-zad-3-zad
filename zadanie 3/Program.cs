using System;

namespace zadanie_3
{
    class Program
    {

        static double F(double x, double a, double b)
        {
            double y = .0;

            if (x * x - 5 * x < 0) y = a + b;
            else if (10 > x * x - 5 * x) y = a - b;
            else y = a * b;
            return y;
        }
        static void F(double x, double a, double b,  out double y)
        {
            if (x * x - 5 * x < 0) y = a + b;
            else if (10 > x * x - 5 * x) y = a - b;
            else y = a * b;
        }
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;
            Console.Write("Введите начало диапазона x: ");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.WriteLine("Некорректный ввод данных");
            Console.Write("Введите конец диапазона x: ");
            while (!double.TryParse(Console.ReadLine(), out b) || b < a)
                Console.WriteLine("Некорректный ввод данных, b не может быть меньше а");
            Console.Write("Введите шаг h: ");
            while (!double.TryParse(Console.ReadLine(), out h) || h <= 0)
                Console.WriteLine("Некорректный ввод данных, h не может быть меньше или равно 0");
            for (double i = a; i <= b; i += h)
            {
                double y;
                F(i,a,b, out y);
                y = F(i,a,b);
                Console.WriteLine("F({0:f2})={1:f4}", i, y) ;
            }
           
        }
    }
}

