using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Controls
{
    public partial class RegExSearchWindow : Form
    {
        public RegExSearchWindow()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            RegexSearchRichTextBox.ResetText();
            SearchWithRegex();
        } 
        private void SearchWithRegex()
        {
            Regex regex = new Regex(@RegExComboBox.Text, RegexOptions.IgnoreCase);
            var regexSearchResult = Flats.flats.Where(f => regex.IsMatch(f.ToString()));
            if (regexSearchResult.Count() == 0)
            {
                MessageBox.Show("Ничего не найдено!");
                return;
            }
            else
            {
                foreach (var f in regexSearchResult)
                {
                    RegexSearchRichTextBox.Text += f.ToString() + "\n";
                }
                try 
                { 
                Serialize(regexSearchResult);
                }
                catch
                {
                    MessageBox.Show("Ошибка сохранения результатов поиска по регулярному выражению в файл");
                }
            }
        }

        void Serialize(IEnumerable<Flat> searchres)
        {
            const string filepath = "..//..//..//RegexSearchFlats.json";
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Flat>));
            using (var fs = new FileStream(filepath, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, searchres);
            }
        }
    }
}
