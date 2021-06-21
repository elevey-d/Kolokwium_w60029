using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kolokwium_w60029
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bResult_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1 && !(textBox1.Text == ""))
            {
                float res = float.Parse(textBox1.Text);
                double temp1, temp2;
                if (comboBox1.SelectedIndex == 0)
                {
                    lCel.Text = res.ToString();
                    temp1 = ((res * 1.8) + 32);
                    lFah.Text =(Math.Round(temp1, 2)).ToString();
                    temp2 = (res + 273.15);
                    lKel.Text = (Math.Round(temp2, 2)).ToString();
                }
                else if(comboBox1.SelectedIndex == 1)
                {
                    temp1 = (res - 32) / 1.8;
                    lCel.Text = (Math.Round(temp1, 2)).ToString();
                    lFah.Text = res.ToString();
                    temp2 = (res + 459.67) * 5 / 9;
                    lKel.Text = (Math.Round(temp2, 2)).ToString();
                }
                else if(comboBox1.SelectedIndex == 2) {
                    temp1 = res - 273.15;
                    lCel.Text = (Math.Round(temp1, 2)).ToString();
                    temp2 = (res * 1.8) - 459.67;
                    lFah.Text = (Math.Round(temp2, 2)).ToString();
                    lKel.Text = res.ToString();
                }
            }
            else
            {
                MessageBox.Show("Nie wybraleś żadnej opcji!");
            }
        }
    }
}
