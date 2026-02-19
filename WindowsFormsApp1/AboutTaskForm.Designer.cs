namespace WindowsFormsApp1
{
    partial class AboutTaskForm
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
            this.LbTask = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbTask
            // 
            this.LbTask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbTask.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbTask.Location = new System.Drawing.Point(0, 0);
            this.LbTask.Name = "LbTask";
            this.LbTask.Size = new System.Drawing.Size(661, 275);
            this.LbTask.TabIndex = 6;
            this.LbTask.Text = "Разработчик: Голубёнок Антон Александрович ";
            this.LbTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbTask.Click += new System.EventHandler(this.LbName_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.Location = new System.Drawing.Point(0, 275);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(661, 78);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseMnemonic = false;
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // AboutTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 353);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LbTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Задание";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LbTask;
        private System.Windows.Forms.Button BtnBack;
    }
}