namespace CaesarCipher
{
    public class Program
    {
        #region methods

        #region public

        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //The first step - load the data
            var inputHelper = new InputHelper();
            var line = inputHelper.ReadString();
            var shift = inputHelper.ReadShift();

            //The second step - cryptography and decryptography
            var cryptographer = new Cryptographer();
            var cryptoString = cryptographer.RunCryptCaesar(line, shift, 0);
            var decryptoString = cryptographer.RunCryptCaesar(cryptoString, shift, 1);

            //The third step - print

            var outputHelper = new OutputHelper();
            outputHelper.PrintComparasion(cryptoString, decryptoString);
        }

        #endregion

        #endregion

    }
}
