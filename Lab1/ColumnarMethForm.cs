using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class ColumnarMethForm : Form
    {
        private const string RussianAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private bool encryptMode = true;

        public ColumnarMethForm()
        {
            InitializeComponent();

            rbtnEncrypt.Checked = true;

            

            txtOutput.TextChanged += (s, e) => UpdateButtons();

            UpdateButtons();
        }


        private void KeyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = char.ToUpper(e.KeyChar);
            if (!char.IsControl(e.KeyChar) &&
                !RussianAlphabet.Contains(c.ToString()))
                e.Handled = true;
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



        private int[] GetColumnOrder(string key)
        {
            key = key.ToUpper();

            var pairs = key
                .Select((c, i) => new { Char = c, Index = i })
                .ToList();

            var sorted = pairs
                .OrderBy(p => RussianAlphabet.IndexOf(p.Char))
                .ThenBy(p => p.Index)
                .ToList();

            int[] order = new int[key.Length];

            for (int rank = 0; rank < sorted.Count; rank++)
                order[rank] = sorted[rank].Index;

            return order;
        }


        private string CipherWithPreservedSymbols(string text, Func<int[], int[]> cipherFunc)
        {
            List<int> letters = new List<int>();
            List<int> positions = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                char c = char.ToUpper(text[i]);
                int idx = RussianAlphabet.IndexOf(c);
                if (idx >= 0)
                {
                    letters.Add(idx);
                    positions.Add(i);
                }
            }

            int[] ciphered = cipherFunc(letters.ToArray());

            char[] result = text.ToCharArray();
            for (int i = 0; i < ciphered.Length; i++)
            {
                result[positions[i]] = RussianAlphabet[ciphered[i]];
            }

            return new string(result);
        }


        private int[] EncryptMatrix(int[] textIndices, string key)
        {
            int cols = key.Length;
            int rows = (int)Math.Ceiling((double)textIndices.Length / cols);
            int[] order = GetColumnOrder(key);

            int?[,] matrix = new int?[rows, cols];

            for (int i = 0; i < textIndices.Length; i++)
            {
                int row = i / cols;
                int col = i % cols;
                matrix[row, col] = textIndices[i];
            }

            List<int> encrypted = new List<int>();
            for (int c = 0; c < cols; c++)
            {
                int col = order[c];
                for (int r = 0; r < rows; r++)
                {
                    if (matrix[r, col].HasValue)
                        encrypted.Add(matrix[r, col].Value);
                }
            }

            return encrypted.ToArray();
        }

        private int[] DecryptMatrix(int[] cipherIndices, string key)
        {
            int cols = key.Length;
            int totalChars = cipherIndices.Length;
            int rows = (int)Math.Ceiling((double)totalChars / cols);

            int[] order = GetColumnOrder(key);

            int baseSize = totalChars / cols;
            int extra = totalChars % cols;

            int[] realColSizes = new int[cols];
            for (int c = 0; c < cols; c++)
                realColSizes[c] = baseSize + (c < extra ? 1 : 0);

            int?[,] matrix = new int?[rows, cols];

            int index = 0;

            for (int k = 0; k < cols; k++)
            {
                int realCol = order[k];
                int size = realColSizes[realCol];

                for (int r = 0; r < size; r++)
                {
                    matrix[r, realCol] = cipherIndices[index++];
                }
            }

            List<int> result = new List<int>();

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < cols; c++)
                    if (matrix[r, c].HasValue)
                        result.Add(matrix[r, c].Value);

            return result.ToArray();
        }


        private string Encrypt(string text, string k1, string k2)
        {
            return CipherWithPreservedSymbols(text, letters =>
            {
                int[] step1 = EncryptMatrix(letters, k1);
                int[] step2 = EncryptMatrix(step1, k2);
                return step2;
            });
        }

        private string Decrypt(string text, string k1, string k2)
        {
            return CipherWithPreservedSymbols(text, letters =>
            {
                int[] step1 = DecryptMatrix(letters, k2);
                int[] step2 = DecryptMatrix(step1, k1);
                return step2;
            });
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
                    ? Encrypt(txtInput.Text, txtKey1.Text, txtKey2.Text)
                    : Decrypt(txtInput.Text, txtKey1.Text, txtKey2.Text);
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
            UpdateButtons();
        }

        private void rbtnEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEncrypt.Checked) encryptMode = true;
            txtOutput.Clear();
            if (btnExecute.Enabled) ExecuteCipher();

        }

        private void rbtnDecrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDecrypt.Checked) encryptMode = false;
            txtOutput.Clear();
            if (btnExecute.Enabled) ExecuteCipher();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtKey1.Clear();
            txtKey2.Clear();
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

        
    }
}