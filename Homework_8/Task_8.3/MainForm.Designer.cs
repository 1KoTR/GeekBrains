
namespace Task_8._3
{
    partial class MainForm
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
            this.tsPanel = new System.Windows.Forms.ToolStrip();
            this.btnFileMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.miNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cBoxAnswer = new System.Windows.Forms.CheckBox();
            this.nudPage = new System.Windows.Forms.NumericUpDown();
            this.tsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).BeginInit();
            this.SuspendLayout();
            // 
            // tsPanel
            // 
            this.tsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsPanel.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.tsPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileMenu});
            this.tsPanel.Location = new System.Drawing.Point(0, 0);
            this.tsPanel.Name = "tsPanel";
            this.tsPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsPanel.Size = new System.Drawing.Size(418, 25);
            this.tsPanel.TabIndex = 0;
            // 
            // btnFileMenu
            // 
            this.btnFileMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewFile,
            this.miOpenFile,
            this.miSaveFile});
            this.btnFileMenu.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnFileMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFileMenu.Name = "btnFileMenu";
            this.btnFileMenu.Size = new System.Drawing.Size(52, 22);
            this.btnFileMenu.Text = "Файл";
            // 
            // miNewFile
            // 
            this.miNewFile.Name = "miNewFile";
            this.miNewFile.Size = new System.Drawing.Size(180, 22);
            this.miNewFile.Text = "Новый";
            this.miNewFile.Click += new System.EventHandler(this.MiNewFile_Click);
            // 
            // miOpenFile
            // 
            this.miOpenFile.Name = "miOpenFile";
            this.miOpenFile.Size = new System.Drawing.Size(180, 22);
            this.miOpenFile.Text = "Открыть";
            this.miOpenFile.Click += new System.EventHandler(this.MiOpenFile_Click);
            // 
            // miSaveFile
            // 
            this.miSaveFile.Enabled = false;
            this.miSaveFile.Name = "miSaveFile";
            this.miSaveFile.Size = new System.Drawing.Size(180, 22);
            this.miSaveFile.Text = "Сохранить";
            this.miSaveFile.Click += new System.EventHandler(this.MiSaveFile_Click);
            // 
            // txtBox
            // 
            this.txtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBox.Enabled = false;
            this.txtBox.Location = new System.Drawing.Point(0, 25);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(418, 189);
            this.txtBox.TabIndex = 1;
            this.txtBox.TextChanged += new System.EventHandler(this.TxtBox_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAdd.Location = new System.Drawing.Point(12, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cBoxAnswer
            // 
            this.cBoxAnswer.AutoSize = true;
            this.cBoxAnswer.Enabled = false;
            this.cBoxAnswer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cBoxAnswer.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cBoxAnswer.Location = new System.Drawing.Point(346, 224);
            this.cBoxAnswer.Name = "cBoxAnswer";
            this.cBoxAnswer.Size = new System.Drawing.Size(78, 22);
            this.cBoxAnswer.TabIndex = 5;
            this.cBoxAnswer.Text = "Правда";
            this.cBoxAnswer.UseVisualStyleBackColor = true;
            // 
            // nudPage
            // 
            this.nudPage.Enabled = false;
            this.nudPage.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.nudPage.Location = new System.Drawing.Point(192, 224);
            this.nudPage.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPage.Name = "nudPage";
            this.nudPage.Size = new System.Drawing.Size(148, 22);
            this.nudPage.TabIndex = 6;
            this.nudPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPage.ValueChanged += new System.EventHandler(this.NudPage_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(418, 256);
            this.Controls.Add(this.nudPage);
            this.Controls.Add(this.cBoxAnswer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.tsPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Верю - Не верю";
            this.tsPanel.ResumeLayout(false);
            this.tsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPanel;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.ToolStripDropDownButton btnFileMenu;
        private System.Windows.Forms.ToolStripMenuItem miNewFile;
        private System.Windows.Forms.ToolStripMenuItem miOpenFile;
        private System.Windows.Forms.ToolStripMenuItem miSaveFile;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cBoxAnswer;
        private System.Windows.Forms.NumericUpDown nudPage;
    }
}