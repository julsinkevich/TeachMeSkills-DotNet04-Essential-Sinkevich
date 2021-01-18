using System;
using System.Collections.Generic;
using System.Text;

namespace Essential.Tasks1_10.Task6
{
    class Task6
    {
        Employee employee = new Employee("Петров", "Петя");
        PositionSeniority positionSeniority;
        public void Task()
        {
            positionSeniority = new PositionSeniority();
            Console.WriteLine("Enter : junior, middle or senior");
            var job = Console.ReadLine().ToLower();
            Console.WriteLine("Enter seniority: ");
            var year = Convert.ToInt32(Console.ReadLine());
            employee.GetInfo();
            positionSeniority.SalaryMethod(job,year);
        }
    }
}
