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
    public partial class Variant3 : Form
    {
        public Variant3()
        {
            InitializeComponent();
        }
        private const long WS_EX_NOACTIVATE = 0x08000000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams baseParams = base.CreateParams;

                baseParams.ExStyle |= (int)WS_EX_NOACTIVATE;

                return baseParams;

            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            printKey('L', 'l');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printKey('Q', 'q');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printKey('W', 'w');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printKey('E', 'e');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printKey('R', 'r');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printKey('T', 't');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            printKey('Y', 'y');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            printKey('U', 'u');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            printKey('I', 'i');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            printKey('O', 'o');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            printKey('P', 'p');
        }

        private void button19_Click(object sender, EventArgs e)
        {
            printKey('A', 'a');
        }

        private void button18_Click(object sender, EventArgs e)
        {
            printKey('S', 's');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            printKey('D', 'd');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            printKey('F', 'f');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            printKey('G', 'g');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            printKey('H', 'h');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            printKey('J', 'j');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            printKey('K', 'k');
        }

        private void button26_Click(object sender, EventArgs e)
        {
            printKey('Z', 'z');
        }

        private void button25_Click(object sender, EventArgs e)
        {
            printKey('X', 'x');
        }

        private void button24_Click(object sender, EventArgs e)
        {
            printKey('C', 'c');
        }

        private void button23_Click(object sender, EventArgs e)
        {
            printKey('V', 'v');
        }

        private void button22_Click(object sender, EventArgs e)
        {
            printKey('B', 'b');
        }

        private void button21_Click(object sender, EventArgs e)
        {
            printKey('N', 'n');
        }

        private void button20_Click(object sender, EventArgs e)
        {
            printKey('M', 'm');
        }

        private void printKey(char big, char small)
        {
            char key = (checkBox1.Checked != checkBox3.Checked ? big : small);
            SendKeys.Send(key.ToString());
            textBox1.SelectedText = key.ToString();
            checkBox3.Checked = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = " ";
        }
    }
}
