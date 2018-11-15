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
    public partial class Variant1 : Form
    {
        public Variant1()
        {
            InitializeComponent();
        }

        private void SetDiacriticial(char key)
        {
            if (!Symbols.symbols.ContainsKey(key))
            {
                return;
            }
            for (int i = 0; i < Symbols.symbols[key].Length; i++)
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns.Add(buttonColumn);
                dataGridView1[i, 0].Value = Symbols.symbols[key][i];
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            if (richTextBox1.SelectionStart > 0)
            {
                SetDiacriticial(richTextBox1.Text[richTextBox1.SelectionStart - 1]);
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            if (richTextBox1.SelectionStart > 0)
            {
                if (richTextBox1.SelectionLength == 1)
                {
                    SetDiacriticial(richTextBox1.SelectedText[0]);
                }
                else
                {
                    SetDiacriticial(richTextBox1.Text[richTextBox1.SelectionStart - 1]);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            if (0 <= e.RowIndex && e.RowIndex < gridView.RowCount && 0 <= e.ColumnIndex && e.ColumnIndex <= gridView.ColumnCount)
            {
                char[] chars = richTextBox1.Text.ToCharArray();
                chars[richTextBox1.SelectionStart - 1] = gridView[e.ColumnIndex, e.RowIndex].Value.ToString()[0];
                int selectionStart = richTextBox1.SelectionStart;
                richTextBox1.Text = string.Join("", chars);
                richTextBox1.SelectionStart = selectionStart;
            }
        }
    }
}
