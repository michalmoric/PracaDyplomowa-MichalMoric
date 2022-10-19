using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PracaDyplomowa_MichalMoric.CezarCypher;

namespace PracaDyplomowa_MichalMoric
{
    public partial class CezarForm : Form
    {
        public CezarForm()
        {
            InitializeComponent();
            MessageOutputLabel.Text = "...";
            MessageOutputLabel.ReadOnly = true;
            MessageOutputLabel.BorderStyle = 0;
            MessageOutputLabel.BackColor = this.BackColor;
            MessageOutputLabel.TabStop = false;
        }
        private bool encryptOrDecrypt = false;
        private int offsetToGo = 0;
        CezarCypher cypher = new CezarCypher();
        private bool CheckForErrors()
        {
            if (InputMessageBox.Text.All(Char.IsLetter) == false || OffsetBox.Text.All(Char.IsNumber)== false)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void StepByStepEncryptBtn_Click(object sender, EventArgs e)
        {
            if(CheckForErrors() == false)
            {
                MessageBox.Show("Proszę podać prawidłowe dane wejsciowe: Wiadomość musi składać tylko z dużych i małych liter a przesunięcie musi być dodatnią liczbą całkowitą");
            }
            else
            {
                StepByStepEncryptBtn.Enabled = false;
                EncryptBtn.Enabled = false;
                StepByStepDecryptBtn.Enabled = false;
                DecryptBtn.Enabled = false;
                NextStepBtn.Enabled = true;
                MessageOutputLabel.Text = InputMessageBox.Text;
                InstructionLabel.Text = "Każda litera we wiadomości zostanie przesunięta o " + OffsetBox.Text + " miejsc w alfabecie w prawo";
                encryptOrDecrypt = false;
                offsetToGo = Int32.Parse(OffsetBox.Text) - 1;
            }
            

        }
        private void StepByStepDecryptBtn_Click(object sender, EventArgs e)
        {

            if (CheckForErrors() == false)
            {
                MessageBox.Show("Proszę podać prawidłowe dane wejsciowe: Wiadomość musi składać tylko z dużych i małych liter a przesunięcie musi być dodatnią liczbą całkowitą");
            }
            else
            {
                StepByStepEncryptBtn.Enabled = false;
                EncryptBtn.Enabled = false;
                StepByStepDecryptBtn.Enabled = false;
                DecryptBtn.Enabled = false;
                NextStepBtn.Enabled = true;
                MessageOutputLabel.Text = InputMessageBox.Text;
                InstructionLabel.Text = "Każda litera we wiadomości zostanie przesunięta o " + OffsetBox.Text + " miejsc w alfabecie w lewo";
                encryptOrDecrypt = true;
                offsetToGo = Int32.Parse(OffsetBox.Text) - 1;
            }
        }

        private void NextStepBtn_Click(object sender, EventArgs e)
        {
            if(encryptOrDecrypt == false)
            {
                if(offsetToGo == 0)
                {
                    InstructionLabel.Text = " Wiadomość końcowa wygląda tak:";
                    StepByStepEncryptBtn.Enabled = true;
                    EncryptBtn.Enabled = true;
                    StepByStepDecryptBtn.Enabled = true;
                    DecryptBtn.Enabled = true;
                    NextStepBtn.Enabled = false;
                }
                else
                {
                    InstructionLabel.Text = "Jeszcze "+ offsetToGo +" miejsc";

                }
                MessageOutputLabel.Text = cypher.ShiftTextRight(MessageOutputLabel.Text);
                offsetToGo--;

            }
            else
            {
                if (offsetToGo == 0)
                {
                    InstructionLabel.Text = " Wiadomość końcowa wygląda tak:";
                    StepByStepEncryptBtn.Enabled = true;
                    EncryptBtn.Enabled = true;
                    StepByStepDecryptBtn.Enabled = true;
                    DecryptBtn.Enabled = true;
                    NextStepBtn.Enabled = false;
                }
                else
                {
                    InstructionLabel.Text = "Jeszcze " + offsetToGo + " miejsc";

                }
                MessageOutputLabel.Text = cypher.ShiftTextLeft(MessageOutputLabel.Text);
                offsetToGo--;

            }
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (CheckForErrors() == false)
            {
                MessageBox.Show("Proszę podać prawidłowe dane wejsciowe: Wiadomość musi składać tylko z dużych i małych liter a przesunięcie musi być dodatnią liczbą całkowitą");
            }
            else
            {
                InstructionLabel.Text = " Wiadomość końcowa wygląda tak:";
                MessageOutputLabel.Text = cypher.CezarEncrypt(InputMessageBox.Text, Int32.Parse(OffsetBox.Text));
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (CheckForErrors() == false)
            {
                MessageBox.Show("Proszę podać prawidłowe dane wejsciowe: Wiadomość musi składać tylko z dużych i małych liter a przesunięcie musi być dodatnią liczbą całkowitą");
            }
            else
            {
                InstructionLabel.Text = " Wiadomość końcowa wygląda tak:";
                MessageOutputLabel.Text = cypher.CezarDecrypt(InputMessageBox.Text, Int32.Parse(OffsetBox.Text));
            }
        }
    }
}
