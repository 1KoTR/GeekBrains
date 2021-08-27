
namespace Task_8._2
{
    partial class MainForm
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
            this.Nud1 = new System.Windows.Forms.NumericUpDown();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nud1
            // 
            this.Nud1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.Nud1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nud1.ForeColor = System.Drawing.SystemColors.Window;
            this.Nud1.Location = new System.Drawing.Point(12, 12);
            this.Nud1.Name = "Nud1";
            this.Nud1.Size = new System.Drawing.Size(120, 16);
            this.Nud1.TabIndex = 0;
            this.Nud1.ValueChanged += new System.EventHandler(this.Nud1_ValueChanged);
            // 
            // TxtBox1
            // 
            this.TxtBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(29)))), ((int)(((byte)(50)))));
            this.TxtBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.TxtBox1.Location = new System.Drawing.Point(12, 47);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(120, 13);
            this.TxtBox1.TabIndex = 1;
            this.TxtBox1.TextChanged += new System.EventHandler(this.TxtBox1_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(147, 72);
            this.Controls.Add(this.TxtBox1);
            this.Controls.Add(this.Nud1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Nud1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Nud1;
        private System.Windows.Forms.TextBox TxtBox1;
    }
}

