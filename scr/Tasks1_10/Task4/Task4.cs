using System;
using System.Collections.Generic;
using System.Text;

namespace Essential.Tasks1_10.Task4
{
    class Task4
    {
       public void Task()
       {
            Address addres = new Address();
            //addres = new Address(666999, "USA", "Elm Street House", "Sprinwood", 1428, 1);
            addres.Index = 666999;
            addres.Country = "USA";
            addres.City = "Sprinwood";
            addres.Street = "Elm Street House";
            addres.House = 1428;
            addres.Apartment = 1;
            Console.WriteLine($"Index - {addres.Index}\nCountry - {addres.Country}\nCity - {addres.City}\nStreet - {addres.Street}\nHouse - {addres.House}\nAppartment - {addres.Apartment}");
        }
    }
}
