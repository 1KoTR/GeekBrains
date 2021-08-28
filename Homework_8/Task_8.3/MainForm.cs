using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_8._3
{
    public partial class MainForm : Form
    {
        DataBase DataBase;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MiNewFile_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataBase = new DataBase(sfd.FileName);
                DataBase.Save();

                nudPage.Value = 1;
                nudPage.Maximum = 1;

                miSaveFile.Enabled = true;
                txtBox.Enabled = true;
                cBoxAnswer.Enabled = true;
                nudPage.Enabled = true;
            }

        }

        private void MiOpenFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DataBase = new DataBase(ofd.FileName);
                DataBase.Load();

                nudPage.Enabled = true;

                nudPage.Maximum = 2;
                nudPage.Value = 2;
                nudPage.Value = 1;
                nudPage.Maximum = DataBase.Count;
            }
        }

        private void MiSaveFile_Click(object sender, EventArgs e)
        {
            DataBase.Remove((int)nudPage.Value - 1);
            DataBase.Add(txtBox.Text, cBoxAnswer.Checked);
            DataBase.Save();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataBase.Remove((int)nudPage.Value - 1);
            DataBase.Add(txtBox.Text, cBoxAnswer.Checked);
            DataBase.Add("", false);

            DataBase.Save();

            nudPage.Maximum++;
            nudPage.Value = nudPage.Maximum;
        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (txtBox.Text == "")
                btnAdd.Enabled = false;
            else
                btnAdd.Enabled = true;
        }

        private void NudPage_ValueChanged(object sender, EventArgs e)
        {
            int page = (int)nudPage.Value;
            int maxPage = (int)nudPage.Maximum;

            txtBox.Text = DataBase[page - 1].Text;
            cBoxAnswer.Checked = DataBase[page - 1].Answer;

            if (page != maxPage)
            {
                txtBox.Enabled = false;
                cBoxAnswer.Enabled = false;
                btnAdd.Enabled = false;
            }
            else
            {
                txtBox.Enabled = true;
                cBoxAnswer.Enabled = true;
            }
        }
    }
}
