using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDyplomowa_MichalMoric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cezar_Button_Click(object sender, EventArgs e)
        {
            CezarForm form = new CezarForm();
            form.Show();
        }

        private void Polibius_Button_Click(object sender, EventArgs e)
        {
            PolibiusForm form = new PolibiusForm();
            form.Show();
        }

        private void Rsa_Button_Click(object sender, EventArgs e)
        {
            RsaForm form = new RsaForm();
            form.Show();
        }
    }
}
