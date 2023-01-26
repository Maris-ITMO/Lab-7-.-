using System;

namespace Lab_7_СамРаб._Методы
{
    class Triangle
    {
        double x, y, z;
        Triangle(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double GetArea()
        {
            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }
    }

    class MainClass
    {
        public static double GetTriangleArea(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
        }

        public static void Main(string[] args)
        {
            double x1 = 3, y1 = 4, z1 = 5;
            double x2 = 2, y2 = 2, z2 = 2;

            double area1 = GetTriangleArea(x1, y1, z1);
            double area2 = GetTriangleArea(x2, y2, z2);

            if (area1 > area2)
            {
                Console.WriteLine("Первый треугольник имеет большую площадь.");
            }
            else if (area1 < area2)
            {
                Console.WriteLine("Второй треугольник имеет большую площадь.");
            }
            else
            {
                Console.WriteLine("Треугольники равны и имеют одинаковую площадь.");
            }
        }
    }

}
