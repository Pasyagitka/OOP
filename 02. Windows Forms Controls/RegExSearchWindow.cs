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
            SearchWithRegex();
        } 
        private void SearchWithRegex() //linq
        {
            int mcount = 0;
            Regex regex = new Regex(@RegExInputTextBox.Text, RegexOptions.IgnoreCase);
            foreach (Flat flat in Flats.flats) 
            {
                MatchCollection matches = regex.Matches(flat.ToString());
                mcount += matches.Count;
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                        RegexSearchRichTextBox.Text += match.ToString() + "\n"; //TODO вывод всей записи и сериализация
                }
                //if (SaveSortResCheckBox.Checked == true)
                //{
                //    try
                //    {
                //        Serialize(matches);
                //    }
                //    catch
                //    {
                //        MessageBox.Show("Ошибка сохранения результатов поиска по регулярному выражению в файл");
                //    }
                //}
                
            }
            if (mcount == 0)
                MessageBox.Show("Ничего не найдено!");
        }

        //void Serialize(IEnumerable<Flat> searchres)
        //{
        //    const string filepath = "..//..//..//RegexSearchFlats.json";
        //    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Flat>));
        //    using (var fs = new FileStream(filepath, FileMode.Create))
        //    {
        //        jsonFormatter.WriteObject(fs, searchres);
        //    }
        //}
    }
}
