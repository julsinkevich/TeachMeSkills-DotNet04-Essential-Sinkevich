using System;
using System.Collections.Generic;
using System.Text;

namespace Essential.Tasks1_10.Task3
{
    class Figure
    {
        Point[] points;
        public string name
        {
            get
            {
                if (points.Length == 3)
                {
                    return "треугольник";
                }
                else if (points.Length == 4)
                {
                    return "четырехугольник";
                }
                else if (points.Length == 5)
                {
                    return "пятиугольник";
                }
                else
                {
                    return "какой-то угольник";
                }
            }
        }
        public Figure(Point point, Point point1, Point point2)
        {
            points = new Point[] { point, point1, point2};
        }
        public Figure(Point point, Point point1, Point point2, Point point3)
        {
            points = new Point[] { point, point1, point2, point3};
        }
        public Figure(Point point, Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point, point1, point2, point3, point4};
        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public void PerimeterCalculate()
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += LengthSide(points[i - 1], points[i]);
            }
            perimeter += LengthSide(points[0], points[points.Length-1]);
           
            Console.WriteLine("периметр:{0}",perimeter);
        }
    }
}
