namespace Lab1
{
    partial class ColumnarMethForm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblnput = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.Label();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.lbKey1 = new System.Windows.Forms.Label();
            this.lbKey2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.rbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.rbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.btnExecute = new System.Windows.Forms.Button();
            this.LbLabName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(29, 118);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(210, 108);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(523, 118);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(187, 108);
            this.txtOutput.TabIndex = 10;
            this.txtOutput.TabStop = false;
            // 
            // lblnput
            // 
            this.lblnput.AutoSize = true;
            this.lblnput.Location = new System.Drawing.Point(66, 85);
            this.lblnput.Name = "lblnput";
            this.lblnput.Size = new System.Drawing.Size(135, 20);
            this.lblnput.TabIndex = 3;
            this.lblnput.Text = "Исходный текст:";
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(573, 85);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(93, 20);
            this.lbOutput.TabIndex = 4;
            this.lbOutput.Text = "Результат:";
            // 
            // txtKey1
            // 
            this.txtKey1.Location = new System.Drawing.Point(276, 118);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(210, 26);
            this.txtKey1.TabIndex = 2;
            this.txtKey1.TextChanged += new System.EventHandler(this.InputChanged);
            this.txtKey1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyTextBox_KeyPress);
            // 
            // txtKey2
            // 
            this.txtKey2.Location = new System.Drawing.Point(276, 190);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(210, 26);
            this.txtKey2.TabIndex = 3;
            this.txtKey2.TextChanged += new System.EventHandler(this.InputChanged);
            this.txtKey2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyTextBox_KeyPress);
            // 
            // lbKey1
            // 
            this.lbKey1.AutoSize = true;
            this.lbKey1.Location = new System.Drawing.Point(332, 85);
            this.lbKey1.Name = "lbKey1";
            this.lbKey1.Size = new System.Drawing.Size(106, 20);
            this.lbKey1.TabIndex = 7;
            this.lbKey1.Text = "Перый ключ:";
            // 
            // lbKey2
            // 
            this.lbKey2.AutoSize = true;
            this.lbKey2.Location = new System.Drawing.Point(332, 158);
            this.lbKey2.Name = "lbKey2";
            this.lbKey2.Size = new System.Drawing.Size(112, 20);
            this.lbKey2.TabIndex = 8;
            this.lbKey2.Text = "Второй ключ:";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(57, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 59);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(537, 326);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 59);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 33);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFile,
            this.btnSaveFile});
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(69, 29);
            this.btnFile.Text = "Файл";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.btnOpenFile.Size = new System.Drawing.Size(273, 34);
            this.btnOpenFile.Text = "Открыть";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Enabled = false;
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSaveFile.Size = new System.Drawing.Size(273, 34);
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // rbtnEncrypt
            // 
            this.rbtnEncrypt.AutoSize = true;
            this.rbtnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnEncrypt.Location = new System.Drawing.Point(330, 256);
            this.rbtnEncrypt.Name = "rbtnEncrypt";
            this.rbtnEncrypt.Size = new System.Drawing.Size(145, 24);
            this.rbtnEncrypt.TabIndex = 4;
            this.rbtnEncrypt.TabStop = true;
            this.rbtnEncrypt.Text = "Зашифровать";
            this.rbtnEncrypt.UseVisualStyleBackColor = true;
            this.rbtnEncrypt.CheckedChanged += new System.EventHandler(this.rbtnEncrypt_CheckedChanged);
            // 
            // rbtnDecrypt
            // 
            this.rbtnDecrypt.AutoSize = true;
            this.rbtnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnDecrypt.Location = new System.Drawing.Point(330, 286);
            this.rbtnDecrypt.Name = "rbtnDecrypt";
            this.rbtnDecrypt.Size = new System.Drawing.Size(152, 24);
            this.rbtnDecrypt.TabIndex = 5;
            this.rbtnDecrypt.TabStop = true;
            this.rbtnDecrypt.Text = "Расшифровать";
            this.rbtnDecrypt.UseVisualStyleBackColor = true;
            this.rbtnDecrypt.CheckedChanged += new System.EventHandler(this.rbtnDecrypt_CheckedChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecute.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(304, 326);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(162, 59);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "Выполнить";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // LbLabName
            // 
            this.LbLabName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbLabName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbLabName.Font = new System.Drawing.Font("Matura MT Script Capitals", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.LbLabName.Location = new System.Drawing.Point(0, 33);
            this.LbLabName.Name = "LbLabName";
            this.LbLabName.Size = new System.Drawing.Size(747, 49);
            this.LbLabName.TabIndex = 12;
            this.LbLabName.Text = "Столбцовый метод с двумя ключами";
            this.LbLabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbLabName.UseMnemonic = false;
            // 
            // ColumnarMethForm
            // 
            this.AcceptButton = this.btnExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(747, 397);
            this.Controls.Add(this.LbLabName);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.rbtnDecrypt);
            this.Controls.Add(this.rbtnEncrypt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbKey2);
            this.Controls.Add(this.lbKey1);
            this.Controls.Add(this.txtKey2);
            this.Controls.Add(this.txtKey1);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lblnput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ColumnarMethForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cтолбцовый метод";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColumnarMethForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblnput;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.Label lbKey1;
        private System.Windows.Forms.Label lbKey2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnOpenFile;
        private System.Windows.Forms.ToolStripMenuItem btnSaveFile;
        private System.Windows.Forms.RadioButton rbtnEncrypt;
        private System.Windows.Forms.RadioButton rbtnDecrypt;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label LbLabName;
    }
}