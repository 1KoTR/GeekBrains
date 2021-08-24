
namespace Task_7._2
{
    partial class EnterNumberForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.LblAttempts = new System.Windows.Forms.Label();
            this.BtnEnterNumber = new System.Windows.Forms.Button();
            this.TxtField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(98)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(9, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Попытки:";
            // 
            // LblAttempts
            // 
            this.LblAttempts.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAttempts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(157)))));
            this.LblAttempts.Location = new System.Drawing.Point(105, 112);
            this.LblAttempts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblAttempts.Name = "LblAttempts";
            this.LblAttempts.Size = new System.Drawing.Size(85, 30);
            this.LblAttempts.TabIndex = 4;
            this.LblAttempts.Text = "0";
            // 
            // BtnEnterNumber
            // 
            this.BtnEnterNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(2)))), ((int)(((byte)(238)))));
            this.BtnEnterNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEnterNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnterNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(157)))));
            this.BtnEnterNumber.Location = new System.Drawing.Point(13, 54);
            this.BtnEnterNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnEnterNumber.Name = "BtnEnterNumber";
            this.BtnEnterNumber.Size = new System.Drawing.Size(177, 53);
            this.BtnEnterNumber.TabIndex = 5;
            this.BtnEnterNumber.Text = "Попробовать";
            this.BtnEnterNumber.UseVisualStyleBackColor = false;
            this.BtnEnterNumber.Click += new System.EventHandler(this.BtnEnterNumber_Click);
            // 
            // TxtField
            // 
            this.TxtField.Location = new System.Drawing.Point(13, 13);
            this.TxtField.Name = "TxtField";
            this.TxtField.Size = new System.Drawing.Size(177, 33);
            this.TxtField.TabIndex = 6;
            this.TxtField.Text = "Введите число";
            this.TxtField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnterNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(13)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(205, 147);
            this.Controls.Add(this.TxtField);
            this.Controls.Add(this.BtnEnterNumber);
            this.Controls.Add(this.LblAttempts);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EnterNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EnterNumberForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblAttempts;
        private System.Windows.Forms.Button BtnEnterNumber;
        private System.Windows.Forms.TextBox TxtField;
    }
}