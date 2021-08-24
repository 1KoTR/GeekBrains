
namespace Task_7._2
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.BtnEnterNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(2)))), ((int)(((byte)(238)))));
            this.BtnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStartGame.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnStartGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(157)))));
            this.BtnStartGame.Location = new System.Drawing.Point(15, 14);
            this.BtnStartGame.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(177, 53);
            this.BtnStartGame.TabIndex = 0;
            this.BtnStartGame.Text = "Начать игру";
            this.BtnStartGame.UseVisualStyleBackColor = false;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // BtnEnterNumber
            // 
            this.BtnEnterNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(2)))), ((int)(((byte)(238)))));
            this.BtnEnterNumber.Enabled = false;
            this.BtnEnterNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnterNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnterNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(157)))));
            this.BtnEnterNumber.Location = new System.Drawing.Point(15, 77);
            this.BtnEnterNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnEnterNumber.Name = "BtnEnterNumber";
            this.BtnEnterNumber.Size = new System.Drawing.Size(177, 53);
            this.BtnEnterNumber.TabIndex = 1;
            this.BtnEnterNumber.Text = "Ввести число";
            this.BtnEnterNumber.UseVisualStyleBackColor = false;
            this.BtnEnterNumber.Click += new System.EventHandler(this.BtnEnterNumber_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(13)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(205, 144);
            this.Controls.Add(this.BtnEnterNumber);
            this.Controls.Add(this.BtnStartGame);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "GameForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Button BtnEnterNumber;
    }
}

