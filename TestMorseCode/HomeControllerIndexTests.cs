using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModeCode;
using System.Text;

namespace TestMorseCode
{
    [TestClass]
    public class HomeControllerIndexTests
    {
        [TestMethod]
        public void HomeIndexTests()

        {
            string morseBit = "0000000011011010011100000110000001111110100111110011111100000000000111011111111011111011111" +
             "000000101100011111100000111110011101100000100000";
            Assert.AreEqual("HEY JUDE", TranslaterMorseCharacters.decodeMorse(TranslaterMorseBit.decodeBitsAdvanced(morseBit)));
        }
    }
}
