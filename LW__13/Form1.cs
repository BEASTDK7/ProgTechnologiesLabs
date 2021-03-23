using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW__13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxB.SelectedIndex = 0;
            listBoxC.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                double Z = 0;
                double p = Convert.ToDouble(textBoxP.Text);
                int Qnt = Convert.ToInt32(textBoxQnt.Text);
                int N = Convert.ToInt32(textBoxN.Text);
                int R = Convert.ToInt32(textBoxR.Text);
                double b = Convert.ToDouble(comboBoxB.Text);
                double c = Convert.ToDouble(listBoxC.Text);

                if (radioButton1.Checked)
                {
                    Z = 0; int factorial = 1;
                    for (int i = 1; i <= Qnt; i++)
                    {
                        factorial *= i + 1;
                        Z += -Math.Pow(-p, i + 1) / factorial;
                    }
                }
                else
                {
                    Z = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        for(int j = 1; j <= R; j++)
                        {
                            Z += (Math.Pow(i, 2) + b * j) / (c * Math.Pow(i, 3));
                        }
                    }
                }
                textBoxZ.Text = String.Format("{0:0.000}", Z);
            }
            catch
            {
                errorProvider1.SetError(textBoxZ, "ERROR");
                MessageBox.Show("Something went wrong!");
            }
        }
    }
}
