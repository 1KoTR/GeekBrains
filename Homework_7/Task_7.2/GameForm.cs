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
 * Используя Windows Forms, разработать игру «Угадай число». 
 * Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. 
 * Компьютер говорит, больше или меньше загаданное число введенного.
 * a) Для ввода данных от человека используется элемент TextBox;
 * б) **Реализовать отдельную форму c TextBox для ввода числа.
 * 
 */

namespace Task_7._2
{
    public partial class GameForm : Form
    {
        private int Number;

        public GameForm()
        {
            InitializeComponent();
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            BtnStartGame.Enabled = false;
            BtnEnterNumber.Enabled = true;
            MessageBox.Show("Игра началась!\n" +
                            "Вам нужно угадать число, которое загадал компьютер.", 
                            "Внимание!",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
            Number = new Random().Next(1, 101);
        }

        private void BtnEnterNumber_Click(object sender, EventArgs e)
        {
            Hide();
            new EnterNumberForm(this, Number).Show();
            BtnStartGame.Enabled = true;
            BtnEnterNumber.Enabled = false;
        }
    }
}
