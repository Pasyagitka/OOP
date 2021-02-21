using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeValidationForm
{
    public class NewAddress
    {
        [Required(ErrorMessage = "Отсутвует страна")]
        public string country;
        //[RegularExpression(@"^[а-я]|[А-Я]{2}", ErrorMessage = "Неверный формат")]
        [Required(ErrorMessage = "Отсутвует город")]
        public string city;
        [Required(ErrorMessage = "Отсутвует улица")]
        public string street;
        [Required(ErrorMessage = "Отсутвует номер дома")]
        [Range(0, 200, ErrorMessage = "Диапазон номера дома от 0 до 200")]
        public int housenumber;
        [Required(ErrorMessage = "Отсутвует номер квартиры")]
        [Range(0, 100, ErrorMessage = "Диапазон номера квартиры от 0 до 100")]
        public int flatnumber;
        [Index]
        public int index;

        public NewAddress(string country, string city, string street, int housenumber, int flatnumber)
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
  