using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Diacriticity
{
    public partial class Variant3 : Form
    {
        List<Button> btns = new List<Button>();
        
        public Variant3()
        {
            btn_inizilize();
            
            InitializeComponent();
        }
        
        
        //Button[] buttons = new Button[] { button28, button29 };
        private void keyClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            printKey(button.Text[0]);
            string ss = Symbols.symbols[button.Text[0]];
            if (ss.Length != 0)
            {
                for (int i = 0; i < ss.Length - 1; i++)
                {
                    //buttons[i].Text = Convert.ToString(ss[i]);
                    //buttons[i].Visible = true;
                }
            }
        }

        private void printKey(char key)
        {
            key = (checkBox1.Checked != checkBox3.Checked ? key.ToString().ToUpper()[0] : key.ToString().ToLower()[0]);
            SendKeys.Send(key.ToString());
            textBox1.SelectedText = key.ToString();
            checkBox3.Checked = false;
        }
        private void btn_novisible()
        {
            button28.Visible = false;
            button29.Visible = false;
            button30.Visible = false;
            button31.Visible = false;
            button32.Visible = false;
            button33.Visible = false;
            button34.Visible = false;
            button35.Visible = false;
            button36.Visible = false;
            button37.Visible = false;
            button38.Visible = false;
            button39.Visible = false;
            button40.Visible = false;
            button41.Visible = false;
            button42.Visible = false;
        }
        private void btn_inizilize()
        {
            Button button = new Button();
            button = button28;
            btns.Add(button);
            
        }
        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = " ";
        }
    }
}
