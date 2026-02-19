using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class VigenereAutokey
    {
        

        private static bool IsRussianLetter(char c)
            => Constants.RussianAlphabet.Contains(c);

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

                int p = Constants.RussianAlphabet.IndexOf(c);
                int k = Constants.RussianAlphabet.IndexOf(kChar);

                char enc = Constants.RussianAlphabet[(p + k) % Constants.RussianAlphabet.Length];
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

                int p = Constants.RussianAlphabet.IndexOf(c);
                int k = Constants.RussianAlphabet.IndexOf(kChar);

                char decoded = Constants.RussianAlphabet[(p - k + Constants.RussianAlphabet.Length) % Constants.RussianAlphabet.Length];
                result.Append(decoded);

                autokey.Add(decoded);
                keyIndex++;
            }

            return result.ToString();
        }
    }



}
