using System;
using System.Collections.Generic;
using System.Text;

namespace Essential.Tasks1_10
{
    public class Task1
    {
        public void Task()
        {
            Console.WriteLine("Enter two numbers:");
            var side1 = Convert.ToDouble(Console.ReadLine());
            var side2 = Convert.ToDouble(Console.ReadLine());
            var rectangle = new Rectangle(side1, side2);
            Console.WriteLine($"Area: {rectangle.Area}, Perimeter: {rectangle.Perimeter}");
        }
    }
}
