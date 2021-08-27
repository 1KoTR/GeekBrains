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

        void SetPage(int page)
        {
            int count = DataBase.Count;
            if (count != 0)
                nudPage.Enabled = true;
            else if (nudPage.Enabled)
                nudPage.Enabled = false;

            nudPage.Maximum = count + 1;
        }

        private void MiNewFile_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataBase = new DataBase(sfd.FileName);

                txtBox.Enabled = true;
                cBoxAnswer.Enabled = true;
            }
        }

        private void MiOpenFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //DataBase = new DataBase(ofd.FileName);

                DataBase.Load();

                SetPage(1);
            }
        }

        private void MiSaveFile_Click(object sender, EventArgs e)
        {
            DataBase.Save();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataBase.Add(txtBox.Text, cBoxAnswer.Checked);
            DataBase.Save();

            SetPage(DataBase.Count);
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }

        private void TxtBox_TextChanged(object sender, EventArgs e)
        {
            if (txtBox.Text == "")
            {
                btnAdd.Enabled = false;
                cBoxAnswer.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
                cBoxAnswer.Enabled = true;
            }
        }

        private void NudPage_ValueChanged(object sender, EventArgs e)
        {
            Question question = DataBase[(int)nudPage.Value - 1];
            txtBox.Text = question.Text;
            cBoxAnswer.Checked = question.Answer;
        }
    }
}
