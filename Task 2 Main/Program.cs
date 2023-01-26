using System;

namespace Task_2_Main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите длину сторон для треугольника 1 (x, y, z):");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину сторон для треугольника 2 (x, y, z):");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());

            double area1 = GetTriangleArea(x1, y1, z1);
            double area2 = GetTriangleArea(x2, y2, z2);

            if (area1 > area2)
            {
                Console.WriteLine("Первый треугольник имеет большую площадь.");
                Console.ReadKey();
            }
            else if (area1 < area2)
            {
                Console.WriteLine("Второй треугольник имеет большую площадь.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Треугольники равны и имеют одинаковую площадь.");
                Console.ReadKey();

            }
        }
        static double GetTriangleArea(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double area = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return area;
        }

    }
}
