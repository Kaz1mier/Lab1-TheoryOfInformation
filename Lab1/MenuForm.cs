using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BtnColumnarMeth_Click(object sender, EventArgs e)
        {
            ColumnarMethForm columnarForm = new ColumnarMethForm();
            columnarForm.Show();
            this.Hide(); 
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            bool otherFormsOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form != this && form.Visible)
                {
                    otherFormsOpen = true;
                    break;
                }
            }

            if (otherFormsOpen)
            {
                e.Cancel = true;
                this.Hide(); 
            }
            else
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void BtnAboutDeveloper_Click(object sender, EventArgs e)
        {
            AboutDeveloperForm aboutForm = new AboutDeveloperForm();
            aboutForm.ShowDialog();
        }

        private void BtnAbutTask_Click(object sender, EventArgs e)
        {
            AboutTaskForm aboutForm = new AboutTaskForm();
            aboutForm.ShowDialog();
        }

        private void BtnViginerAlgo_Click(object sender, EventArgs e)
        {
            ViginereAlgoForm viginereForm = new ViginereAlgoForm();
            viginereForm.Show();
            this.Hide(); 
        }
    }
}