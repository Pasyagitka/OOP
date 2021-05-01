using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF11Lab
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (ClientContext db = new ClientContext())
            {
                Address ad1 = new Address { Country = "Беларусь", City = "Минск", Street = "Свердлова", House = 11, PostalCode = 220044 };
                Address ad2 = new Address { Country = "Беларусь", City = "Минск", Street = "Серова", House = 23, PostalCode = 220066 };


                // добавляем объекты Book в контекст данных
                db.Addresses.Add(ad1);
                db.Addresses.Add(ad2);

                // сохраняем контекст данных в базу данных
                db.SaveChanges();
            }
        }
    }
}
