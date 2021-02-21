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
        const string filepath = "..//..//..//Flats.json";
        public static List<Flat> flats = new List<Flat>();
        static DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Flat>));
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
    public class Flat
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
    }
    [Serializable]
    public class Address
    {
        //public enum countries { Belarus};
        //public countries country;
        public string country;
        public string city;
        public string street;
        public int housenumber;
        [Range(0, 100, ErrorMessage = "Диапазон номера квартиры от 0 до 100")]
        public int flatnumber; 
        
        public Address(string country, string city, string street, int housenumber, int flatnumber)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.housenumber = housenumber;
            this.flatnumber = flatnumber;
        }

        public override string ToString()
        {
            return "страна: " + this.country + ", город: " + this.city + ", улица: " + this.street + ", номер дома: " + this.housenumber + ", номер квартиры: " + this.flatnumber;
        }
    }
}
