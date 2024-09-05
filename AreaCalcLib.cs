using System;

namespace AreaCalcLib
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0.");
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
    public class Triangle : Shape
    {
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Все стороны треугольника должны быть больше 0.");
            if (firstSide + secondSide <= thirdSide || firstSide + thirdSide <= secondSide || secondSide + thirdSide <= firstSide)
                throw new ArgumentException("Некорректные стороны треугольника. Сумма двух сторон не может быть больше третьей стороны.");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public override double CalculateArea()
        {
            double halfPerimeter = (FirstSide + SecondSide + ThirdSide)/2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide) * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
        }
        public bool IsRightTriangle()
        {
            double a2 = Math.Pow(FirstSide, 2);
            double b2 = Math.Pow(SecondSide, 2);
            double c2 = Math.Pow(ThirdSide, 2);
            return a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2;
        }
    }
    public static class AreaCalculator
    {
        public static double CalculateArea(Shape shape)
        {
            return shape.CalculateArea();
        }
    }
}
