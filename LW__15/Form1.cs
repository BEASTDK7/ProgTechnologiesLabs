using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LW__15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.FullOpen = true;
            dlg.ShowHelp = true;
            dlg.Color = panelChooseColor.BackColor;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                panelChooseColor.BackColor = dlg.Color;
                labelForU.BackColor = dlg.Color;
            }
        }

        private void btnChooseFont_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.ShowColor = true;
            dlg.ShowHelp = true;
            dlg.Font = txtChooseFont.Font;
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFont.Font = dlg.Font;
                labelForU.Font = dlg.Font;
                txtChooseFont.ForeColor = dlg.Color;
                labelForU.ForeColor = dlg.Color;
            }
        }

        private void btnChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.Description = "Выберите каталог";
            dlg.ShowNewFolderButton = true;
            dlg.SelectedPath = Application.StartupPath;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtChooseFolder.Text = dlg.SelectedPath;
            }
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBoxX.Text);
                double y = Convert.ToDouble(textBoxY.Text);
                double Qnt = Convert.ToDouble(textBoxQnt.Text);

                double U = 0; int j = 1;

                if (Qnt > 0)
                {
                    for (int i = 1; i <= Qnt; i++)
                    {
                        U += Math.Pow(-Math.Sin(x), i + 1) * Math.Pow(y, j) / (i + 1);
                        j += 2;
                    }

                    labelForU.Text = String.Format("U = {0:0.000}", 1 - U);
                }
                                
                if (txtChooseFolder.Text != "")
                {
                    string file = Path.Combine(txtChooseFolder.Text, "LW15_Result.txt");
                    File.WriteAllText(file, Convert.ToString(1 - U));
                }
            }
            catch
            {
                MessageBox.Show("Некорректный ввод!", "Oops!");
            }
        }
    }
}
