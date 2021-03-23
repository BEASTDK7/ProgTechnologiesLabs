using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW__14
{
    public enum DateTimeFormat
    {
        ShowTime,
        ShowDate
    }
    
    public partial class Form1 : Form
    {
        DateTimeFormat dtFormat = DateTimeFormat.ShowTime;
        ToolStripMenuItem currentCheckedItem;
        public Form1()
        {
            InitializeComponent();
            Text = "ИНС191 Кошевой ЛР14";
            CenterToScreen();
            BackColor = Color.LightGray;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
            toolStripComboBoxA.SelectedIndex = 0;
            toolStripComboBoxB.SelectedIndex = 0;
            currentCheckedItem2 = toolStripMenuItemV1;
            currentCheckedItem2.Checked = true;
        }

        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFormat == DateTimeFormat.ShowTime)
                info = DateTime.Now.ToLongTimeString();
            else
                info = DateTime.Now.ToLongDateString();
            toolStripStatusLabelClock.Text = info;
        }

        private void toolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            // установка даты
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemDate;
            currentCheckedItem.Checked = true;
        }

        private void toolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            // установка времени
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }

        // Задание 1.
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(toolStripTextBoxX.Text);
                double y = Convert.ToDouble(toolStripTextBoxY.Text);
                double z = Convert.ToDouble(toolStripTextBoxZ.Text);
                double a = Convert.ToDouble(toolStripComboBoxA.Text);
                double b = Convert.ToDouble(toolStripComboBoxB.Text);

                double result = (a * z + b * y + Math.Sin(z)) / (a + b);
                Text = String.Format("Задание 1. Результат = {0:0.000}", result);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод!", "ERROR");
            }
        }


        // Задание 2.
        ToolStripMenuItem currentCheckedItem2;

        private void toolStripMenuItemV1_Click(object sender, EventArgs e)
        {
            currentCheckedItem2.Checked = false;
            currentCheckedItem2 = toolStripMenuItemV1;
            currentCheckedItem2.Checked = true;
        }

        private void toolStripMenuItemV2_Click(object sender, EventArgs e)
        {
            currentCheckedItem2.Checked = false;
            currentCheckedItem2 = toolStripMenuItemV2;
            currentCheckedItem2.Checked = true;
        }

        private void toolStripMenuItemV3_Click(object sender, EventArgs e)
        {
            currentCheckedItem2.Checked = false;
            currentCheckedItem2 = toolStripMenuItemV3;
            currentCheckedItem2.Checked = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            double x = e.X;
            double y = e.Y;

            toolStripStatusLabelState.Text = String.Format("Координаты: ({0}; {1})", x, y);


            if (currentCheckedItem2 == toolStripMenuItemV1)
            {
                double z = Math.Sqrt(Math.Abs(Math.Pow(x, 3) - Math.Pow(y, 2)));
                toolStripStatusLabelTask2.Text = String.Format("1). z = {0:0.000}", z);
            }
            if (currentCheckedItem2 == toolStripMenuItemV2)
            {
                double f = Math.Pow(x, 2) / Math.Pow(y, 3);
                toolStripStatusLabelTask2.Text = String.Format("2). f = {0:0.000}", f);
            }
            if (currentCheckedItem2 == toolStripMenuItemV3)
            {
                double z = Math.Sin(x);
                toolStripStatusLabelTask2.Text = String.Format("3). z = {0:0.000}", z);
            }
        }
    }
}
