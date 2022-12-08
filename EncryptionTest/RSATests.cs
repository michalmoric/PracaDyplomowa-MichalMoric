using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracaDyplomowa_MichalMoric;

namespace EncryptionTest
{
    [TestClass]
    public class RSATests
    {
        [DataRow(5)]
        [DataRow(100)]
        [DataRow(200000)]
        [DataRow(26115817312418951)]
        [DataTestMethod]
        public void EncryptionDecryptionTestNumbers(int num)// Przy duzych liczbach blednie koduje(dodano w interfejsie dodatkowe ostrzerzenie
        {
            RSACypher cypher = new RSACypher();
            List<int> data = cypher.GenerateKeys(0, 0);
            int n = data[0];
            int e = data[2];
            int d = data[3];
            BigInteger original = (BigInteger)num;
            BigInteger encryptedMessage = cypher.encryptNumber(num, e, n);
            BigInteger decryptedMessage = cypher.decryptNumber((int)encryptedMessage, d, n);
            Assert.AreEqual(original, decryptedMessage);
        }
        [DataRow("MICHALmoricAUTORpracy")]
        [DataRow("dziendobry")]
        [DataRow("31251612")]
        [DataRow("!@$^$!!#%%!#&*&^%#")]
        [DataTestMethod]
        public void EncryptionDecryptionTestASCII(string mess)// Przy duzych liczbach blednie koduje(dodano w interfejsie dodatkowe ostrzerzenie
        {
            RSACypher cypher = new RSACypher();
            List<int> data = cypher.GenerateKeys(0, 0);
            int n = data[0];
            int e = data[2];
            int d = data[3];
            string original = mess;
            string encryptedMessage = cypher.encryptAscii(mess, e, n);
            string decryptedMessage = cypher.decryptAscii(encryptedMessage, d, n);
            Assert.AreEqual(original, decryptedMessage);
        }
    }
}
