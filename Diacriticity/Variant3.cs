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
                textBox1.SelectedText = "L";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("l");
                textBox1.SelectedText = "l";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Q");
                textBox1.SelectedText = "Q";
                checkBox3.Checked = false;
            }
            else
            {
                textBox1.SelectedText = "q";
                SendKeys.Send("q");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("W");
                textBox1.SelectedText = "W";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("w");
                textBox1.SelectedText = "w";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("E");
                textBox1.SelectedText = "E";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("e");
                textBox1.SelectedText = "e";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("R");
                textBox1.SelectedText = "R";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("r");
                textBox1.SelectedText = "r";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("T");
                textBox1.SelectedText = "T";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("t");
                textBox1.SelectedText = "t";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Y");
                textBox1.SelectedText = "Y";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("y");
                textBox1.SelectedText = "y";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("U");
                textBox1.SelectedText = "U";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("u");
                textBox1.SelectedText = "u";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("I");
                textBox1.SelectedText = "I";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("i");
                textBox1.SelectedText = "i";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("O");
                textBox1.SelectedText = "O";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("o");
                textBox1.SelectedText = "o";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("P");
                textBox1.SelectedText = "P";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("p");
                textBox1.SelectedText = "p";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("A");
                textBox1.SelectedText = "A";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("a");
                textBox1.SelectedText = "a";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("S");
                textBox1.SelectedText = "S";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("s");
                textBox1.SelectedText = "s";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("D");
                textBox1.SelectedText = "D";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("d");
                textBox1.SelectedText = "d";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("F");
                textBox1.SelectedText = "F";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("f");
                textBox1.SelectedText = "f";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("G");
                textBox1.SelectedText = "G";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("g");
                textBox1.SelectedText = "g";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("H");
                textBox1.SelectedText = "H";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("h");
                textBox1.SelectedText = "h";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("J");
                textBox1.SelectedText = "J";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("j");
                textBox1.SelectedText = "j";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("K");
                textBox1.SelectedText = "K";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("k");
                textBox1.SelectedText = "k";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("Z");
                textBox1.SelectedText = "Z";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("z");
                textBox1.SelectedText = "z";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("X");
                textBox1.SelectedText = "X";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("x");
                textBox1.SelectedText = "x";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("C");
                textBox1.SelectedText = "C";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("c");
                textBox1.SelectedText = "c";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("V");
                textBox1.SelectedText = "V";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("v");
                textBox1.SelectedText = "v";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("B");
                textBox1.SelectedText = "B";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("b");
                textBox1.SelectedText = "b";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("N");
                textBox1.SelectedText = "N";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("n");
                textBox1.SelectedText = "n";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox3.Checked)
            {
                SendKeys.Send("M");
                textBox1.SelectedText = "M";
                checkBox3.Checked = false;
            }
            else
            {
                SendKeys.Send("m");
                textBox1.SelectedText = "m";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = " ";
        }
    }
}
