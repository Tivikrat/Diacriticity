using System;
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
            Button button = (Button)sender;
            printKey(button.Text[0]);
        }

        private void printKey(char key)
        {
            key = checkBox1.Checked != checkBox3.Checked ? key.ToString().ToUpper()[0] : key.ToString().ToLower()[0];
            textBox1.SelectedText = key.ToString();
            checkBox3.Checked = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = " ";
        }
    }
}
