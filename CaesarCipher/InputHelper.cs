using System;

namespace CaesarCipher
{
    /// <summary>
    /// Class for input from command line
    /// </summary>
    public class InputHelper
    {
        #region methods

        #region public

        /// <summary>
        /// Read the message for cryptography
        /// </summary>
        /// <returns>The message</returns>
        public char[] ReadString()
        {
            Console.WriteLine("Enter the line in English: ");

            return Console.ReadLine().ToCharArray();
        }

        /// <summary>
        /// Read the shift for cryptography
        /// </summary>
        /// <returns>The value of shift</returns>
        public int ReadShift()
        {
            Console.WriteLine("Enter the shift: ");

            while (true)
            {
                var shiftString = Console.ReadLine();

                if (int.TryParse(shiftString, out int shift))
                {
                    return shift;
                }

                Console.WriteLine("The shift must be integer");
            }
        }

        #endregion
        
        #endregion
        
    }
}
