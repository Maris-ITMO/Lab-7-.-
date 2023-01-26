using System;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите  сторону куба:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Площадь поверхности куба: " + x1*x1*6);
            Console.ReadKey();
        }
    }
}
