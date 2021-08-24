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
 * 1. 
 * 
 * а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю. +
 * б) Добавить меню и команду «Играть». +
 *    При нажатии появляется сообщение, какое число должен получить игрок. +
 *    Игрок должен получить это число за минимальное количество ходов.
 * в) *Добавить кнопку «Отменить», которая отменяет последние ходы. 
 *    Используйте библиотечный обобщенный класс System.Collections.Generic.Stack<int>Stack.
 * Вся логика игры должна быть реализована в классе с удвоителем.
 * 
 */

namespace Task_7._1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            int number = new Random().Next(10, 1001);
            new PlayForm(this, number).Show();
            MessageBox.Show($"Игра началась!\nВам нужно получить число {number} за минимальное количество ходов.",  // б)
                            "Внимание!", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
            Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
