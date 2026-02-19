namespace Lab1
{
    partial class MenuForm
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
            this.BtnColumnarMeth = new System.Windows.Forms.Button();
            this.BtnViginerAlgo = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LbLabName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BtnAboutDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAbutTask = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnColumnarMeth
            // 
            this.BtnColumnarMeth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnColumnarMeth.AutoSize = true;
            this.BtnColumnarMeth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColumnarMeth.Location = new System.Drawing.Point(187, 154);
            this.BtnColumnarMeth.Name = "BtnColumnarMeth";
            this.BtnColumnarMeth.Size = new System.Drawing.Size(174, 57);
            this.BtnColumnarMeth.TabIndex = 1;
            this.BtnColumnarMeth.Text = "Столбцовый метод";
            this.BtnColumnarMeth.UseVisualStyleBackColor = true;
            this.BtnColumnarMeth.Click += new System.EventHandler(this.BtnColumnarMeth_Click);
            // 
            // BtnViginerAlgo
            // 
            this.BtnViginerAlgo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnViginerAlgo.AutoSize = true;
            this.BtnViginerAlgo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnViginerAlgo.Location = new System.Drawing.Point(187, 231);
            this.BtnViginerAlgo.Name = "BtnViginerAlgo";
            this.BtnViginerAlgo.Size = new System.Drawing.Size(174, 68);
            this.BtnViginerAlgo.TabIndex = 2;
            this.BtnViginerAlgo.Text = "Алгоритм Вижинера";
            this.BtnViginerAlgo.UseVisualStyleBackColor = true;
            this.BtnViginerAlgo.Click += new System.EventHandler(this.BtnViginerAlgo_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.AutoSize = true;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnExit.Location = new System.Drawing.Point(187, 321);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(174, 59);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Выход";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LbLabName
            // 
            this.LbLabName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbLabName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbLabName.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbLabName.Location = new System.Drawing.Point(0, 36);
            this.LbLabName.Name = "LbLabName";
            this.LbLabName.Size = new System.Drawing.Size(518, 106);
            this.LbLabName.TabIndex = 4;
            this.LbLabName.Text = "Простейшие алгоритмы шифрования";
            this.LbLabName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAboutDeveloper,
            this.BtnAbutTask});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 36);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BtnAboutDeveloper
            // 
            this.BtnAboutDeveloper.Name = "BtnAboutDeveloper";
            this.BtnAboutDeveloper.Size = new System.Drawing.Size(161, 32);
            this.BtnAboutDeveloper.Tag = "4";
            this.BtnAboutDeveloper.Text = "О разработчике";
            this.BtnAboutDeveloper.Click += new System.EventHandler(this.BtnAboutDeveloper_Click);
            // 
            // BtnAbutTask
            // 
            this.BtnAbutTask.Name = "BtnAbutTask";
            this.BtnAbutTask.Size = new System.Drawing.Size(95, 32);
            this.BtnAbutTask.Tag = "5";
            this.BtnAbutTask.Text = "Задание";
            this.BtnAbutTask.Click += new System.EventHandler(this.BtnAbutTask_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(518, 450);
            this.Controls.Add(this.LbLabName);
            this.Controls.Add(this.BtnColumnarMeth);
            this.Controls.Add(this.BtnViginerAlgo);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnColumnarMeth;
        private System.Windows.Forms.Button BtnViginerAlgo;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LbLabName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem BtnAboutDeveloper;
        private System.Windows.Forms.ToolStripMenuItem BtnAbutTask;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

