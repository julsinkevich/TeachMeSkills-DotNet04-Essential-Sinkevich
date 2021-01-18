using System;
using System.Collections.Generic;
using System.Text;

namespace Essential.Tasks1_10.Task3
{
    public class Task3
    {
        public void Task()
        {
            var point = new Point();

            Console.WriteLine("Enter a letter of Point:");
            string name = point.Name;

            Console.WriteLine("Enter X1:");
            var x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y1:");
            var y1 = int.Parse(Console.ReadLine());
            var point1 = new Point(name, x1, y1);

            Console.WriteLine("Enter X2:");
            var x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y2:");
            var y2 = int.Parse(Console.ReadLine());
            var point2 = new Point(name, x2, y2);

            var point3 = new Point(name, 10, 20);
            Console.WriteLine("Конечная точка (10,20)");

            var figure = new Figure(point1,point2,point3);
            Console.WriteLine(figure.name);

            figure.PerimeterCalculate();
        }
    }
}