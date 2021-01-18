using System;
using System.Collections.Generic;
using System.Text;

namespace Essential.Tasks1_10.Task3
{
    class Point
    {
        string name;
        int x, y;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                var X = Convert.ToString(x);
                var Y = Convert.ToString(y);
                return $"координата({X},{Y}):";
            }
        }
        public Point() { }
        public Point(string _name, int _x, int _y)
        {
            /*Console.WriteLine("Enter a letter of Point:");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter X:");
            this.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            this.y = int.Parse(Console.ReadLine());*/
            
            x = _x;
            y = _y;
            name = _name;

            x = X;
            y = Y;
            name = Name;
        }
    }
}
