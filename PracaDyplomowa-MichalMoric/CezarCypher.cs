using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDyplomowa_MichalMoric
{
    public class CezarCypher
    {
        public string ShiftTextRight(string Message)
        {
            string outputMessage = "";
            for (int i = 0; i < Message.Length; i++)
            {
                if (Message[i] == 'z')
                {
                    outputMessage += 'A';

                }
                else if (Message[i] == 'Z')
                {
                    outputMessage += 'a';
                }
                else
                {
                    int value = (int)Message[i];
                    value++;
                    outputMessage += (char)value;
                }

            }
            return outputMessage;
        }
        public string ShiftTextLeft(string Message)
        {
            string outputMessage = "";
            for (int i = 0; i < Message.Length; i++)
            {
                if (Message[i] == 'A')
                {
                    outputMessage += 'z';

                }
                else if (Message[i] == 'a')
                {
                    outputMessage += 'Z';
                }
                else
                {
                    int value = (int)Message[i];
                    value--;
                    outputMessage += (char)value;
                }

            }
            return outputMessage;
        }
        public string CezarEncrypt(string Message, int offset)
        {
            for (int i = 0; i < offset; i++)
            {
                Message = ShiftTextRight(Message);

            }
            return Message;
        }
        public string CezarDecrypt(string Message, int offset)
        {
            for (int i = 0; i < offset; i++)
            {
                Message = ShiftTextLeft(Message);

            }
            return Message;
        }
    }
}
