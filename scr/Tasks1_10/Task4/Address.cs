using System;
using System.Collections.Generic;
using System.Text;

namespace Essential.Tasks1_10.Task4
{
    class Address
    {
        double index;
        public double Index { get; set; }
        string country;
        public string Country { get; set; }
        string street;
        public string Street { get; set; }
        string city;
        public string City { get; set; }
        int house;
        public int House { get; set; }
        int apartment;
        public int Apartment { get; set; }
        public Address()
        {
            
        }
        public Address(double index, string country, string street, string city, int house, int apartment)
        {
            this.apartment = apartment;
            this.city = city;
            this.country = country;
            this.index = index;
            this.street = street;
            this.apartment = apartment;
            this.house = house;
        }
    }
}
