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
            List<double> output = cypher.GenerateKeys(0, 0);
            NBox.Text = output[0].ToString();
            PublicKeyBox.Text = output[2].ToString();
            PrivateKeyBox.Text = output[3].ToString();
        }

        private void Encrypt_Btn_Click(object sender, EventArgs e)
        {
            int message = Convert.ToInt32(MessageBox.Text);
            BigInteger power = BigInteger.Pow(message, Convert.ToInt32(PublicKeyBox.Text));
            BigInteger output = power % Convert.ToInt32(NBox.Text);
            OutputBox.Text =output.ToString();
        }

        private void Decrypt_Btn_Click(object sender, EventArgs e)
        {
            int message = Convert.ToInt32(MessageBox.Text);
            int d = Convert.ToInt32(PrivateKeyBox.Text);
            int n = Convert.ToInt32(NBox.Text);
            BigInteger power = BigInteger.Pow(message, d);
            BigInteger output = power % n;
            OutputBox.Text = output.ToString();
            
        }
    }
}
