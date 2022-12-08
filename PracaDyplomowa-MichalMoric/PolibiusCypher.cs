using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDyplomowa_MichalMoric
{
    public class PolibiusCypher
    {
        public string OneLetterEncript(List<List<string>> charMatrix, string letter, bool encryptMode)
        {
            string returnText = "";
            int rowNum = 1;
            int cellNum = 1;
            bool error = false;
            foreach(List<string> row in charMatrix)
            {
                if (row.Count > 9) error = true;
            }
            if(error ==true || charMatrix.Count > 9)
            {
                return "";
            }
            else
            {
                foreach (List<string> row in charMatrix)
                {
                    foreach (string cell in row)
                    {
                        if (letter == cell)
                        {
                            if (encryptMode == false)
                            {
                                returnText = rowNum.ToString() + cellNum.ToString();

                            }
                            else
                            {
                                returnText = cellNum.ToString() + rowNum.ToString();
                            }
                        }
                        cellNum++;
                    }
                    rowNum++;
                    cellNum = 1;
                }
                return returnText;
            }
        }
        public string OneLetterDecript(List<List<string>> charMatrix, string letter, bool encryptMode)
        {
            if (letter.Length == 2)
            {
                if (letter.All(Char.IsDigit) == true)
                {
                    if (encryptMode == false)
                    {
                        if ((Int32.Parse(letter[0].ToString()) > charMatrix.Count() || (Int32.Parse(letter[1].ToString()) > charMatrix[0].Count())))
                        {
                            return "";
                        }
                        else
                        {
                            int row = Int32.Parse(letter[0].ToString()) - 1;
                            int cell = Int32.Parse(letter[1].ToString()) - 1;
                            return charMatrix[row][cell];
                        }
                    }
                    else
                    {
                        if ((Int32.Parse(letter[1].ToString()) > charMatrix.Count() || (Int32.Parse(letter[0].ToString()) > charMatrix[0].Count())))
                        {
                            return "";
                        }
                        else
                        {
                            int row = Int32.Parse(letter[1].ToString()) - 1;
                            int cell = Int32.Parse(letter[0].ToString()) - 1;
                            return charMatrix[row][cell];
                        }
                    }
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
        public string PolibiusEncrypt(List<List<string>> charMatrix, string Message, bool encryptMode)
        {
            string result = "";
            foreach (char letter in Message)
            {
                result += OneLetterEncript(charMatrix, letter.ToString(), encryptMode);
            }
            return result;
        }
        public string PolibiusDecrypt(List<List<string>> charMatrix, string Message, bool encryptMode)
        {
            string result = "";
            for (int i = 0; i < Message.Length; i = i + 2)
            {
                string letterOne = Message[i].ToString();
                string letterTwo = Message[i + 1].ToString();
                result += OneLetterDecript(charMatrix, letterOne + letterTwo, encryptMode);
            }
            return result;
        }
    }
}
