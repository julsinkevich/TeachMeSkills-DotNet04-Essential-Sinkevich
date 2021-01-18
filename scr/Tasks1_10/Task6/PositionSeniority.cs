using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Essential.Tasks1_10.Task6
{
    class PositionSeniority
    {
        public string Position { get; set; }
        public int Seniority { get; set; }
        public void SalaryMethod(string position, int seniority)
        {
            var rn = new Random();
            PositionSeniority[] positionSeniorities =
               {
                new PositionSeniority { Position="senior",Seniority= rn.Next(2000) },
                new PositionSeniority{ Position ="middle",Seniority= rn.Next(1000,2000) },
                new PositionSeniority{ Position ="junior", Seniority= rn.Next(200,1000) }
            };
            var result = positionSeniorities.ToDictionary(k => k.Position, v => v.Seniority);
            foreach (KeyValuePair<string, int> dic in result)
            {
                if (result.ContainsKey(position))
                {
                    if (seniority <= 2)
                    {
                        Console.WriteLine($"Your salary {dic.Value * 1} ");
                        Console.WriteLine($"Your tax levy is {dic.Value * 1 * 0.13} ");
                        break;
                    }
                    else if (seniority > 2)
                    {
                        Console.WriteLine($"Your salary {dic.Value * 1.20} ");
                        Console.WriteLine($"Your tax levy is {dic.Value * 1.20 * 0.13} ");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Your salary {dic.Value * 1.45} ");
                        Console.WriteLine($"Your tax levy is {dic.Value * 1.45 * 0.13} ");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"Your were leading sonething wrong.");
                }
            }
        }
    }
}