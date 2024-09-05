using System;
using AreaCalcLib;  // Подключаем пространство имен с фигурами

namespace GeometryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус круга:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Shape circle = new Circle(radius);
            double circleArea = AreaCalculator.CalculateArea(circle);
            Console.WriteLine($"Площадь круга с радиусом {radius}: {circleArea}");

            Console.WriteLine("\nВведите стороны треугольника (через пробел):");
            string[] sides = Console.ReadLine().Split();
            double sideA = Convert.ToDouble(sides[0]);
            double sideB = Convert.ToDouble(sides[1]);
            double sideC = Convert.ToDouble(sides[2]);

            Shape triangle = new Triangle(sideA, sideB, sideC);
            double triangleArea = AreaCalculator.CalculateArea(triangle);
            Console.WriteLine($"Площадь треугольника со сторонами {sideA}, {sideB}, {sideC}: {triangleArea}");

            if (((Triangle)triangle).IsRightTriangle())
            {
                Console.WriteLine("Этот треугольник является прямоугольным.");
            }
            else
            {
                Console.WriteLine("Этот треугольник не является прямоугольным.");
            }
        }
    }
}