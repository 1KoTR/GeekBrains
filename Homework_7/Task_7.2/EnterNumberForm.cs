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
    public partial class EnterNumberForm : Form
    {
        private GameForm GameForm;
        private int Number;
        private int Attempts;

        public EnterNumberForm(GameForm gameform, int number)
        {
            InitializeComponent();

            GameForm = gameform;
            Number = number;
            Attempts = 0;
        }

        private void ShowMessage(string text)
        {
            MessageBox.Show($"{text}",
                            "Внимание!",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void BtnEnterNumber_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TxtField.Text, out int number))
                ShowMessage("Ошибка!\nВы ввели неккоректное значение.");
            else if (number == Number)
            {
                Attempts++;
                ShowMessage($"Игра завершена!\nВы угадали число за {Attempts} попыток!");

                GameForm.Show();
                Close();

            }
            else if (number > Number)
            {
                Attempts++;
                ShowMessage("Не угадали!\nВы ввели число больше загаданого.");
            }
            else if (number < Number)
            {
                Attempts++;
                ShowMessage("Не угадали!\nВы ввели число меньше загаданого.");
            }
            LblAttempts.Text = $"{Attempts}";
        }

        private void EnterNumberForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GameForm.Show();
        }
    }
}
