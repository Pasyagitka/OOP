using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Windows_Forms_Controls
{
    public class Flats
    {
        private static Flats flatsinstance; 
        private static readonly object Locker = new object();
        const string filepath = "..//..//..//Flats.json";
        public static List<Flat> flats;
        static DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Flat>));

        private Flats() 
        {
            flats = new List<Flat>();
        }
        public static Flats GetInstance() 
        {
            if (flatsinstance == null)
            {
                lock (Locker)
                {
                    if (flatsinstance == null)
                    {
                        flatsinstance = new Flats();
                    }
                }
            }
            return flatsinstance;
        }

        public static void ExportFlats()
        { 
            using (var fs = new FileStream(filepath, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, flats);
            }
        }
        public static void ImportFlats()
        {
            using (var file = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                var flatlist = jsonFormatter.ReadObject(file) as List<Flat>;
                if (flatlist != null)
                {
                    foreach (var f in flatlist)
                        flats.Add(f);
                }

            }
        }
        //public override string ToString()
        //{
        //    string result = "";
        //    foreach (Flat f in flats)
        //    {
        //        result += f.ToString() + "\n";
        //    }
        //    return result;
        //}
    }

    [DataContract]
    public class Flat : IPrototype
    {
        public enum rooms { one = 1, two, three, four, five, morethanfive };
        [DataMember]
        public double square;
        [DataMember]
        public rooms roomscount;
        [DataMember]
        public int year;
        [DataMember]
        public bool kitchen;
        [DataMember]
        public bool bathroom;
        [DataMember]
        public bool WC;
        [DataMember]
        public bool footer;
        [DataMember]
        public bool balcony;
        [DataMember]
        public double price;
        [DataMember]
        public string phonenumber;
        [DataMember]
        public Address address;

        public override string ToString()
        {
            return "\n Адрес: " + address.ToString() + ", метраж: " + square + ", количество комнат: " + roomscount + ", год постройки дома: " + year + "\n\tкухня: " + kitchen +
                "\n\tванная комната: " + bathroom + "\n\tтуалет: " + WC.ToString() + "\n\tподвал: " + footer + "\n\tбалкон: " + balcony + "\n\tприблизительная стоимость: " + price +
                "\nКонтактный телефон: " + phonenumber;
        }

        public IPrototype Clone()
        {
            return new Flat {address=this.address, square  = this.square, roomscount = this.roomscount, year=this.year, kitchen=this.kitchen, bathroom=this.bathroom, WC=this.WC, 
                footer = this.footer, balcony=this.balcony, phonenumber=this.phonenumber, price=this.price };
            //return this.MemberwiseClone() as IPrototype;
        }
    }
    [Serializable]
    public class Address
    {
        string country;
        string city;
        string street;
        int housenumber;
        int flatnumber;
        int index;

        [Required(ErrorMessage = "Отсутвует страна")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Отсутвует город")]
        public string City { get; set; }
        [Required(ErrorMessage = "Отсутвует улица")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Отсутвует номер дома")]
        [Range(0, 200, ErrorMessage = "Диапазон номера дома от 0 до 200")]
        public int HouseNumber { get; set; }
        [Required(ErrorMessage = "Отсутвует номер квартиры")]
        [Range(0, 100, ErrorMessage = "Диапазон номера квартиры от 0 до 100")]
        public int FlatNumber { get; set; }
        [Index]
        public int Index { get; set;  }
            
        public Address(string country, string city, string street, int housenumber, int flatnumber, int index)
        {
            this.Country = country;
            this.City = city;
            this.Street = street;
            this.HouseNumber = housenumber;
            this.FlatNumber = flatnumber;
            this.Index = index;
        }

        public override string ToString()
        {
            return "страна: " + this.Country + ", город: " + this.City + ", улица: " + this.Street + ", номер дома: " + this.HouseNumber + ", номер квартиры: " + this.FlatNumber + ", индекс: " + this.Index;
        }
    }
}
