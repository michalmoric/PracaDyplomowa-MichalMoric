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
    public partial class PolibiusForm : Form
    {

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
        }

        private void AddCol_Btn_Click(object sender, EventArgs e)
        {
            Key_Grid.Columns.Add((Key_Grid.ColumnCount + 1).ToString(), (Key_Grid.ColumnCount + 1).ToString());
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
            Key_Grid.Rows.Add();
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
                    MessageBox.Show("All good");
                }
                else
                {
                    MessageBox.Show("Wszystke elementy klucza muszą być unikalne");
                }
            }
        }
    }
}
