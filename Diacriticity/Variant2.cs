using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diacriticity
{
    public partial class Variant2 : Form
    {
        int selectedColumn, selectedRow;
        public Variant2()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(3);
        }

        private void SetDiacriticial(char key)
        {
            if (!Symbols.symbols.ContainsKey(key))
            {
                return;
            }
            dataGridView1.ClearSelection();
            dataGridView1[0, 0].Selected = true;
            selectedColumn = 0;
            selectedRow = 0;
            for (int i = 0; i < Symbols.symbols[key].Length; i++)
            {
                dataGridView1[i % 4, i / 4].Value = Symbols.symbols[key][i];
            }
        }

        private void ClearTable()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dataGridView1[i, j].Value = "";
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ClearTable();
            if (richTextBox1.SelectionStart > 0)
            {
                SetDiacriticial(richTextBox1.Text[richTextBox1.SelectionStart - 1]);
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            ClearTable();
            if (richTextBox1.SelectionStart > 0)
            {
                SetDiacriticial(richTextBox1.Text[richTextBox1.SelectionStart - 1]);
            }
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad4)
            {
                e.SuppressKeyPress = true;
                dataGridView1.ClearSelection();
                selectedColumn = (selectedColumn > 1 ? selectedColumn - 1 : 0);
                dataGridView1[selectedColumn, selectedRow].Selected = true;
            }
            if (e.KeyCode == Keys.NumPad8)
            {
                e.SuppressKeyPress = true;
                dataGridView1.ClearSelection();
                selectedRow = (selectedRow > 1 ? selectedRow - 1 : 0);
                dataGridView1[selectedColumn, selectedRow].Selected = true;
            }
            if (e.KeyCode == Keys.NumPad2)
            {
                e.SuppressKeyPress = true;
                dataGridView1.ClearSelection();
                selectedRow = (selectedRow < 3 ? selectedRow + 1 : 0);
                dataGridView1[selectedColumn, selectedRow].Selected = true;
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                e.SuppressKeyPress = true;
                dataGridView1.ClearSelection();
                selectedColumn = (selectedColumn < 2 ? selectedColumn + 1 : 0);
                dataGridView1[selectedColumn, selectedRow].Selected = true;
            }
            if (e.KeyCode == Keys.NumPad0)
            {
                e.SuppressKeyPress = true;
                if (dataGridView1[selectedColumn, selectedRow].Value.ToString() != "")
                {
                    char[] chars = richTextBox1.Text.ToCharArray();
                    chars[richTextBox1.SelectionStart - 1] = dataGridView1[selectedColumn, selectedRow].Value.ToString()[0];
                    int selectionStart = richTextBox1.SelectionStart;
                    richTextBox1.Text = string.Join("", chars);
                    richTextBox1.SelectionStart = selectionStart;
                }
            }
        }
    }
}
