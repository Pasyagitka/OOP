using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Media;

namespace Shop.Product
{
    [DataContract]
    [KnownType(typeof(Candy))]
    [KnownType(typeof(Chocolate))]
    [KnownType(typeof(Marmalade))]
    [KnownType(typeof(Waffles))]
    public abstract class Sweetness : INotifyPropertyChanged
    {
        [DataMember]
        public string name;
        [DataMember]
        public string image;
        [DataMember]
        public double weight;
        [DataMember]
        public int calories;
        [DataMember]
        public string description;
        [DataMember]
        public string trademark;
        [DataMember]
        public int price;
        
        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged("Name"); }
            }

        public string Image
        {
            get => image;
            set { image = value; OnPropertyChanged("Image"); }

            }

        public double Weight
        {
            get => weight;
            set { weight = value; OnPropertyChanged("Weight"); }
        }

        public int Calories
        {
            get => calories;
            set { calories = value; OnPropertyChanged("Calories"); }
            }

        public string Description
        {
            get => description;
            set { description = value; OnPropertyChanged("Description"); }
        }

        public string Trademark
        {
            get => trademark;
            set { trademark = value; OnPropertyChanged("Trademark"); }
        }

        public int Price
        {
            get => price;
            set { price = value; OnPropertyChanged("Price"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public override string ToString()
        {
            return name + ", " + weight.ToString()+ ", " + calories.ToString() + ", " + description + ", " + trademark + ", " + price.ToString();
        }
    }
}
