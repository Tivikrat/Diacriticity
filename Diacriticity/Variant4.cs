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
    public partial class Variant4 : Form
    {
        public Variant4()
        {
            InitializeComponent();
        }
        private void keyClick(object sender, EventArgs e)
        {
            btn_Remove();
            Button button = (Button)sender;
            printKey(button.Text[0], button.Left, button.Top);
            
            
        }

        private void printKey(char key, int left, int top)
        {
            key = checkBox1.Checked != checkBox3.Checked ? key.ToString().ToUpper()[0] : key.ToString().ToLower()[0];
            SetDiacriticial(key, left, top);

            textBox1.SelectedText = key.ToString();
            checkBox3.Checked = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = " ";
        }
        private void SetDiacriticial(char key, int left, int top)
            {
            string ss = Convert.ToString(Symbols.symbols[key]);
            int last = 0;
            for(int i = 0; i < ss.Length; i++)
            {
                Button button = new Button();
                button.Name = "btn" + i;
                button.Text = Convert.ToString(ss[i]);
                button.Size = new System.Drawing.Size(51, 51);
                button.Font = new Font("Microsoft Sans Serif", 14);
                button.Left = left + last;
                button.Top = top - 51;
                button.Click += new EventHandler(btn_click);
                last += 51;
                this.Controls.Add(button);
                button.BringToFront();
            }
           
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char[] chars = textBox1.Text.ToCharArray();
            chars[textBox1.SelectionStart - 1] = button.Text[0];
            textBox1.Text = string.Join("", chars);
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Focus();
            btn_Remove();
        }
        private void btn_Remove()
        {
            Controls.RemoveByKey("btn0");
            Controls.RemoveByKey("btn1");
            Controls.RemoveByKey("btn2");
            Controls.RemoveByKey("btn3");
            Controls.RemoveByKey("btn4");
            Controls.RemoveByKey("btn5");
            Controls.RemoveByKey("btn6");
            Controls.RemoveByKey("btn7");
            Controls.RemoveByKey("btn8");
            Controls.RemoveByKey("btn9");
            Controls.RemoveByKey("btn10");
            Controls.RemoveByKey("btn11");
            Controls.RemoveByKey("btn12");
            Controls.RemoveByKey("btn13");
            Controls.RemoveByKey("btn14");
            Controls.RemoveByKey("btn15");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            btn_Remove();
        }

        private void Variant4_MouseClick(object sender, MouseEventArgs e)
        {
            btn_Romove();
        }
    }
}
