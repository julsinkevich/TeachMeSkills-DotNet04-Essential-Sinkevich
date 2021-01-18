using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Essential.Tasks1_10.Task6
{
    class Employee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public Employee(string surname, string name)
        {
            Name = name;
            Surname = surname;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Your name: {Name}  surname: {Surname}");
        }
    }
}

