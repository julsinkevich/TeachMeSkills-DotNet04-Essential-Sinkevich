using System;
using System.Collections.Generic;
using System.Text;

namespace Essential.Tasks1_10.Task5
{

    class Task5
    {
        Converter converter;
        public void Task()
        {
            Console.WriteLine("Enter sum in BYN:");
            var sum = double.Parse(Console.ReadLine());
            Converter Converter = new Converter(2.553, 3.151, 3.42);
            var BU = sum / Converter.USD;
            var BE = sum / Converter.EUR;
            var BR = sum *100/ Converter.RUB;
            Console.WriteLine($"{sum} BYN\n{BU} USD\n{BE} EUR\n{BR} RUB");

            Console.WriteLine("Enter abbreviation:");
            string abbreviation = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter sum:");
            var summ = double.Parse(Console.ReadLine());
            converter = new Converter(summ);
            converter.ConversionToBYN(abbreviation, summ);
        }
    }
}
