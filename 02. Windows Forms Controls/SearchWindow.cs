using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Controls
{
    public partial class SearchWindow : Form
    {
        public SearchWindow()
        {
            InitializeComponent();
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void OKSearchButton_Click(object sender, EventArgs e)
        {
            SearchRichTextBox.ResetText();
            IEnumerable<Flat> searchres = Search();

            if (searchres.Count() == 0)
            {
                SearchRichTextBox.Text += "Ничего не найдено";
            }
            else
            {
                foreach (var f in searchres)
                {
                    SearchRichTextBox.Text += f;
                }
                if (SaveSortResCheckBox.Checked == true)
                {
                    try
                    {
                        Serialize(searchres);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка сохранения результатов поиска по регулярному выражению в файл");
                    }
                }
            }
        }
        void Serialize(IEnumerable<Flat> searchres)
        {
            const string filepath = "..//..//..//SearchFlats.json";
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Flat>));
            using (var fs = new FileStream(filepath, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, searchres);
            }
        }
        private IEnumerable<Flat> Search()
        {
            IEnumerable<Flat> searchres = Flats.flats;
            if (SearchByRoomsCountcheckBox.Checked)
                searchres = searchres.Intersect(SearchByRooms());
            if (SearchByYearCheckBox.Checked)
                searchres = searchres.Intersect(SearchByYear());
            if (SearchByCityCheckBox.Checked)
                searchres = searchres.Intersect(SearchByCity());
            if (SearchByStreetCheckBox.Checked)
                searchres = searchres.Intersect(SearchByStreet());
            return searchres;
        }
        private IEnumerable<Flat> SearchByRooms() 
        {
            foreach (Flat flat in Flats.flats)
                if (roomsCountComboBox.Text=="более" ?
                    (Convert.ToInt32(Flat.rooms.morethanfive) == Convert.ToInt32(flat.roomscount)) : 
                    Convert.ToInt32(roomsCountComboBox.Text) == Convert.ToInt32(flat.roomscount))
                    yield return flat;
        }
        private IEnumerable<Flat> SearchByYear()
        {
            foreach (Flat flat in Flats.flats)
                if (yearTrackBar.Value == flat.year)
                    yield return flat;
        }
        private IEnumerable<Flat> SearchByCity() 
        {
            foreach (Flat flat in Flats.flats)
                if (cityComboBox.Text == flat.address.City)
                    yield return flat;
        }
        private IEnumerable<Flat> SearchByStreet() 
        {
            foreach (Flat flat in Flats.flats)
                if (streetTextBox.Text == flat.address.Street)
                    yield return flat;
        }

        private void SearchByRoomsCountcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            roomsCountComboBox.Enabled = !roomsCountComboBox.Enabled;
        }

        private void SearchByYearCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            yearTrackBar.Enabled = !yearTrackBar.Enabled;
        }

        private void SearchByCityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            cityComboBox.Enabled = !cityComboBox.Enabled;
        }

        private void SearchByStreetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            streetTextBox.Enabled = !streetTextBox.Enabled;
        }
        private void yearTrackBar_Scroll(object sender, EventArgs e)
        {
            yearResultLabel.Text = String.Format("{0}", yearTrackBar.Value);
        }
    }
}
