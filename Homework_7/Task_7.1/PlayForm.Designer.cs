
namespace Task_7._1
{
    partial class PlayForm
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
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnPlusOne = new System.Windows.Forms.Button();
            this.BtnMultiplyByTwo = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.LblAttempts = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LblCancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.BtnReset.Enabled = false;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReset.Location = new System.Drawing.Point(12, 12);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(208, 55);
            this.BtnReset.TabIndex = 0;
            this.BtnReset.Text = "Сбросить";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnPlusOne
            // 
            this.BtnPlusOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.BtnPlusOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlusOne.Location = new System.Drawing.Point(12, 73);
            this.BtnPlusOne.Name = "BtnPlusOne";
            this.BtnPlusOne.Size = new System.Drawing.Size(101, 55);
            this.BtnPlusOne.TabIndex = 1;
            this.BtnPlusOne.Text = "+1";
            this.BtnPlusOne.UseVisualStyleBackColor = false;
            this.BtnPlusOne.Click += new System.EventHandler(this.BtnPlusOne_Click);
            // 
            // BtnMultiplyByTwo
            // 
            this.BtnMultiplyByTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.BtnMultiplyByTwo.Enabled = false;
            this.BtnMultiplyByTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiplyByTwo.Location = new System.Drawing.Point(119, 73);
            this.BtnMultiplyByTwo.Name = "BtnMultiplyByTwo";
            this.BtnMultiplyByTwo.Size = new System.Drawing.Size(101, 55);
            this.BtnMultiplyByTwo.TabIndex = 2;
            this.BtnMultiplyByTwo.Text = "•2";
            this.BtnMultiplyByTwo.UseVisualStyleBackColor = false;
            this.BtnMultiplyByTwo.Click += new System.EventHandler(this.BtnMultiplyByTwo_Click);
            // 
            // LblResult
            // 
            this.LblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.LblResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblResult.Location = new System.Drawing.Point(225, 13);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(186, 54);
            this.LblResult.TabIndex = 3;
            this.LblResult.Text = "Результат: 0";
            this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblAttempts
            // 
            this.LblAttempts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblAttempts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblAttempts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.LblAttempts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblAttempts.Location = new System.Drawing.Point(225, 73);
            this.LblAttempts.Name = "LblAttempts";
            this.LblAttempts.Size = new System.Drawing.Size(186, 54);
            this.LblAttempts.TabIndex = 4;
            this.LblAttempts.Text = "Попытки: 0";
            this.LblAttempts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.BtnCancel.Enabled = false;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.Location = new System.Drawing.Point(12, 134);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(208, 30);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Отменить";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LblCancel
            // 
            this.LblCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LblCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(134)))), ((int)(((byte)(252)))));
            this.LblCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblCancel.Location = new System.Drawing.Point(226, 134);
            this.LblCancel.Name = "LblCancel";
            this.LblCancel.Size = new System.Drawing.Size(186, 30);
            this.LblCancel.TabIndex = 6;
            this.LblCancel.Text = "Отмены: 0";
            this.LblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(444, 178);
            this.Controls.Add(this.LblCancel);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.LblAttempts);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnMultiplyByTwo);
            this.Controls.Add(this.BtnPlusOne);
            this.Controls.Add(this.BtnReset);
            this.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnPlusOne;
        private System.Windows.Forms.Button BtnMultiplyByTwo;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Label LblAttempts;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblCancel;
    }
}