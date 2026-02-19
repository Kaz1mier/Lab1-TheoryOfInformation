using Lab1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViginereAlgoForm : Form
    {

        private const string RussianAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private bool encryptMode = true;
        public ViginereAlgoForm()
        {
            InitializeComponent();
            rbtnEncrypt.Checked = true;
        }


        private void btnBack_Click(object sender, EventArgs e) => Close();

        private void ColumnarMethForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MenuForm)
                {
                    form.Show();
                    break;
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                FilterIndex = 1
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txtInput.Text = File.ReadAllText(dlg.FileName, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка");
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length == 0)
            {
                MessageBox.Show("Нет данных для сохранения!", "Ошибка");
                return;
            }

            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                FilterIndex = 1
            };

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(dlg.FileName, txtOutput.Text, Encoding.UTF8);
                    MessageBox.Show("Файл успешно сохранен!", "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка");
                }
            }
        }

        private void UpdateButtons()
        {
            btnExecute.Enabled =
                txtInput.TextLength > 0 &&
                txtKey1.TextLength > 0;

            btnSaveFile.Enabled = txtOutput.TextLength > 0;
        }


        private void InputChanged(object sender, EventArgs e)
        {
            txtOutput.Clear();
            UpdateButtons();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtKey1.Clear();
            rbtnEncrypt.Checked = true;
        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) &&
                !RussianAlphabet.Contains(c.ToString()))
                e.Handled = true;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (encryptMode)
                txtOutput.Text = VigenereAutokey.Encrypt(txtInput.Text, txtKey1.Text);
            else
                txtOutput.Text = VigenereAutokey.Decrypt(txtInput.Text, txtKey1.Text);

            UpdateButtons();
        }

        private void rbtnEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEncrypt.Checked) encryptMode = true;
            txtOutput.Clear();
            txtOutput.Text = VigenereAutokey.Encrypt(txtInput.Text, txtKey1.Text);
            UpdateButtons();
        }

        private void rbtnDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDecrypt.Checked) encryptMode = false;
            txtOutput.Clear();
            txtOutput.Text = VigenereAutokey.Decrypt(txtInput.Text, txtKey1.Text);
            UpdateButtons();
        }

    }
}
