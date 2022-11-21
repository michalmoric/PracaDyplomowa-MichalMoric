using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PracaDyplomowa_MichalMoric.RSACypher;
using System.Numerics;

namespace PracaDyplomowa_MichalMoric
{
    public partial class RsaForm : Form
    {
        RSACypher cypher = new RSACypher();
        private bool encryptOrDecrypt = false;
        private int encryptionIterator = 0;
        private string stepbystepOutput= "";
        private string[] decryptionMessage;
        public RsaForm()
        {
            InitializeComponent();
        }

        private void KeyGenBtn_Click(object sender, EventArgs e)
        {
            List<int> output = new List<int>();
            bool correct = true;
            if(RandomButton.Checked == true)
            {
                output = cypher.GenerateKeys(0, 0);
                NBox.Text = output[0].ToString();
                PublicKeyBox.Text = output[2].ToString();
                PrivateKeyBox.Text = output[3].ToString();
                InstructionLabel.Text = "Krok 1 :" + Environment.NewLine;
                InstructionLabel.Text += "Losowo wybrano dwie liczby pierwsze : p oraz q" + Environment.NewLine;
                InstructionLabel.Text += "p = " + output[4] + " q = " + output[5] + Environment.NewLine + Environment.NewLine;
            }
            else if(ChosenButton.Checked == true)
            {
                int i;
                if(int.TryParse(PBox.Text, out i) && int.TryParse(QBox.Text, out i))
                {
                    if (cypher.IsPrime(Convert.ToInt32(PBox.Text)) && cypher.IsPrime(Convert.ToInt32(QBox.Text)))
                    {

                        output = cypher.GenerateKeys(Convert.ToInt32(PBox.Text), Convert.ToInt32(QBox.Text));
                        NBox.Text = output[0].ToString();
                        PublicKeyBox.Text = output[2].ToString();
                        PrivateKeyBox.Text = output[3].ToString();
                        InstructionLabel.Text = "Krok 1 :" + Environment.NewLine;
                        InstructionLabel.Text += "Użytkownik wybrał dwie liczby pierwsze : p oraz q" + Environment.NewLine;
                        InstructionLabel.Text += "p = " + output[4] + " q = " + output[5]  + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        correct = false;
                        MessageBox.Show("Obie liczby muszą być liczbami pierwszymi","",0,MessageBoxIcon.Error);
                    }
                }
                else
                {
                    correct = false;
                    MessageBox.Show("Proszę wprowadzić wartości liczbowe do pól P i Q", "", 0, MessageBoxIcon.Error);
                }
            }
            if(correct == true)
            {
                InstructionLabel.Text += "Krok 2 :" + Environment.NewLine;
                InstructionLabel.Text += "Obliczamy liczbę n = p * q, jest to część wspólna klucza publicznego i prywatnego" + Environment.NewLine;
                InstructionLabel.Text +=  output[4] + " * " + output[5] + " = "+ output[0]  + Environment.NewLine + Environment.NewLine;
                InstructionLabel.Text += "Krok 3 :" + Environment.NewLine;
                InstructionLabel.Text += "Obliczamy wartość funkcji eulera phi = (p - 1) * (q - 1) " + Environment.NewLine;
                InstructionLabel.Text += "("+output[4] + "-1) * (" + output[5] + "-1) = " + output[1] +  Environment.NewLine + Environment.NewLine;
                InstructionLabel.Text += "Krok 4 :" + Environment.NewLine;
                InstructionLabel.Text += "Znajdujemy liczbę e która spełnia 3 warunki: " + Environment.NewLine;
                InstructionLabel.Text += "1: Jest większa od 1, 2: jest mniejsza od phi, 3: jest względnie pierwsza z phi " + Environment.NewLine;
                InstructionLabel.Text += "czyli jej największy wspólny dzielnik z phi jest równy 1 " + Environment.NewLine;
                InstructionLabel.Text += "Jest "+ output[6] + " takich liczb a my z nich losowo wybierzemy: "+ output[2] + Environment.NewLine + Environment.NewLine;
                InstructionLabel.Text += "Krok 5 :" + Environment.NewLine;
                InstructionLabel.Text += "Znajdujemy liczbę d która jest odwrotnoscią modularną e i phi: "+ output[3] + Environment.NewLine;
                InstructionLabel.Text += "Klucz publiczny stanowiony jest przez parę liczb e i n a klucz prywatny przez d i n";

            }
            if (output[0].ToString().Length <= 3)
            {
                MessageBox.Show("Ostrożnie , wartość n jest bardzo krótka, jeżeli twoja wiadomość liczbowa będzie większa od n nie zaszyfruje się poprawnie\n a jeżeli n jest mniejsze od 255 wiadomości tekstowe też mogą być zaszyfrowane niepoprawnie");
            }
            
        }

