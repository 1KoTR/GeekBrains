using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Чечулин Денис
 *  
 * 2. 
 * 
 * Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown.
 * 
 */

namespace Task_8._2
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void TxtBox1_TextChanged(object sender, EventArgs e)
        {
            string text = TxtBox1.Text;
            if (int.TryParse(text, out int number) && Nud1.Minimum <= number && number <= Nud1.Maximum)
                Nud1.Value = number;
        }

        private void Nud1_ValueChanged(object sender, EventArgs e)
        {
            TxtBox1.Text = Nud1.Value.ToString();
        }
    }
}
