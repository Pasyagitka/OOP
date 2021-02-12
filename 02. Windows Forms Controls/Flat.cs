using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Controls
{
    public class Flat
    {
        public int square;
        public int roomscount;
        public int year;
        public bool kitchen;
        public bool bathroom;
        public bool WC;
        public bool footer;
        public bool balcony;
        public double price;
        public string phonenumber;
        public Address address;

        public double CountPrice()
        {
            return (square * 1000 + roomscount*10000) * year / 1000;
        }
    }
    public class Address
    {
        //public enum countries { Belarus};
        //public countries country;
        public string country;
        public string city;
        public string street;
        public int housenumber;
        public int flatnumber; 
        
        public Address(string country, string city, string street, int housenumber, int flatnumber)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.housenumber = housenumber;
            this.flatnumber = flatnumber;
        }
    }
}
