using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Essential.Tasks1_10.Task5
{
    class Converter
    {
        public double USD { get; set; }
        public double EUR { get; set; }
        public double RUB { get; set; }
        public double BYN { get; set; }
        public Converter(double byn)
        {
            BYN = byn;
        }
        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }
        public void ConversionToBYN(string abbreviation, double summ)
        {
            switch (abbreviation)
            {
                case "USD":
                    {
                        Converter Converter = new Converter(2.5655);
                        var result = summ * BYN;
                        Console.WriteLine($"{result} BYN");
                        break;
                    }
                case "EUR":
                    {
                        Converter Converter = new Converter(3.1648);
                        var result = summ * BYN;
                        Console.WriteLine($"{result} BYN");
                        break;
                    }
                case "RUB":
                    {
                        Converter Converter = new Converter(0.0349);
                        var result = summ * BYN;
                        Console.WriteLine($"{result} BYN");
                        break;
                    }
                default:
                    Console.WriteLine("Your choice is something else.");
                    break;
            }
        }
    }
}
