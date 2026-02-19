namespace WindowsFormsApp1
{
    partial class AboutDeveloperForm
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
            this.LbName = new System.Windows.Forms.Label();
            this.LbGroup = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbName
            // 
            this.LbName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LbName.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbName.Location = new System.Drawing.Point(0, 0);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(579, 176);
            this.LbName.TabIndex = 5;
            this.LbName.Text = "Разработчик: Голубёнок Антон Александрович ";
            this.LbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbName.Click += new System.EventHandler(this.LbLabName_Click);
            // 
            // LbGroup
            // 
            this.LbGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbGroup.AutoSize = true;
            this.LbGroup.Font = new System.Drawing.Font("Matura MT Script Capitals", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LbGroup.Location = new System.Drawing.Point(51, 130);
            this.LbGroup.Name = "LbGroup";
            this.LbGroup.Size = new System.Drawing.Size(157, 24);
            this.LbGroup.TabIndex = 6;
            this.LbGroup.Text = "Группа: 451003";
            this.LbGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbGroup.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnBack.Location = new System.Drawing.Point(0, 176);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(579, 74);
            this.BtnBack.TabIndex = 7;
            this.BtnBack.Text = "Назад";
            this.BtnBack.UseMnemonic = false;
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // AboutDeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 250);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.LbGroup);
            this.Controls.Add(this.LbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDeveloperForm";
            this.Text = "О разработчике";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label LbGroup;
        private System.Windows.Forms.Button BtnBack;
    }
}