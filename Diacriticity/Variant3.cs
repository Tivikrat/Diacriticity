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
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("L");
                textBox1.Text += "L";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("l");
                textBox1.Text += "l";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Q");
                textBox1.Text += "Q";
                checkBox3.Checked = false;
            }
            else
            {
                textBox1.Text += "q";
                SendKeys.Send("q");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("W");
                textBox1.Text += "W";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("w");
                textBox1.Text += "w";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("E");
                textBox1.Text += "E";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("e");
                textBox1.Text += "e";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("R");
                textBox1.Text += "R";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("r");
                textBox1.Text += "r";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("T");
                textBox1.Text += "T";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("t");
                textBox1.Text += "t";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Y");
                textBox1.Text += "Y";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("y");
                textBox1.Text += "y";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("U");
                textBox1.Text += "U";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("u");
                textBox1.Text += "u";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("I");
                textBox1.Text += "I";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("i");
                textBox1.Text += "i";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("O");
                textBox1.Text += "O";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("o");
                textBox1.Text += "o";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("P");
                textBox1.Text += "P";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("p");
                textBox1.Text += "p";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("A");
                textBox1.Text += "A";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("a");
                textBox1.Text += "a";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("S");
                textBox1.Text += "S";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("s");
                textBox1.Text += "s";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("D");
                textBox1.Text += "D";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("d");
                textBox1.Text += "d";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("F");
                textBox1.Text += "F";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("f");
                textBox1.Text += "f";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("G");
                textBox1.Text += "G";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("g");
                textBox1.Text += "g";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("H");
                textBox1.Text += "H";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("h");
                textBox1.Text += "h";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("J");
                textBox1.Text += "J";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("j");
                textBox1.Text += "j";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("K");
                textBox1.Text += "K";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("k");
                textBox1.Text += "k";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Z");
                textBox1.Text += "Z";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("z");
                textBox1.Text += "z";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("X");
                textBox1.Text += "X";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("x");
                textBox1.Text += "x";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("C");
                textBox1.Text += "C";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("c");
                textBox1.Text += "c";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("V");
                textBox1.Text += "V";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("v");
                textBox1.Text += "v";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("B");
                textBox1.Text += "B";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("b");
                textBox1.Text += "b";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("N");
                textBox1.Text += "N";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("n");
                textBox1.Text += "n";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("M");
                textBox1.Text += "M";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("m");
                textBox1.Text += "m";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += " ";
        }
    }
}
