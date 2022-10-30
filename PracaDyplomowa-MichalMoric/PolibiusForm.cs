using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PracaDyplomowa_MichalMoric.PolibiusCypher;

namespace PracaDyplomowa_MichalMoric
{
    public partial class PolibiusForm : Form
    {
        List<List<string>> charMatrix = new List<List<string>>();
        bool encryptMode = false;
        int messageLength = 0;
        private bool encryptOrDecrypt = false;
        int encryptionIterator = 0;
        PolibiusCypher cypher = new PolibiusCypher();

        public PolibiusForm()
        {
            InitializeComponent();
            Key_Grid.Columns.Add("1", "1");
            Key_Grid.Columns.Add("2", "2");
            Key_Grid.Columns.Add("3", "3");
            Key_Grid.Columns.Add("4", "4");
            Key_Grid.Columns.Add("5", "5");
            Key_Grid.Rows.Add("A","B","C","D","E");
            Key_Grid.Rows.Add("F","G","H","I","J");
            Key_Grid.Rows.Add("L", "M", "N", "O", "P");
            Key_Grid.Rows.Add("Q", "R", "S", "T", "U");
            Key_Grid.Rows.Add("V", "W", "X", "Y", "Z");
            MessageOutputLabel.Text = "...";
            MessageOutputLabel.ReadOnly = true;
            MessageOutputLabel.BorderStyle = 0;
            MessageOutputLabel.BackColor = this.BackColor;
            MessageOutputLabel.TabStop = false;
        }
       
        private void AddCol_Btn_Click(object sender, EventArgs e)
        {
            if(Key_Grid.ColumnCount== 9)
            {
                MessageBox.Show("Program nie wspiera kluczy większych od 9 kolumn");
            }
            else
            {
                Key_Grid.Columns.Add((Key_Grid.ColumnCount + 1).ToString(), (Key_Grid.ColumnCount + 1).ToString());
            }
        }

        private void DelCol_Btn_Click(object sender, EventArgs e)
        {
            if (Key_Grid.ColumnCount == 2)
            {
                MessageBox.Show("Nie może być mniej niż 2 kolumny");
            }
            else
            {
                Key_Grid.Columns.Remove(Key_Grid.ColumnCount.ToString());
            }
        }

        private void AddRow_Btn_Click(object sender, EventArgs e)
        {
            if (Key_Grid.RowCount == 9)
            {
                MessageBox.Show("Program nie wspiera kluczy większych od 9 wierszy");
            }
            else
            {
                Key_Grid.Rows.Add();
            }
            
        }

        private void DelRow_Btn_Click(object sender, EventArgs e)
        {
            if (Key_Grid.RowCount == 2)
            {
                MessageBox.Show("Nie może być mniej niż 2 wiersze");
            }
            else
            {
                Key_Grid.Rows.RemoveAt(Key_Grid.RowCount - 1);
            }
        }

