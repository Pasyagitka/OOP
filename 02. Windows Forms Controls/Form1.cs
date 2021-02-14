using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        private void yearTrackBar_Scroll(object sender, EventArgs e)
        {
            yearResultLabel.Text = String.Format("{0}", yearTrackBar.Value); 
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            priceTextBox.Text = Convert.ToString(CountPrice());
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            Flats.ExportFlats();
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            Flats.ImportFlats();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowFlats();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Flat flat = CreateNewFlat();
                Flats.flats.Add(flat);
                Reset();
                saveButton.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Не введены все данные");
            }
        }
        public Flat CreateNewFlat()
        {
            Flat flat = new Flat();
            flat.square = Double.Parse(SqareTextBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-GB"));
            if (roomsCountComboBox.Text == "более") flat.roomscount = Flat.rooms.morethanfive;
            else
            {
                Flat.rooms flatValue = (Flat.rooms)Enum.Parse(typeof(Flat.rooms), roomsCountComboBox.Text, true);
                if (Enum.IsDefined(typeof(Flat.rooms), flatValue))
                    flat.roomscount = flatValue;
            }
            flat.year = yearTrackBar.Value;
            flat.kitchen = KitchenСheckBox.Checked ? true : false;
            flat.bathroom = BathroomCheckBox.Checked ? true : false;
            flat.WC = WCCheckBox.Checked ? true : false;
            flat.footer = FooterCheckBox.Checked ? true : false;
            flat.balcony = BalconyCheckBox.Checked ? true : false;
            flat.phonenumber = phoneNumberMaskedTextBox.Text;
            flat.address = new Address(countryComboBox.Text, cityComboBox.Text, streetTextBox.Text, Convert.ToInt32(houseTextBox.Text), Convert.ToInt32(flatTextBox.Text));
            flat.price = CountPrice();
            return flat;
        }

        void Reset()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(Panel))
                    foreach (Control d in c.Controls)
                        if (d.GetType() == typeof(GroupBox))
                            foreach (Control t in d.Controls)
                                if (t.GetType() == typeof(TextBox) || t.GetType() == typeof(ComboBox))
                                    t.ResetText();

                if (c.GetType() == typeof(GroupBox))
                    foreach (Control t in c.Controls)
                        if (t.GetType() == typeof(TextBox))
                            t.ResetText();

                if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox) || c.GetType() == typeof(MaskedTextBox))
                    c.ResetText();
            }
            yearTrackBar.Value = yearTrackBar.Maximum;
            yearResultLabel.Text = yearTrackBar.Maximum.ToString();
            FloorListBox.SelectedIndex = -1;
            roomsCountComboBox.SelectedIndex = -1;
            countryComboBox.SelectedIndex = -1;
            priceTextBox.Text = "0";
            KitchenСheckBox.Checked = true;
            BathroomCheckBox.Checked = true;
            WCCheckBox.Checked = true;
            FooterCheckBox.Checked = false;
            BalconyCheckBox.Checked = false;
        }

        bool IsFilled()
        {
            if (String.IsNullOrEmpty(roomsCountComboBox.Text)) return false;
            if (String.IsNullOrEmpty(SqareTextBox.Text)) return false;
            if (String.IsNullOrEmpty(countryComboBox.Text)) return false;
            if (String.IsNullOrEmpty(cityComboBox.Text)) return false;
            if (String.IsNullOrEmpty(streetTextBox.Text)) return false;
            if (String.IsNullOrEmpty(houseTextBox.Text)) return false;
            if (String.IsNullOrEmpty(flatTextBox.Text)) return false;
            return true;
        }

        public double CountPrice()
        {
            int rooms = 0;
            if (roomsCountComboBox.Text == "более")
            {
                rooms = 6;
            }
            else
            {
                rooms = Convert.ToInt32(roomsCountComboBox.Text);
            }
            return 20000 + Double.Parse(SqareTextBox.Text, NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-GB")) * 1000 +
                1000 * rooms + 2021 / Convert.ToDouble(yearTrackBar.Value) * 5000;
        }

        public void ShowFlats()
        {
            infoRichTextBox.Text = "";
            foreach (Flat f in Flats.flats)
            {
                infoRichTextBox.Text += "-------------------------------------------------";
                infoRichTextBox.Text += f.ToString();
            }
        }

        bool ValidSqare(string square, out string errorMessage)
        {
            errorMessage = "";
            if (square.Length == 0)
            {
                errorMessage = "Введите площадь";
                return false;
            }
            double number;
            if (!Double.TryParse(square, NumberStyles.AllowDecimalPoint, CultureInfo.CreateSpecificCulture("en-GB"), out number))
            {
                errorMessage = "Площадь может состоять лишь из цифр и знака \",\"";
                return false;
            }
            else
            {
                errorProvider1.Clear();
                if (IsFilled()) saveButton.Enabled = true;
            }
            return true;
        }

        private void SqareTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if(!ValidSqare(SqareTextBox.Text, out errorMsg))
            {
                //e.Cancel = true;
                SqareTextBox.Select(0, SqareTextBox.Text.Length);
                this.errorProvider1.SetError(SqareTextBox, errorMsg);
            }
        }

        private void roomsCountComboBox_Validating(object sender, CancelEventArgs e)
        {
           if(String.IsNullOrEmpty(roomsCountComboBox.Text))
           {
                errorProvider1.SetError(roomsCountComboBox, "Выберите количество комнат");
           }
           else
           { 
                errorProvider1.Clear();
                if (IsFilled())
                {
                    saveButton.Enabled = true;
                }
            }
        }

        private void countryComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(roomsCountComboBox.Text))
            {
                errorProvider1.SetError(roomsCountComboBox, "Выберите страну");
            }
            else
            {
                errorProvider1.Clear();
                if (IsFilled())
                {
                    saveButton.Enabled = true;
                }
            }
        }

        private void cityComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(cityComboBox.Text))
            {
                errorProvider1.SetError(cityComboBox, "Введите город");
            }
            else if (!cityComboBox.Text.All(char.IsLetter))
            {
                errorProvider1.SetError(cityComboBox, "Название города должно состоять только из букв");
            }
            else
            {
                errorProvider1.Clear();
                if (IsFilled())
                {
                    saveButton.Enabled = true;
                }
            }
        }

        private void streetTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(streetTextBox.Text))
            {
                errorProvider1.SetError(streetTextBox, "Введите улицу");
            }
            else if (!streetTextBox.Text.All(char.IsLetter))
            {
                errorProvider1.SetError(streetTextBox, "Название улицы должно состоять только из букв");
            }
            else
            {
                errorProvider1.Clear();
                if (IsFilled())
                {
                    saveButton.Enabled = true;
                }
            }
        }

        private void houseTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(houseTextBox.Text))
            {
                errorProvider1.SetError(houseTextBox, "Введите номер дома");
            }
            else if (!houseTextBox.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(houseTextBox, "Номер дома должен состоять только из цифр");
            }
            else
            {
                errorProvider1.Clear();
                if (IsFilled())
                {
                    saveButton.Enabled = true;
                }
            }
        }

        private void flatTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(flatTextBox.Text))
            {
                errorProvider1.SetError(flatTextBox, "Введите номер квартиры");
            }
            else if (!flatTextBox.Text.All(char.IsDigit))
            {
                errorProvider1.SetError(flatTextBox, "Номер квартиры должен состоять только из цифр");
            }
            else
            {
                errorProvider1.Clear();
                if (IsFilled())
                {
                    saveButton.Enabled = true;
                }
            }
        }

        private void phoneNumberMaskedTextBox_Validating(object sender, CancelEventArgs e)
        {
            const int numberlenght = 19;
            const string maskedtext = "+375 (  )    -  -";
            if (phoneNumberMaskedTextBox.Text.Length < numberlenght && !phoneNumberMaskedTextBox.Text.Equals(maskedtext))
            {
                errorProvider1.SetError(phoneNumberMaskedTextBox, "Номер введён неверно");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
