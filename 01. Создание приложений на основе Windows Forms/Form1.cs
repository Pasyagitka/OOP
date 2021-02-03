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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FemaleSizeSM_SelectedIndexChanged(object sender, EventArgs e)
        {
            FemaleEuropeanSize.Text = Convert.ToString(Convert.ToDouble(FemaleSizeSM.Text) + 13.5);
            FemaleBelarussianSize.Text = Convert.ToString(Convert.ToDouble(FemaleSizeSM.Text) + 12.5);
            FemaleBritishSize.Text = Convert.ToString(Convert.ToDouble(FemaleSizeSM.Text) - 19d);
            FemaleAmericanSize.Text = Convert.ToString(Convert.ToDouble(FemaleSizeSM.Text) - 16.5);
        }
    }
}
