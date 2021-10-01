using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaesarCipher.Tests
{
    [TestClass()]
    public class CryptographerTests
    {
        [TestMethod()]
        public void RunCryptoCaesarTest()
        {
            var cryptographer = new Cryptographer();
            var testValue = new string (cryptographer.RunCryptCaesar("abc".ToCharArray(), 2 , 0));
            var expected = new string("cde".ToCharArray());
            Assert.AreEqual(testValue, expected);
        }

        [TestMethod()]
        public void RunDecryptoCaesarTest()
        {
            var cryptographer = new Cryptographer();
            var testValue = new string(cryptographer.RunCryptCaesar("cde".ToCharArray(), 2, 1));
            var expected = new string("abc".ToCharArray());
            Assert.AreEqual(testValue, expected);
        }

        [TestMethod()]
        public void RunNullShiftCaesarTest()
        {
            var cryptographer = new Cryptographer();
            var testValue = new string(cryptographer.RunCryptCaesar("abc".ToCharArray(), 0, 0));
            var expected = new string("abc".ToCharArray());
            Assert.AreEqual(testValue, expected);
        }

        [TestMethod()]
        public void RunUpperCaseCryptoCaesarTest()
        {
            var cryptographer = new Cryptographer();
            var testValue = new string(cryptographer.RunCryptCaesar("aBc".ToCharArray(), 2, 0));
            var expected = new string("cDe".ToCharArray());
            Assert.AreEqual(testValue, expected);
        }

        [TestMethod()]
        public void RunUpperCaseDeryptoCaesarTest()
        {
            var cryptographer = new Cryptographer();
            var testValue = new string(cryptographer.RunCryptCaesar("cDe".ToCharArray(), 2, 1));
            var expected = new string("aBc".ToCharArray());
            Assert.AreEqual(testValue, expected);
        }

        [TestMethod()]
        public void RunSpaceCaesarTest()
        {
            var cryptographer = new Cryptographer();
            var testValue = new string(cryptographer.RunCryptCaesar("a bc".ToCharArray(), 2, 0));
            var expected = new string("c de".ToCharArray());
            Assert.AreEqual(testValue, expected);
        }
    }
}