        private void Encrypt_Btn_Click(object sender, EventArgs e)
        {
            int i;
            if(int.TryParse(NBox.Text, out i) && int.TryParse(PublicKeyBox.Text, out i) && InputBox.Text.Length>0)
            {
                int E = Convert.ToInt32(PublicKeyBox.Text);
                int n = Convert.ToInt32(NBox.Text);
                if (NumberButton.Checked)
                {
                    if (int.TryParse(InputBox.Text, out i))
                    {
                        int message = Convert.ToInt32(InputBox.Text);
                        BigInteger output = cypher.encryptNumber(message, E, n);
                        OutputBox.Text = output.ToString();
                        InstructionLabel.Text = "Liczba wejsciowa m została zaszyfrowana z użyciem następującego wzoru:" + Environment.NewLine;
                        InstructionLabel.Text += "m^e % n" + Environment.NewLine;
                        InstructionLabel.Text += "Zaszyfrowana liczba c jest równa: " + output + Environment.NewLine + Environment.NewLine;
                    }
                    else
                    {
                        MessageBox.Show("Proszę podać liczbę", "", 0, MessageBoxIcon.Error);
                    }
                }
                else if (ASCIIButton.Checked)
                {
                    string output = cypher.encryptAscii(InputBox.Text, E, n).ToString();
                    OutputBox.Text = output;
                    InstructionLabel.Text = "Wiadomość zaszyfrowana wygląda tak:"+ output + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić liczbowy klucz publiczny (pola N i E) oraz wiadomość do zaszyfrowania", "", 0, MessageBoxIcon.Error);
            }
        }

        private void Decrypt_Btn_Click(object sender, EventArgs e)
        {
            int i;

            if(int.TryParse(NBox.Text, out i) && int.TryParse(PrivateKeyBox.Text, out i) && InputBox.Text.Length > 0)
            {
                int d = Convert.ToInt32(PrivateKeyBox.Text);
                int n = Convert.ToInt32(NBox.Text);
                if (NumberButton.Checked)
                {
                    if (int.TryParse(InputBox.Text, out i))
                    {
                        int message = Convert.ToInt32(InputBox.Text);
                        BigInteger output = cypher.decryptNumber(message, d, n);
                        OutputBox.Text = output.ToString();
                        InstructionLabel.Text += "Zaszyfrowana liczba wejsciowa c została odszyfrowana z użyciem następującego wzoru:"+ Environment.NewLine;
                        InstructionLabel.Text += "c^d % n" + Environment.NewLine;
                        InstructionLabel.Text += "Odszyfrowana liczba m jest równa: " + Environment.NewLine + output;
                    }
                    else
                    {
                        MessageBox.Show("Proszę podać liczbę", "", 0, MessageBoxIcon.Error);
                    }
                }
                else if (ASCIIButton.Checked)
                {
                    string output = cypher.decryptAscii(InputBox.Text, d, n).ToString();
                    OutputBox.Text = output;
                    InstructionLabel.Text = "Wiadomość odszyfrowana wygląda tak:" + Environment.NewLine + output;
                }


            }
            else
            {
                MessageBox.Show("Proszę wprowadzić liczbowy klucz prywatny (pola N i D) oraz wiadomość do deszyfrowania", "", 0, MessageBoxIcon.Error);
            }

        }

        private void RandomButton_CheckedChanged(object sender, EventArgs e)
        {
            PBox.Enabled = false;
            QBox.Enabled = false;
        }

        private void ChosenButton_CheckedChanged(object sender, EventArgs e)
        {
            PBox.Enabled = true;
            QBox.Enabled = true;
        }

        private void NumberButton_CheckedChanged(object sender, EventArgs e)
        {
            StepByStepEncryptBtn.Enabled = false;
            StepByStepDecryptBtn.Enabled = false;
        }

        private void ASCIIButton_CheckedChanged(object sender, EventArgs e)
        {
            StepByStepEncryptBtn.Enabled = true;
            StepByStepDecryptBtn.Enabled = true;
        }

        private void StepByStepEncryptBtn_Click(object sender, EventArgs e)
        {
            int i;
            if(int.TryParse(NBox.Text, out i) && int.TryParse(PublicKeyBox.Text, out i) && InputBox.Text.Length > 0)
            {
                InstructionLabel.Text = "Szyfrowanie wiadomosci odbędzie się poprzez reprezentowanie każdego ze znaków jako wartość ASCII" + Environment.NewLine;
                InstructionLabel.Text += "i kodowanie go tym wzorem: m^e % n " + Environment.NewLine;
                StepByStepEncryptBtn.Enabled = false;
                Encrypt_Btn.Enabled = false;
                StepByStepDecryptBtn.Enabled = false;
                Decrypt_Btn.Enabled = false;
                NextStepBtn.Enabled = true;
                encryptOrDecrypt = false;
                InputBox.Enabled = false;
                encryptionIterator = 0;
                stepbystepOutput = "";
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić liczbowy klucz publiczny (pola N i E) oraz wiadomość do zaszyfrowania", "", 0, MessageBoxIcon.Error);
            }
            

            

        }

        private void StepByStepDecryptBtn_Click(object sender, EventArgs e)
        {
            int i;
            if(int.TryParse(NBox.Text, out i) && int.TryParse(PublicKeyBox.Text, out i) && InputBox.Text.Length > 0)
            {
                InstructionLabel.Text = "Deszyfrowanie wiadomosci odbędzie się przez odkodowywanie każdej wartości z klucza tym wzorem: c^d % n " + Environment.NewLine;
                InstructionLabel.Text += "z czego otrzymamy wartosci ASCII każdego znaku wiadomości" + Environment.NewLine;
                StepByStepEncryptBtn.Enabled = false;
                Encrypt_Btn.Enabled = false;
                StepByStepDecryptBtn.Enabled = false;
                Decrypt_Btn.Enabled = false;
                NextStepBtn.Enabled = true;
                encryptOrDecrypt = true;
                InputBox.Enabled = false;
                encryptionIterator = 0;
                stepbystepOutput = "";
                decryptionMessage = InputBox.Text.Split('-');
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić liczbowy klucz prywatny (pola N i D) oraz wiadomość do deszyfrowania", "", 0, MessageBoxIcon.Error);
            }
        }

        private void NextStepBtn_Click(object sender, EventArgs e)
        {
            if (encryptOrDecrypt == false)
            {
                if (encryptionIterator < InputBox.Text.Length) 
                {
                    InstructionLabel.Text += "Znak " + InputBox.Text[encryptionIterator] + " to w kodzie ASCII: " + Convert.ToInt32(InputBox.Text[encryptionIterator]) + Environment.NewLine;
                    string newletter = cypher.encryptAsciiCharacter(InputBox.Text[encryptionIterator], Convert.ToInt32(PublicKeyBox.Text), Convert.ToInt32(NBox.Text)).ToString();
                    InstructionLabel.Text += " zaszyfrowany wygląda tak: " + newletter + Environment.NewLine;
                    stepbystepOutput += newletter + "-";
                    InstructionLabel.Text += " Aktualny stan wiadomości wygląda tak: " + stepbystepOutput + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    stepbystepOutput=stepbystepOutput.Remove(stepbystepOutput.Length - 1);
                    InstructionLabel.Text += "Wiadomość końcowa wygląda tak:" + stepbystepOutput + Environment.NewLine;
                    OutputBox.Text = stepbystepOutput;
                    StepByStepEncryptBtn.Enabled = true;
                    Encrypt_Btn.Enabled = true;
                    StepByStepDecryptBtn.Enabled = true;
                    Decrypt_Btn.Enabled = true;
                    NextStepBtn.Enabled = false;
                    InputBox.Enabled = true;
                }


            }
            else
            {
                if (encryptionIterator < decryptionMessage.Length)
                {
                    char newletter = cypher.decryptAsciiCharacter(Convert.ToInt32(decryptionMessage[encryptionIterator]), Convert.ToInt32(PrivateKeyBox.Text), Convert.ToInt32(NBox.Text));
                    InstructionLabel.Text += "Liczba " + decryptionMessage[encryptionIterator] + " zdeszyfrowana to : " + (int)newletter + Environment.NewLine;
                    InstructionLabel.Text += "\n co dopowiada znakowi: " + newletter + Environment.NewLine;
                    stepbystepOutput += newletter;
                    InstructionLabel.Text += "\n Aktualny stan wiadomości wygląda tak: " + stepbystepOutput + Environment.NewLine + Environment.NewLine;
                }
                else
                {
                    InstructionLabel.Text += "Wiadomość końcowa wygląda tak:" + stepbystepOutput + Environment.NewLine;
                    OutputBox.Text = stepbystepOutput;
                    StepByStepEncryptBtn.Enabled = true;
                    Encrypt_Btn.Enabled = true;
                    StepByStepDecryptBtn.Enabled = true;
                    Decrypt_Btn.Enabled = true;
                    NextStepBtn.Enabled = false;
                    InputBox.Enabled = true;
                }
            }
            encryptionIterator++;   
        }

        private void RsaForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            RsaHelp help = new RsaHelp();
            help.Show();
        }
    }
}
