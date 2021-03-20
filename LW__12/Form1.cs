using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW__12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        float f, w, my_e, my_t;
        double Tt;

        private void textBoxE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                my_e = System.Convert.ToSingle(textBoxE.Text);
                Tt = GetValue(f, w, my_e, my_t);
                Text = GetTitleResult(Tt);
            }

            catch
            {
                Text = "ERROR";
            }
        }

        private void textBoxT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                my_t = System.Convert.ToSingle(textBoxT.Text);
                Tt = GetValue(f, w, my_e, my_t);
                Text = GetTitleResult(Tt);
            }

            catch
            {
                Text = "ERROR";
            }
        }
                                     
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            f = e.X;
            w = e.Y;
            Tt = GetValue(f, w, my_e, my_t);
            Text = GetTitleResult(Tt);

            textBoxF.Text = e.X.ToString();
            textBoxW.Text = e.Y.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        double GetValue(float f, float w, float e, float t)
        {
            double result = Math.Log10(f) - e + Math.Abs(Math.Sin(w / t) + Math.Sqrt(Math.Abs(e)));
            return result;
        }

        string GetTitleResult(double X)
        {
            if (Double.IsInfinity(X) || Double.IsNaN(X))
            {
                return "ERROR";
            }
            else
            {
                return string.Format("t = {0:0.00}", X);
            }
        }
    }
}
