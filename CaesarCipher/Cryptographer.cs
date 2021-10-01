using System;

namespace CaesarCipher
{
    /// <summary>
    /// Class for cryptography
    /// </summary>
    public class Cryptographer
    {
        #region consts

        private const int ALPHABET_LENGTH = 28;

        #endregion
        #region methods

        #region public

        /// <summary>
        /// Implements caesar cipher
        /// </summary>
        /// <param name="str">Text line</param>
        /// <param name="shiftString">Value of shift</param>
        /// <param name="mode">0 - crypt, 1 - decrypt </param>
        /// <returns></returns>
        public char[] RunCryptCaesar(char[] str, int shiftString, int mode)
        {
            str = (char[])str.Clone();

            for (var i = 0;i<str.Length;i++)
            {
                var registerSHift = char.IsUpper(str[i]) ? 'A' : 'a';

                if (str[i] == ' ')
                {
                    continue;
                }

                if (mode == 0)
                {
                    str[i] = (char)(((str[i] + shiftString - registerSHift) % ALPHABET_LENGTH) + registerSHift);
                }
                else if (mode == 1)
                {
                    str[i] = (char)(((str[i] - shiftString - registerSHift) % ALPHABET_LENGTH) + registerSHift);
                }
                else
                {
                    throw new Exception($"The mode is not correct: {mode}");
                }
            }

            return str;
        }

        #endregion

        #endregion
        
    }
}
