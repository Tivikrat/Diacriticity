using System;
using System.Drawing;
using System.Windows.Forms;

namespace Diacriticity
{
    public partial class Variant3 : Form
    {
        public Variant3()
        {
            
            InitializeComponent();
        }

        private void keyClick(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            Button button = (Button)sender;
            printKey(button.Text[0]);

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
                //buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                buttonColumn.Width = 58;
                
                dataGridView1.Columns.Add(buttonColumn);
                
                dataGridView1[i, 0].Value = Symbols.symbols[key][i];
            }
        }

        private void printKey(char key)
        {
            key = checkBox1.Checked != checkBox3.Checked ? key.ToString().ToUpper()[0] : key.ToString().ToLower()[0];

            SetDiacriticial(key);
            textBox1.SelectedText = key.ToString();
            checkBox3.Checked = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView gridView = (DataGridView)sender;
            if (0 <= e.RowIndex && e.RowIndex < gridView.RowCount && 0 <= e.ColumnIndex && e.ColumnIndex <= gridView.ColumnCount)
            {
                char[] chars = textBox1.Text.ToCharArray();
                chars[textBox1.SelectionStart - 1] = gridView[e.ColumnIndex, e.RowIndex].Value.ToString()[0];
                textBox1.Text = string.Join("", chars);
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.Focus();
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = " ";
        }
    }
}
