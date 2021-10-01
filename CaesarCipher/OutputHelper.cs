using System;

namespace CaesarCipher
{
    /// <summary>
    /// Class for output to command line
    /// </summary>
    public class OutputHelper
    {
        #region methods

        #region public

        /// <summary>
        /// Print both values
        /// </summary>
        /// <param name="crypt"> Value before cryptography</param>
        /// <param name="decrypt">Value after cryptograpy</param>
        public void PrintComparasion(char[] crypt, char[] decrypt)
        {
            Console.WriteLine($"The line after cryptography:  {new string(crypt)}");
            Console.WriteLine($"The line after decryptography:  {new string(decrypt)}");
        }

        #endregion

        #endregion
    }
}
