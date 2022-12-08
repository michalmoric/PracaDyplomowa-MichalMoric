using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracaDyplomowa_MichalMoric;


namespace EncryptionTest
{
    [TestClass]
    public class PolibiusTests
    {
        [DataRow("MICHAL",false)]
        [DataRow("MICHAL",true)]
        [DataRow("DZIENDOBRYCOTAMKOLEGO", false)]
        [DataRow("DZIENDOBRYCOTAMKOLEGO", true)]
        [DataTestMethod]
        public void SuccessEncryptionDecryptionTest1(string message,bool mode)
        {
            List<List<string>> list = new List<List<string>>
            {
            new List<string>{"A","B","C","D","E"},
            new List<string>{"F","G","H","I","K"},
            new List<string>{"L","M","N","O","P"},
            new List<string>{"Q","R","S","T","U"},
            new List<string>{"V","W","X","Y","Z"}
             };
            PolibiusCypher cypher = new PolibiusCypher();
            string encryptedMessage = cypher.PolibiusEncrypt(list, message, mode);
            string decryptedMessage = cypher.PolibiusDecrypt(list, encryptedMessage, mode);
            Assert.AreEqual(message, decryptedMessage);
        }

        [DataRow("MICHAL", false)]
        [DataRow("MICHAL", true)]
        [DataRow("DZIENDOBRYCOTAMKOLEGO", false)]
        [DataRow("DZIENDOBRYCOTAMKOLEGO", true)]
        [DataTestMethod]
        public void SuccessEncryptionDecryptionTest2(string message, bool mode)
        {
            List<List<string>> list = new List<List<string>>
            {
            new List<string>{"A","B","C","D","E","F","G","H","I"},
            new List<string>{"K","L","M","N","O","P","Q","R","S"},
            new List<string>{"T", "U","V","W","X","Y","Z"}
             };
            PolibiusCypher cypher = new PolibiusCypher();
            string encryptedMessage = cypher.PolibiusEncrypt(list, message, mode);
            string decryptedMessage = cypher.PolibiusDecrypt(list, encryptedMessage, mode);
            Assert.AreEqual(message, decryptedMessage);
        }
        [DataRow("ABCD",false)]
        [DataRow("BBBBAAA", false)]
        [DataRow("ABCD", true)]
        [DataRow("BBBBAAA", true)]
        [DataTestMethod]
        public void SuccessEncryptionDecryptionTest3(string message, bool mode)
        {
            List<List<string>> list = new List<List<string>>
            {
            new List<string>{"A","B"},
            new List<string>{"C","D"}
             };
            PolibiusCypher cypher = new PolibiusCypher();
            string encryptedMessage = cypher.PolibiusEncrypt(list, message, mode);
            string decryptedMessage = cypher.PolibiusDecrypt(list, encryptedMessage, mode);
            Assert.AreEqual(message, decryptedMessage);
        }
        [DataRow("michal", false)]
        [DataRow("michal", true)]
        [DataRow("dziendobry", false)]
        [DataRow("dziendobry", true)]
        [DataRow("JAKISCOS",false)]
        [DataRow("JAKISCOS", true)]
        [DataTestMethod]
        public void FailEncryptionDecryptionTest1(string message, bool mode)
        {
            List<List<string>> list = new List<List<string>>
            {
            new List<string>{"A","B","C","D","E"},
            new List<string>{"F","G","H","I","K"},
            new List<string>{"L","M","N","O","P"},
            new List<string>{"Q","R","S","T","U"},
            new List<string>{"V","W","X","Y","Z"}
             };
            PolibiusCypher cypher = new PolibiusCypher();
            string encryptedMessage = cypher.PolibiusEncrypt(list, message, mode);
            string decryptedMessage = cypher.PolibiusDecrypt(list, encryptedMessage, mode);
            Assert.AreNotEqual(message, decryptedMessage);
        }
        [DataRow("MICHAL", false)]
        [DataRow("MICHAL", true)]
        [DataRow("DZIENDOBRYCOTAMKOLEGO23145", false)]
        [DataRow("DZIENDOBRYCOTAMKOLEGO23145", true)]
        [DataTestMethod]
        public void FailEncryptionDecryptionTest2(string message, bool mode)// Wywalalo exeption (Dodano check w szyfrowaniu)
        {
            List<List<string>> list = new List<List<string>>
            {
            new List<string>{"A","B","C","D","E","F","G","H","I","K"},
            new List<string>{"L","M","N","O","P","Q","R","S","T","U"},
            new List<string>{"V","W","X","Y","Z","1","2","3","4","5"}
             };
            PolibiusCypher cypher = new PolibiusCypher();
            string encryptedMessage = cypher.PolibiusEncrypt(list, message, mode);
            string decryptedMessage = cypher.PolibiusDecrypt(list, encryptedMessage, mode);
            Assert.AreNotEqual(message, decryptedMessage);
        }
        [DataRow("MICHAL", false)]
        [DataRow("MICHAL", true)]
        [DataRow("DZIENDOBRYCOTAMKOLEGO23145", false)]
        [DataRow("DZIENDOBRYCOTAMKOLEGO23145", true)]
        [DataTestMethod]
        public void FailEncryptionDecryptionTest3(string message, bool mode)// Wywalalo exeption (Dodano check w szyfrowaniu)
        {
            List<List<string>> list = new List<List<string>>
            {
            new List<string>{"A","B"},
            new List<string>{"C","D"},
            new List<string>{"E","F"},
            new List<string>{"G","H"},
            new List<string>{"I","K"},
            new List<string>{"L","M"},
            new List<string>{"N","O"},
            new List<string>{"P","Q"},
            new List<string>{"R","S"},
            new List<string>{"T","U"},
            new List<string>{"V","W"},
            new List<string>{"X","Y","Z"}
             };
            PolibiusCypher cypher = new PolibiusCypher();
            string encryptedMessage = cypher.PolibiusEncrypt(list, message, mode);
            string decryptedMessage = cypher.PolibiusDecrypt(list, encryptedMessage, mode);
            Assert.AreNotEqual(message, decryptedMessage);
        }
    }
}
