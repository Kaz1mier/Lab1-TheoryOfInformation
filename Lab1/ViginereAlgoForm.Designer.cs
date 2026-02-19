namespace Lab1
{
    partial class ViginereAlgoForm
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
            this.LbLabName = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.rbtnDecrypt = new System.Windows.Forms.RadioButton();
            this.rbtnEncrypt = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbKey = new System.Windows.Forms.Label();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.Label();
            this.lblnput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvVisualization = new System.Windows.Forms.DataGridView();
            this.lbText = new System.Windows.Forms.Label();
            this.lbKey2 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualization)).BeginInit();
            this.SuspendLayout();
            // 
            // LbLabName
            // 
            this.LbLabName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbLabName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LbLabName.Font = new System.Drawing.Font("Matura MT Script Capitals", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
            this.LbLabName.Location = new System.Drawing.Point(0, 33);
            this.LbLabName.Name = "LbLabName";
            this.LbLabName.Size = new System.Drawing.Size(753, 91);
            this.LbLabName.TabIndex = 27;
            this.LbLabName.Text = "Алгоритм Виженера с самогенерирующиймся ключом";
            this.LbLabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbLabName.UseMnemonic = false;
            // 
            // btnExecute
            // 
            this.btnExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecute.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExecute.Enabled = false;
            this.btnExecute.Location = new System.Drawing.Point(304, 295);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(162, 59);
            this.btnExecute.TabIndex = 20;
            this.btnExecute.Text = "Выполнить";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // rbtnDecrypt
            // 
            this.rbtnDecrypt.AutoSize = true;
            this.rbtnDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnDecrypt.Location = new System.Drawing.Point(321, 251);
            this.rbtnDecrypt.Name = "rbtnDecrypt";
            this.rbtnDecrypt.Size = new System.Drawing.Size(152, 24);
            this.rbtnDecrypt.TabIndex = 19;
            this.rbtnDecrypt.TabStop = true;
            this.rbtnDecrypt.Text = "Расшифровать";
            this.rbtnDecrypt.UseVisualStyleBackColor = true;
            this.rbtnDecrypt.CheckedChanged += new System.EventHandler(this.rbtnDecrypt_CheckedChanged);
            // 
            // rbtnEncrypt
            // 
            this.rbtnEncrypt.AutoSize = true;
            this.rbtnEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnEncrypt.Location = new System.Drawing.Point(321, 205);
            this.rbtnEncrypt.Name = "rbtnEncrypt";
            this.rbtnEncrypt.Size = new System.Drawing.Size(145, 24);
            this.rbtnEncrypt.TabIndex = 17;
            this.rbtnEncrypt.TabStop = true;
            this.rbtnEncrypt.Text = "Зашифровать";
            this.rbtnEncrypt.UseVisualStyleBackColor = true;
            this.rbtnEncrypt.CheckedChanged += new System.EventHandler(this.rbtnEncrypt_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(547, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(162, 59);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.Location = new System.Drawing.Point(56, 295);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(162, 59);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.Location = new System.Drawing.Point(355, 139);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(54, 20);
            this.lbKey.TabIndex = 22;
            this.lbKey.Text = "Ключ:";
            // 
            // txtKey1
            // 
            this.txtKey1.Location = new System.Drawing.Point(283, 173);
            this.txtKey1.MaxLength = 300;
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.Size = new System.Drawing.Size(210, 26);
            this.txtKey1.TabIndex = 14;
            this.txtKey1.TextChanged += new System.EventHandler(this.InputChanged);
            this.txtKey1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKey_KeyPress);
            // 
            // lbOutput
            // 
            this.lbOutput.AutoSize = true;
            this.lbOutput.Location = new System.Drawing.Point(584, 124);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(93, 20);
            this.lbOutput.TabIndex = 18;
            this.lbOutput.Text = "Результат:";
            // 
            // lblnput
            // 
            this.lblnput.AutoSize = true;
            this.lblnput.Location = new System.Drawing.Point(70, 124);
            this.lblnput.Name = "lblnput";
            this.lblnput.Size = new System.Drawing.Size(135, 20);
            this.lblnput.TabIndex = 16;
            this.lblnput.Text = "Исходный текст:";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(537, 154);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(187, 108);
            this.txtOutput.TabIndex = 25;
            this.txtOutput.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(24, 154);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(210, 108);
            this.txtInput.TabIndex = 13;
            this.txtInput.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 33);
            this.menuStrip1.TabIndex = 26;
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
            // dgvVisualization
            // 
            this.dgvVisualization.AllowUserToAddRows = false;
            this.dgvVisualization.AllowUserToDeleteRows = false;
            this.dgvVisualization.AllowUserToResizeColumns = false;
            this.dgvVisualization.AllowUserToResizeRows = false;
            this.dgvVisualization.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvVisualization.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVisualization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualization.ColumnHeadersVisible = false;
            this.dgvVisualization.Location = new System.Drawing.Point(175, 395);
            this.dgvVisualization.Name = "dgvVisualization";
            this.dgvVisualization.ReadOnly = true;
            this.dgvVisualization.RowHeadersVisible = false;
            this.dgvVisualization.RowHeadersWidth = 62;
            this.dgvVisualization.RowTemplate.Height = 28;
            this.dgvVisualization.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvVisualization.Size = new System.Drawing.Size(578, 125);
            this.dgvVisualization.TabIndex = 28;
            this.dgvVisualization.TabStop = false;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(20, 395);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(135, 20);
            this.lbText.TabIndex = 29;
            this.lbText.Text = "Исходный текст:";
            this.lbText.Visible = false;
            // 
            // lbKey2
            // 
            this.lbKey2.AutoSize = true;
            this.lbKey2.Location = new System.Drawing.Point(20, 428);
            this.lbKey2.Name = "lbKey2";
            this.lbKey2.Size = new System.Drawing.Size(54, 20);
            this.lbKey2.TabIndex = 30;
            this.lbKey2.Text = "Ключ:";
            this.lbKey2.Visible = false;
            // 
            // lbResult
            // 
            this.lbResult.Location = new System.Drawing.Point(20, 463);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(149, 45);
            this.lbResult.TabIndex = 31;
            this.lbResult.Text = "Зашифрованный текст:";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbResult.UseMnemonic = false;
            this.lbResult.Visible = false;
            // 
            // ViginereAlgoForm
            // 
            this.AcceptButton = this.btnExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnBack;
            this.ClientSize = new System.Drawing.Size(753, 538);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lbKey2);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.dgvVisualization);
            this.Controls.Add(this.LbLabName);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.rbtnDecrypt);
            this.Controls.Add(this.rbtnEncrypt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.txtKey1);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lblnput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ViginereAlgoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Алгоритм Виженера с самогенерирующиймся ключом";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColumnarMethForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbLabName;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.RadioButton rbtnDecrypt;
        private System.Windows.Forms.RadioButton rbtnEncrypt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.Label lbOutput;
        private System.Windows.Forms.Label lblnput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnOpenFile;
        private System.Windows.Forms.ToolStripMenuItem btnSaveFile;
        private System.Windows.Forms.DataGridView dgvVisualization;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbKey2;
        private System.Windows.Forms.Label lbResult;
    }
}