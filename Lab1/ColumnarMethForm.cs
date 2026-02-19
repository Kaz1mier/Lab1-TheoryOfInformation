using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab1
{
    public partial class ColumnarMethForm : Form
    {


        private bool encryptMode = true;

        public ColumnarMethForm()
        {
            InitializeComponent();

            rbtnEncrypt.Checked = true;

            txtOutput.TextChanged += (s, e) => UpdateButtons();

            UpdateButtons();
        }

        private void UpdateButtons()
        {
            btnExecute.Enabled =
                txtInput.TextLength > 0 &&
                txtKey1.TextLength > 0 &&
                txtKey2.TextLength > 0;

            btnSaveFile.Enabled = txtOutput.TextLength > 0;
           
        }

        private void InputChanged(object sender, EventArgs e)
        {
            txtOutput.Clear();
            UpdateButtons();
        }

        private void KeyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = char.ToUpper(e.KeyChar);

            if (!char.IsControl(e.KeyChar) &&
                !Constants.RussianAlphabet.Contains(c.ToString()))
                e.Handled = true;
        }

        private void ExecuteCipher()
        {
            if (txtKey1.Text.Length == 0 || txtKey2.Text.Length == 0)
            {
                MessageBox.Show("Введите оба ключа!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtInput.Text.Length == 0)
            {
                MessageBox.Show("Введите текст!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                txtOutput.Text = encryptMode
                    ? ColumnarMethod.Encrypt(
                        txtInput.Text,
                        txtKey1.Text,
                        txtKey2.Text)
                    : ColumnarMethod.Decrypt(
                        txtInput.Text,
                        txtKey1.Text,
                        txtKey2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            ExecuteCipher();
            VisualizeDoubleColumnar();

            UpdateButtons();
        }

        private void rbtnEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEncrypt.Checked)
                encryptMode = true;

            txtOutput.Clear();

            if (btnExecute.Enabled) { 
                ExecuteCipher();
                VisualizeDoubleColumnar();
                UpdateButtons();
            }
        }

        private void rbtnDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDecrypt.Checked)
                encryptMode = false;

            txtOutput.Clear();

            if (btnExecute.Enabled)
            {
                ExecuteCipher();
                VisualizeDoubleColumnar();
                UpdateButtons();
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
                    string fileText = File.ReadAllText(dlg.FileName, Encoding.UTF8);

                    

                    txtInput.Text = fileText;
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
                    File.WriteAllText(
                        dlg.FileName,
                        txtOutput.Text,
                        Encoding.UTF8);

                    MessageBox.Show(
                        "Файл успешно сохранен!",
                        "Успех");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Ошибка при сохранении файла: {ex.Message}",
                        "Ошибка");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtKey1.Clear();
            txtKey2.Clear();
            rbtnEncrypt.Checked = true;
            dgvStage1.Rows.Clear();
            dgvStage1.Columns.Clear();
            dgvStage2.Rows.Clear();
            dgvStage2.Columns.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
            => Close();

        private void ColumnarMethForm_FormClosing(
            object sender,
            FormClosingEventArgs e)
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

        private int[] GetColumnOrder(string key)
        {
            return key
                .Select((c, i) => new { Char = c, Index = i })
                .OrderBy(x => Constants.RussianAlphabet.IndexOf(x.Char))
                .ThenBy(x => x.Index)
                .Select(x => x.Index)
                .ToArray();
        }

        private void VisualizeDoubleColumnar()
        {
            string clean = txtInput.Text.ToUpper();

            if (encryptMode)
            {
                // Шифрование: сначала первая таблица, потом вторая
                string step1 = VisualizeColumnar(dgvStage1, clean, txtKey1.Text, true);
                VisualizeColumnar(dgvStage2, step1, txtKey2.Text, true);
            }
            else
            {
                // Дешифровка: сначала вторая таблица, потом первая
                string step2 = VisualizeColumnar(dgvStage2, clean, txtKey2.Text, false);
                VisualizeColumnar(dgvStage1, step2, txtKey1.Text, false);
            }
        }



        private string VisualizeColumnar(DataGridView dgv, string text, string key, bool encrypt)
        {
            dgv.Columns.Clear();
            dgv.Rows.Clear();

            key = key.ToUpper();
            int cols = key.Length;

            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.ScrollBars = ScrollBars.Both;

            for (int c = 0; c < cols; c++)
            {
                var col = new DataGridViewTextBoxColumn
                {
                    SortMode = DataGridViewColumnSortMode.NotSortable,
                    Width = 35
                };
                dgv.Columns.Add(col);
            }

            List<int> letters = text
                .Where(ch => Constants.RussianAlphabet.Contains(ch))
                .Select(ch => Constants.RussianAlphabet.IndexOf(ch))
                .ToList();

            if (letters.Count == 0)
                return text;

            int rows = (int)Math.Ceiling((double)letters.Count / cols);
            dgv.Rows.Add(rows + 1);

            for (int c = 0; c < cols; c++)
            {
                dgv.Rows[0].Cells[c].Value = key[c];
                dgv.Rows[0].Cells[c].Style.BackColor = Color.LightGray;
            }

            int?[,] matrix = new int?[rows, cols];

            if (encrypt)
            {
                for (int i = 0; i < letters.Count; i++)
                {
                    int r = i / cols;
                    int c = i % cols;
                    matrix[r, c] = letters[i];
                }
            }
            else
            {
                int[] order = GetColumnOrder(key);
                int baseSize = letters.Count / cols;
                int extra = letters.Count % cols;
                int[] colSizes = new int[cols];
                for (int c = 0; c < cols; c++)
                    colSizes[c] = baseSize + (c < extra ? 1 : 0);

                int index = 0;
                for (int k = 0; k < cols; k++)
                {
                    int col = order[k];
                    for (int r = 0; r < colSizes[col]; r++)
                    {
                        matrix[r, col] = letters[index++];
                    }
                }
            }

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    if (matrix[r, c].HasValue)
                        dgv.Rows[r + 1].Cells[c].Value =
                            Constants.RussianAlphabet[matrix[r, c].Value];

            List<int> result = new List<int>();
            if (encrypt)
            {
                int[] order = GetColumnOrder(key);
                for (int k = 0; k < cols; k++)
                {
                    int col = order[k];
                    for (int r = 0; r < rows; r++)
                        if (matrix[r, col].HasValue)
                            result.Add(matrix[r, col].Value);
                }
            }
            else
            {
                for (int r = 0; r < rows; r++)
                    for (int c = 0; c < cols; c++)
                        if (matrix[r, c].HasValue)
                            result.Add(matrix[r, c].Value);
            }

            return new string(result.Select(i => Constants.RussianAlphabet[i]).ToArray());
        }








    }

}
