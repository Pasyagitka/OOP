using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Controls
{
    public partial class FlatForm : Form
    {
        public FlatForm()
        {
            InitializeComponent();
        }

        private void toYearTrackBar_Scroll(object sender, EventArgs e)
        {
            toYearResultLabel.Text = String.Format("{0}", yearTrackBar.Value); 
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlatForm_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Flat flat = CreateNewFlat();
        }
        public Flat CreateNewFlat()
        {
            Flat flat = new Flat();
            flat.square = Convert.ToInt32(SqareTextBox.Text);
            flat.roomscount = Convert.ToInt32(roomsCountComboBox.Text);
            flat.year = yearTrackBar.Value;
            flat.kitchen = KitchenСheckBox.Checked ? true : false;
            flat.bathroom = BathroomCheckBox.Checked ? true : false;
            flat.WC = WCCheckBox.Checked ? true : false;
            flat.footer = FooterCheckBox.Checked ? true : false;
            flat.balcony = BalconyCheckBox.Checked ? true : false;
            flat.phonenumber = phoneNumberMaskedTextBox.Text;
            flat.address = new Address(countryComboBox.Text, cityComboBox.Text, streetTextBox.Text, Convert.ToInt32(houseTextBox.Text), Convert.ToInt32(flatTextBox.Text));
            flat.price = flat.CountPrice(); 
            return flat;
        }
        public void Serialize()//потом
        {

        }
        public void Deserialize()//потом
        {

        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            //priceTextBox.Text= CountPrice()
        }
    }
}
