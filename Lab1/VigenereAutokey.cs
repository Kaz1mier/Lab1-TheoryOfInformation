using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class VigenereAutokey
    {
        private const string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        private static bool IsRussianLetter(char c)
            => Alphabet.Contains(c);

        public static string Encrypt(string text, string key)
        {
            text = text.ToUpper();
            key = new string(key.ToUpper().Where(IsRussianLetter).ToArray());

            StringBuilder result = new StringBuilder();
            List<char> autokey = new List<char>(key);

            int keyIndex = 0;

            foreach (char c in text)
            {
                if (!IsRussianLetter(c))
                {
                    result.Append(c);
                    continue;
                }

                char kChar = autokey[keyIndex];

                int p = Alphabet.IndexOf(c);
                int k = Alphabet.IndexOf(kChar);

                char enc = Alphabet[(p + k) % Alphabet.Length];
                result.Append(enc);

                autokey.Add(c); 
                keyIndex++;
            }

            return result.ToString();
        }

        public static string Decrypt(string text, string key)
        {
            text = text.ToUpper();
            key = new string(key.ToUpper().Where(IsRussianLetter).ToArray());

            StringBuilder result = new StringBuilder();
            List<char> autokey = new List<char>(key);

            int keyIndex = 0;

            foreach (char c in text)
            {
                if (!IsRussianLetter(c))
                {
                    result.Append(c);
                    continue;
                }

                char kChar = autokey[keyIndex];

                int p = Alphabet.IndexOf(c);
                int k = Alphabet.IndexOf(kChar);

                char decoded = Alphabet[(p - k + Alphabet.Length) % Alphabet.Length];
                result.Append(decoded);

                autokey.Add(decoded);
                keyIndex++;
            }

            return result.ToString();
        }
    }



}
