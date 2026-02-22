using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Lab1
{
    public partial class ViginereAlgoForm : Form
    {
        private bool encryptMode = true;
        private const int MaxVisualizationLength = 100; 

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
            if (txtOutput.TextLength == 0)
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
            btnExecute.Enabled = txtInput.TextLength > 0 && txtKey1.TextLength > 0;
            btnSaveFile.Enabled = txtOutput.TextLength > 0;

            dgvVisualization.Rows.Clear();
            dgvVisualization.Columns.Clear();
            lbText.Visible = false;
            lbKey2.Visible = false;
            lbResult.Visible = false;
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
            dgvVisualization.Rows.Clear();
            dgvVisualization.Columns.Clear();
            rbtnEncrypt.Checked = true;
        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = char.ToUpper(e.KeyChar);
            if (!char.IsControl(c) && !Constants.RussianAlphabet.Contains(c))
                e.Handled = true;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (encryptMode)
                txtOutput.Text = VigenereAutokey.Encrypt(txtInput.Text, txtKey1.Text);
            else
                txtOutput.Text = VigenereAutokey.Decrypt(txtInput.Text, txtKey1.Text);

            UpdateButtons();

            string textForVisualization = txtInput.Text.Length > MaxVisualizationLength
                ? txtInput.Text.Substring(0, MaxVisualizationLength)
                : txtInput.Text;

            VisualizeVigenere(textForVisualization, txtKey1.Text, encryptMode);
        }

        private void rbtnEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            encryptMode = rbtnEncrypt.Checked;
            txtOutput.Clear();
        }

        private void rbtnDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            encryptMode = rbtnDecrypt.Checked;
            txtOutput.Clear();
        }

        private void VisualizeVigenere(string text, string key, bool encrypt)
        {
            text = text.ToUpper();
            key = new string(key.ToUpper().Where(c => Constants.RussianAlphabet.Contains(c)).ToArray());

            lbText.Visible = true;
            lbKey2.Visible = true;
            lbResult.Visible = true;

            dgvVisualization.Columns.Clear();
            dgvVisualization.Rows.Clear();

            foreach (char c in text)
            {
                dgvVisualization.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Width = 35,
                    SortMode = DataGridViewColumnSortMode.NotSortable
                });
            }

            dgvVisualization.Rows.Add(3); // три строки

            List<char> autokey = new List<char>(key);
            int keyIndex = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (!Constants.RussianAlphabet.Contains(c))
                {
                    dgvVisualization.Rows[1].Cells[i].Value = "-";         
                    dgvVisualization.Rows[2].Cells[i].Value = c.ToString(); 
                    dgvVisualization.Rows[0].Cells[i].Value = c.ToString(); 
                    continue;
                }

                char kChar = autokey[keyIndex];
                int ci = Constants.RussianAlphabet.IndexOf(c);
                int ki = Constants.RussianAlphabet.IndexOf(kChar);
                char resultChar;

                if (encrypt)
                {
                    resultChar = Constants.RussianAlphabet[(ci + ki) % Constants.RussianAlphabet.Length];
                    autokey.Add(c);
                    dgvVisualization.Rows[0].Cells[i].Value = c.ToString();
                    dgvVisualization.Rows[2].Cells[i].Value = resultChar;
                }
                else
                {
                    resultChar = Constants.RussianAlphabet[(ci - ki + Constants.RussianAlphabet.Length) % Constants.RussianAlphabet.Length];
                    autokey.Add(resultChar);
                    dgvVisualization.Rows[0].Cells[i].Value = resultChar;  
                    dgvVisualization.Rows[2].Cells[i].Value = c.ToString(); 
                }

                dgvVisualization.Rows[1].Cells[i].Value = kChar; 
                keyIndex++;
            }

            dgvVisualization.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvVisualization.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvVisualization.ScrollBars = ScrollBars.Horizontal;
        }
    }
}