        private void Val_Btn_Click(object sender, EventArgs e)
        {
            List<String> allCells = new List<string>();
            bool valid = true;
            foreach(DataGridViewRow row in Key_Grid.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    if(cell.Value == null)
                    {
                        valid = false;
                        MessageBox.Show("Nie może być pustych wartości");
                        break;
                    }
                    else if(cell.Value.ToString().Length != 1)
                    {
                        valid = false;
                        MessageBox.Show("Każda wartość musi być 1 znakiem");
                        break;
                    }
                    else
                    {
                        allCells.Add(cell.Value.ToString());
                    }
                }
                if (valid == false) break;
            }
            if(valid == true)
            {
                if (allCells.Distinct().Count()== allCells.Count())
                {
                    Val_Btn.Enabled = false;
                    RelKey_Btn.Enabled = true;
                    Key_Grid.Enabled = false;
                    StepByStepEncryptBtn.Enabled = true;
                    EncryptBtn.Enabled = true;
                    StepByStepDecryptBtn.Enabled = true;
                    DecryptBtn.Enabled = true;
                    NextStepBtn.Enabled = false;
                    AddCol_Btn.Enabled = false;
                    AddRow_Btn.Enabled = false;
                    DelCol_Btn.Enabled = false;
                    DelRow_Btn.Enabled = false;
                    foreach (DataGridViewRow row in Key_Grid.Rows)
                    {
                        List<string> charRow = new List<string>();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            charRow.Add(cell.Value.ToString());
                        }
                        charMatrix.Add(charRow);
                    }
                }
                else
                {
                    MessageBox.Show("Wszystke elementy klucza muszą być unikalne");
                }
            }
        }

        private void RelKey_Btn_Click(object sender, EventArgs e)
        {

            Val_Btn.Enabled = true;
            RelKey_Btn.Enabled = false;
            Key_Grid.Enabled = true;
            StepByStepEncryptBtn.Enabled = false;
            EncryptBtn.Enabled = false;
            StepByStepDecryptBtn.Enabled = false;
            DecryptBtn.Enabled = false;
            NextStepBtn.Enabled = false;
            AddCol_Btn.Enabled = true;
            AddRow_Btn.Enabled = true;
            DelCol_Btn.Enabled = true;
            DelRow_Btn.Enabled = true;
            charMatrix.Clear();
        }

        private void StepByStepEncryptBtn_Click(object sender, EventArgs e)
        {
            if (InputMessageBox.Text.Length > 0)
            {
                InstructionLabel.Text = "Szyfr polibiusza znajdować będzie znaki z wiadomości i \n dopasowywać je do znaków w matrycy(kluczu) \n i zamieni je na parę liczb odpowiadających wierszowi i kolumnie";
                StepByStepEncryptBtn.Enabled = false;
                EncryptBtn.Enabled = false;
                StepByStepDecryptBtn.Enabled = false;
                DecryptBtn.Enabled = false;
                NextStepBtn.Enabled = true;
                messageLength = InputMessageBox.Text.Length;
                encryptOrDecrypt = false;
                encryptionIterator = 0;
                MessageOutputLabel.Text = "";
                InputMessageBox.Enabled = false;
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić wiadomość");
            }
        }
        private void StepByStepDecryptBtn_Click(object sender, EventArgs e)
        {
            if (InputMessageBox.Text.Length > 0)
            {
                if((InputMessageBox.Text.Length % 2) == 0 )
                {
                    InstructionLabel.Text = "Szyfr polibiusza przy deszyfrowaniu wezmie pary \nindeksów z wiadomosci i zastąpi je odpowiednimi literami z klucza";
                    StepByStepEncryptBtn.Enabled = false;
                    EncryptBtn.Enabled = false;
                    StepByStepDecryptBtn.Enabled = false;
                    DecryptBtn.Enabled = false;
                    NextStepBtn.Enabled = true;
                    messageLength = InputMessageBox.Text.Length;
                    encryptOrDecrypt = true;
                    encryptionIterator = 0;
                    MessageOutputLabel.Text = "";
                    InputMessageBox.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Liczba znaków w wiadomosci musi być parzysta");
                }
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić wiadomość");
            }
        }
        private void NextStepBtn_Click(object sender, EventArgs e)
        {
            if (encryptionIterator < messageLength)
            {
                if (encryptOrDecrypt == false)
                {
                    string result = cypher.OneLetterEncript(charMatrix, InputMessageBox.Text[encryptionIterator].ToString(), encryptMode);
                    if (result == "")
                    {
                        InstructionLabel.Text = "Znaku " + InputMessageBox.Text[encryptionIterator].ToString() + " w kluczu nie ma więc zostanie pominęty i nie \nbędzie widoczny po odszyfrowaniu wiadomosci";
                    }
                    else
                    {
                        if (encryptMode == false)
                        {
                            InstructionLabel.Text = "Znak " + InputMessageBox.Text[encryptionIterator].ToString() + " jest w kluczu w wierszu " + result[0] + " i w kolumnie " + result[1] + " więc \nzakodowany będzie jako: " + result[0] + result[1];
                        }
                        else
                        {
                            InstructionLabel.Text = "Znak " + InputMessageBox.Text[encryptionIterator].ToString() + " jest w kluczu w kolumnie " + result[0] + " i w wierszu " + result[1] + " więc \nzakodowany będzie jako: " + result[0] + result[1];
                        }
                        String addLetter = (result[0]).ToString();
                        addLetter += result[1].ToString();
                        MessageOutputLabel.Text += addLetter;

                    }
                    encryptionIterator++;
                }
                else
                {
                    string letter = InputMessageBox.Text[encryptionIterator].ToString() + InputMessageBox.Text[encryptionIterator + 1].ToString();
                    string result = cypher.OneLetterDecript(charMatrix, letter, encryptMode);
                    if (result == "")
                    {
                        InstructionLabel.Text = "W kluczu podano litere lub indeksy \nbyły za duże więc ten znak zostanie pomninęty";
                    }
                    else
                    {
                        if (encryptMode == false)
                        {
                            InstructionLabel.Text = "Wiersz " + InputMessageBox.Text[encryptionIterator].ToString() + " i Kolumna " +InputMessageBox.Text[encryptionIterator+1].ToString()+ " odpowiadają znakowi: "+ result;
                        }
                        else
                        {
                            InstructionLabel.Text = "Kolumna " + InputMessageBox.Text[encryptionIterator].ToString() + " i Wiersz " + InputMessageBox.Text[encryptionIterator + 1].ToString() + " odpowiadają znakowi: " + result;
                        }
                        
                        MessageOutputLabel.Text += result;

                    }
                    encryptionIterator= encryptionIterator +2;
                }
            }
            else
            {
                InstructionLabel.Text = "Zaszyfrowana wiadomość wygląda w następujący sposób:";
                StepByStepEncryptBtn.Enabled = true;
                EncryptBtn.Enabled = true;
                StepByStepDecryptBtn.Enabled = true;
                DecryptBtn.Enabled = true;
                NextStepBtn.Enabled = false;
                InputMessageBox.Enabled = true;
            }
           
        }
        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (InputMessageBox.Text.Length > 0)
            {
                InstructionLabel.Text = "Zaszyfrowana wiadomość wygląda tak:";
                MessageOutputLabel.Text = cypher.PolibiusEncrypt(charMatrix, InputMessageBox.Text, encryptMode);
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić wiadomość");
            }
        }
        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (InputMessageBox.Text.Length > 0)
            {
                if ((InputMessageBox.Text.Length % 2) == 0)
                {
                    InstructionLabel.Text = "Odszyfrowana wiadomość wygląda tak:";
                    MessageOutputLabel.Text = cypher.PolibiusDecrypt(charMatrix, InputMessageBox.Text, encryptMode);
                }
                else
                {
                    MessageBox.Show("Liczba znaków w wiadomosci musi być parzysta");
                }
            }
            else
            {
                MessageBox.Show("Proszę wprowadzić wiadomość");
            }
            
        }

        private void RowColRad_CheckedChanged(object sender, EventArgs e)
        {
            encryptMode = false;
        }

        private void ColRowRad_CheckedChanged(object sender, EventArgs e)
        {
            encryptMode = true;
        }
    }
}
