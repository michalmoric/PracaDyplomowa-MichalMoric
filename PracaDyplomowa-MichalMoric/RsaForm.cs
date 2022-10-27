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
        public RsaForm()
        {
            InitializeComponent();
        }

        private void KeyGenBtn_Click(object sender, EventArgs e)
        {
            List<double> output = new List<double>();
            if(RandomButton.Checked == true)
            {
                output = cypher.GenerateKeys(0, 0);
                NBox.Text = output[0].ToString();
                PublicKeyBox.Text = output[2].ToString();
                PrivateKeyBox.Text = output[3].ToString();
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
                    }
                    else
                    {
                        MessageBox.Show("Obie liczby muszą być liczbami pierwszymi");
                    }
                }
                else
                {
                    MessageBox.Show("Proszę wprowadzić wartości liczbowe do pól P i Q");
                }
            }
        }

        private void Encrypt_Btn_Click(object sender, EventArgs e)
        {
            int i;
            if(int.TryParse(NBox.Text, out i) && int.TryParse(PublicKeyBox.Text, out i))
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
                    }
                    else
                    {
                        MessageBox.Show("Proszę podać liczbę");
                    }
                }
                else if (ASCIIButton.Checked)
                {
                    OutputBox.Text = cypher.encryptAscii(InputBox.Text, E, n).ToString();
                }
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić liczbowy klucz publiczny (pola N i E)");
            }
        }

        private void Decrypt_Btn_Click(object sender, EventArgs e)
        {
            int i;

            if(int.TryParse(NBox.Text, out i) && int.TryParse(PrivateKeyBox.Text, out i))
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
                    }
                    else
                    {
                        MessageBox.Show("Proszę podać liczbę");
                    }
                }
                else if (ASCIIButton.Checked)
                {
                    OutputBox.Text = cypher.decryptAscii(InputBox.Text, d, n);
                }


            }
            else
            {
                MessageBox.Show("Proszę wprowadzić liczbowy klucz prywatny (pola N i D)");
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
    }
}
