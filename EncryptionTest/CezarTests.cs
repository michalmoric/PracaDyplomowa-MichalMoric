using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracaDyplomowa_MichalMoric;

namespace EncryptionTest
{
    [TestClass]
    public class CezarTests
    {
        [DataRow("Michal",4)]
        [DataRow("Michal",15)]
        [DataRow("Michal", 42)]
        [DataRow("ZAEWEQD", 15)]
        [DataRow("ZAEWEQD", 0)]
        [DataRow("zzzzzzzZZZZZ",100)]
        [DataTestMethod]
        public void SuccesEncryptDecryptTest(string message,int offset)
        {
            CezarCypher cypher = new CezarCypher();
            string encryptedmessage = cypher.CezarEncrypt(message, offset);
            string decryptedmessage = cypher.CezarDecrypt(encryptedmessage, offset);
            Assert.AreEqual(message, decryptedmessage);
        }
        [DataRow("11111132321", 5)]// Dodano check dla  liter w CezarCyper
        [DataRow("11111132321", 50)]
        [DataRow("#!@!#$!@", 5)]
        [DataRow("#!@!#$!@", 50)]
        [DataRow("Michal", -3)]
        [DataRow("Michal",-10)]
        [DataTestMethod]
        public void FailEncryptDecryptTest(string message, int offset)
        {
            CezarCypher cypher = new CezarCypher();
            string encryptedmessage = cypher.CezarEncrypt(message, offset);
            string decryptedmessage = cypher.CezarDecrypt(encryptedmessage, offset);
            Assert.AreNotEqual(message, decryptedmessage);
        }
    }
}
