using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01.Создание_приложений_на_основе_Windows_Forms
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FemaleSizeSM_SelectedIndexChanged(object sender, EventArgs e)
        {
            EuropeanSizeSelect.Text = Convert.ToString(Convert.ToDouble(FemaleSizeSM.Text) + 13.5);
            BelarussianSizeSelect.Text = Convert.ToString(Convert.ToDouble(FemaleSizeSM.Text) + 12.5);
            AmericanSizeSelect.Text = Convert.ToString(Convert.ToDouble(FemaleSizeSM.Text) - 19d);
            BritishSizeSelect.Text = Convert.ToString(Convert.ToDouble(FemaleSizeSM.Text) - 16.5);
        }

        private void MaleSizeSM_SelectedIndexChanged(object sender, EventArgs e)
        {
            EuropeanSizeSelect.Text = Convert.ToString(Convert.ToDouble(MaleSizeSM.Text) + 13.5);
            BelarussianSizeSelect.Text = Convert.ToString(Convert.ToDouble(MaleSizeSM.Text) + 12.5);
            AmericanSizeSelect.Text = Convert.ToString(Convert.ToDouble(MaleSizeSM.Text) - 19d);
            BritishSizeSelect.Text = Convert.ToString(Convert.ToDouble(MaleSizeSM.Text) - 16.5);
        }


        private void EuropeanSizeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string convertingsize = Convert.ToString(Convert.ToDouble(EuropeanSizeSelect.Text) - 13.5);
            if (MaleSizeSM.Items.Contains(convertingsize))
            {
                MaleSizeSM.Text = convertingsize;
            }
            if (FemaleSizeSM.Items.Contains(convertingsize))
            {
                FemaleSizeSM.Text = convertingsize;
            }
        }

        private void BelarussianSizeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string convertingsize = Convert.ToString(Convert.ToDouble(BelarussianSizeSelect.Text) - 12.5);
            if (MaleSizeSM.Items.Contains(convertingsize))
            {
                MaleSizeSM.Text = convertingsize;
            }
            if (FemaleSizeSM.Items.Contains(convertingsize))
            {
                FemaleSizeSM.Text = convertingsize;
            }
        }

        private void AmericanSizeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string convertingsize = Convert.ToString(Convert.ToDouble(AmericanSizeSelect.Text) + 19d);
            if (MaleSizeSM.Items.Contains(convertingsize))
            {
                MaleSizeSM.Text = convertingsize;
            }
            if (FemaleSizeSM.Items.Contains(convertingsize))
            {
                FemaleSizeSM.Text = convertingsize;
            }
        }

        private void BritishSizeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string convertingsize = Convert.ToString(Convert.ToDouble(BritishSizeSelect.Text) + 16.5);
            if (MaleSizeSM.Items.Contains(convertingsize))
            {
                MaleSizeSM.Text = convertingsize;
            }
            if (FemaleSizeSM.Items.Contains(convertingsize))
            {
                FemaleSizeSM.Text = convertingsize;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FemaleSizeSM_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                throw new Exception("Поле должно быть пустым");
        }
    }
}
