using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _215_pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите координаты вершин треугольника: ");
            //Console.WriteLine("Введите координаты 1 точки: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //double y1= Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите координаты 2 точки: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите координаты 3 точки: ");
            //double x3 = Convert.ToDouble(Console.ReadLine());
            //double y3 = Convert.ToDouble(Console.ReadLine());
            //double P = 0;
            //P += Math.Sqrt(Math.Pow(x2-x1, 2) + (Math.Pow(y2-y1, 2)));
            //P += Math.Sqrt(Math.Pow(x3-x2, 2) + (Math.Pow(y3-y2, 2)));
            //P += Math.Sqrt(Math.Pow(x3 - x1, 2) + (Math.Pow(y3 - y1, 2)));
            //double p = P / 2;
            //double S =Math.Sqrt(p*(p- Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2))))*(p- Math.Sqrt(Math.Pow(x3 - x2, 2) + (Math.Pow(y3 - y2, 2))))*(p- Math.Sqrt(Math.Pow(x3 - x2, 2) + (Math.Pow(y3 - y2, 2)))));
            //Console.WriteLine($"Периметр равен: {P}; Площадь равна {S}");
            //Console.ReadLine();

            //Console.WriteLine("Введите пройденое расстояние: ");
            //double s = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите расход бензина на 100 км: ");
            //double b= Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите стоимость бензина за 1 литр: ");
            //double c= Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Стоимость поездки: {(s*b/100)*c}");
            //Console.Read();

            Console.Write("Введите цену за 1 кг конфет: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цену за 1 кг печенья: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цену за 1 кг яблок: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес конфет: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес печенья: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес яблок: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Стоимость всей покупки: {a*x+b*y+c*z}");
            Console.ReadKey();
        }
    }
}
