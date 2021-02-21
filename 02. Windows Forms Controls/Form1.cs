using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
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
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Изменён год";
            yearResultLabel.Text = String.Format("{0}", yearTrackBar.Value); 
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Рассчитана цена";
            priceTextBox.Text = Convert.ToString(CountPrice());
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Файл экспорта будет перезаписан", "Предупреждение!");
                Flats.ExportFlats();
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Экспортированы квартиры";
            }
            catch
            {
                MessageBox.Show("Ошибка экспорта", "Ошибка!");
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            try
            {
                Flats.ImportFlats();
                BaseInfoToolStripStatusLabel.Text = "Квартир в базе " + Flats.flats.Count().ToString();
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Импортированы квартиры";
            }
            catch
            {
                MessageBox.Show("Ошибка импорта", "Ошибка!");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowFlats();
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Выведены квартиры";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Flat flat = CreateNewFlat();
                var results = new List<ValidationResult>();
                var context = new ValidationContext(flat.address);
                if (!Validator.TryValidateObject(flat.address, context, results, true))
                {
                    infoRichTextBox.ResetText();
                    infoRichTextBox.ForeColor = Color.Red;
                    foreach (var error in results)
                    {
                        infoRichTextBox.Text += "[!]" + error.ErrorMessage + "\n";
                    }
                    return;
                }
                Flats.flats.Add(flat);
                Reset();
                saveButton.Enabled = false;
                BaseInfoToolStripStatusLabel.Text = "Квартир в базе " + Flats.flats.Count().ToString();
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлена квартира";
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
            flat.address = new Address(countryComboBox.Text, cityComboBox.Text, streetTextBox.Text, Convert.ToInt32(houseTextBox.Text), Convert.ToInt32(flatTextBox.Text), Convert.ToInt32(IndexTextBox.Text));
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
            infoRichTextBox.ResetText();
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
            const string header = "----------------------------------------------------";
            infoRichTextBox.ResetText();
            infoRichTextBox.ForeColor = Color.DimGray;
            foreach (Flat f in Flats.flats)
            {
                infoRichTextBox.Text += header;
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

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string developer = "Zinovich Lizaveta";
            const string version = "v0.1";
            MessageBox.Show(developer + "\n" + version, "О программе");
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void FullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWindow searchwindow = new SearchWindow();
            searchwindow.Show();
        }

        private void RegExToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegExSearchWindow regexsearchwindow = new RegExSearchWindow();
            regexsearchwindow.Show();
        }

        private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            infoRichTextBox.ResetText();
            var sortedlist = Sort();
            foreach(var f in sortedlist)
            {
                infoRichTextBox.Text += f;
            }
            if (SaveSortResCheckBox.Checked == true)
            {
                try
                {
                    Serialize(sortedlist);
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения результатов сортировки в файл");
                }
            }
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Квартиры отсортированы";
        }

        IOrderedEnumerable<Flat> Sort()
        {
            if (SortByComboBox.SelectedIndex == 0)
                return Flats.flats.OrderBy(t => t.square);
            else if (SortByComboBox.SelectedIndex == 1)
                return Flats.flats.OrderBy(t => t.roomscount);
            else 
                return Flats.flats.OrderBy(t => t.price);
        }

        void Serialize(IOrderedEnumerable<Flat>  sortedlist)
        {
            const string filepath = "..//..//..//SortedFlats.json";
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Flat>));
            using (var fs = new FileStream(filepath, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, sortedlist);
            }
        }

        private void DateTimetimer_Tick(object sender, EventArgs e)
        {
            DateToolStripStatusLabel.Text = DateTime.Now.ToLongDateString();
            TimeToolStripStatusLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void DateToolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }



        private void regexToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegExSearchWindow regexsearchwindow = new RegExSearchWindow();
            regexsearchwindow.Show();
        }

        private void наПолноеСоответствиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWindow searchwindow = new SearchWindow();
            searchwindow.Show();
        }

        #region LastAction
        private void FloorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Выбран этаж";
        }

        private void roomsCountComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Выбрано количество комнат";
        }

        private void SqareTextBox_TextChanged(object sender, EventArgs e)
        {
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Указана площадь";
        }

        private void phoneNumberMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Указан телефон";
        }

        private void KitchenСheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (KitchenСheckBox.Checked == true)
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлена опция \"кухня\"";
            else
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Убрана опция \"кухня\"";
        }

        private void BathroomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BathroomCheckBox.Checked == true)
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлена опция \"ванная\"";
            else
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Убрана опция \"ванная\"";
        }

        private void WCCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (WCCheckBox.Checked == true)
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлена опция \"туалет\"";
            else
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Убрана опция \"туалет\"";
        }

        private void FooterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FooterCheckBox.Checked == true)
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлена опция \"подвал\"";
            else
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Убрана опция \"подвал\"";
        }

        private void BalconyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BalconyCheckBox.Checked == true)
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлена опция \"балкон\"";
            else
                ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Убрана опция \"балкон\"";
        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлена страна в адрес";
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлен город в адрес";
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлена улица в адрес";
        }

        private void houseTextBox_TextChanged(object sender, EventArgs e)
        {
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлен дом в адрес";
        }

        private void flatTextBox_TextChanged(object sender, EventArgs e)
        {
            ActionToolStripStatusLabel.Text = "Последнее выполненное действие: " + "Добавлен номер квартиры в адрес";
        }
        #endregion

        private void ResetToolStripButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
