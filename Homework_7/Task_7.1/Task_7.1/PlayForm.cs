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
    public partial class PlayForm : Form
    {
        private MenuForm MenuForm;
        private int Number;
        private Stack<int> StackNumbers;
        private int Result;
        private int Attempts;
        private int Moves;
        private int Cancels;

        public PlayForm(MenuForm menuForm, int number)
        {
            InitializeComponent();
            Text += $" ({number})";

            MenuForm = menuForm;
            Number = number;
            StackNumbers = new Stack<int>();
            StackNumbers.Push(0);
            Result = 0;
            Attempts = 0;
            Moves = 0;
            Cancels = 0;
        }

        private void CloseGame(string text)
        {
            MessageBox.Show(text + 
                            "\nВаш рещультат:\n" +
                            $" - Колчество попыток: {Attempts}\n" +
                            $" - Количество ходов: {++Moves}\n" +
                            $" - Количесто отмен: {Cancels}", 
                            "Внимание!", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
            Close();
            MenuForm.Show();
        }

        private void EnableButton(Button btn)
        {
            if (!btn.Enabled)
                btn.Enabled = true;
        } 

        private void UpdateResult()
        {
            if (Result > Number)
                CloseGame("Вы проиграли!");
            else if (Result == Number)
                CloseGame("Вы победили!");

            LblResult.Text = $"Результат: {Result}";
        }

        private void UpdateAttempts()
        {
            LblAttempts.Text = $"Попытки: {Attempts}{(Moves > 0 ? $" ({Moves})" : "")}";  // а)
        }

        private void UpdateCancels()
        {
            if (Result == 0)
            {
                BtnCancel.Enabled = false;
                BtnMultiplyByTwo.Enabled = false;
            }
            LblCancel.Text = $"Отмены: {Cancels}";
        }

        #region Кнопки

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Result = 0;
            UpdateResult();
            StackNumbers.Clear();
            StackNumbers.Push(0);

            Moves = 0;
            Attempts++;
            UpdateAttempts();

            Cancels = 0;
            UpdateCancels();

            BtnReset.Enabled = false;
            BtnMultiplyByTwo.Enabled = false;
            BtnCancel.Enabled = false;
        }

        private void BtnPlusOne_Click(object sender, EventArgs e)
        {
            StackNumbers.Push(Result);
            Result++;
            UpdateResult();

            Moves++;
            UpdateAttempts();

            EnableButton(BtnReset);
            EnableButton(BtnMultiplyByTwo);
            EnableButton(BtnCancel);
        }

        private void BtnMultiplyByTwo_Click(object sender, EventArgs e)
        {
            StackNumbers.Push(Result);
            Result *= 2;
            UpdateResult();

            Moves++;
            UpdateAttempts();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Result = StackNumbers.Pop();
            UpdateResult();

            Cancels++;
            UpdateCancels();
        }

        #endregion
    }
}
