using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW__16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            openFileDlg.InitialDirectory = Application.StartupPath;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDlg.FileName);
            }
        }

        private void ShowData(String datapath)
        {
            DataStorage data = new DataStorage();
            try
            {
                data = DataStorage.DataCreator(datapath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("При загрузке данных что-то сломалось", "Oops!");
            }

            dgvRaw.DataSource = data.GetRawData();
            dgvRaw.ReadOnly = true;
            dgvSummary.DataSource = data.GetSummaryData();
            dgvSummary.ReadOnly = true;
        }
    }
}
