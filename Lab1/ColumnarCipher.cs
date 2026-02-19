using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    public static class ColumnarMethod
    {
       

        private static int[] GetColumnOrder(string key)
        {
            key = key.ToUpper();

            var pairs = key
                .Select((c, i) => new { Char = c, Index = i })
                .ToList();

            var sorted = pairs
                .OrderBy(p => Constants.RussianAlphabet.IndexOf(p.Char))
                .ThenBy(p => p.Index)
                .ToList();

            int[] order = new int[key.Length];

            for (int rank = 0; rank < sorted.Count; rank++)
                order[rank] = sorted[rank].Index;

            return order;
        }

        private static string CipherWithPreservedSymbols(string text, Func<int[], int[]> cipherFunc)
        {
            List<int> letters = new List<int>();
            List<int> positions = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                char c = char.ToUpper(text[i]);
                int idx = Constants.RussianAlphabet.IndexOf(c);
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
                result[positions[i]] = Constants.RussianAlphabet[ciphered[i]];
            }

            return new string(result);
        }

        private static int[] EncryptMatrix(int[] textIndices, string key)
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

        private static int[] DecryptMatrix(int[] cipherIndices, string key)
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

        public static string Encrypt(string text, string k1, string k2)
        {
            return CipherWithPreservedSymbols(text, letters =>
            {
                int[] step1 = EncryptMatrix(letters, k1);
                int[] step2 = EncryptMatrix(step1, k2);
                return step2;
            });
        }

        public static string Decrypt(string text, string k1, string k2)
        {
            return CipherWithPreservedSymbols(text, letters =>
            {
                int[] step1 = DecryptMatrix(letters, k2);
                int[] step2 = DecryptMatrix(step1, k1);
                return step2;
            });
        }
    }
}
