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

            using (UnitOfWork db = new UnitOfWork())
            {
                //todo асинхронная работа
                //todo транзакции
                
                //Insert
                // db.Clients.Create(new Client {FirstName = "Ihar", Patronymic = "Ivanovich", Surname = "Ihorev", Email = "i@r.ru", ContactNumber = 123124, AddressId = 2});
                // db.Address.Create(new Address {City = "Minsk", Country = "Belarus", Street = "Kirova", House = 22, PostalCode = 193843});
                // db.Address.Create(new Address {Country = "Беларусь", City = "Минск", Street = "Свердлова", House = 11, PostalCode = 220044 });
                // db.Address.Create(new Address { Country = "Беларусь", City = "Минск", Street = "Серова", House = 23, PostalCode = 220066 });
                //
                // db.Save();
                
                //Update
                // var addr1 = db.Address.Get(1);
                // db.Address.Update(addr1);
                // addr1.City = "Brest";
                // db.Save();
                
                var cl1 = db.Clients.Get(1);
                db.Clients.Update(cl1);
                cl1.Surname = "Andreev";
                db.Save();
                
                //todo output
                AddressesGrid.ItemsSource = db.Address.OrderById().ToList();
                //ClientsGrid.ItemsSource = db.Clients.OrderByString().ToList();
                ClientsGrid.ItemsSource = db.Clients.SearchBy("Ih").ToList(); //123
            }
        }
        
        
    }
}
