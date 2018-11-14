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
    public partial class MainForm : Form
    {
        Variant1 variant1 = new Variant1();
        Variant2 variant2 = new Variant2();
        Variant3 variant3 = new Variant3();
        Variant4 variant4 = new Variant4();
        Variant5 variant5 = new Variant5();
        public MainForm()
        {
            InitializeComponent();
            variant1.FormClosing += Variant1_FormClosing;
            variant2.FormClosing += Variant2_FormClosing;
            variant3.FormClosing += Variant3_FormClosing;
            variant4.FormClosing += Variant4_FormClosing;
            variant5.FormClosing += Variant5_FormClosing;
        }

        private void Variant1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            variant1.Hide();
        }

        private void Variant2_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            variant2.Hide();
        }

        private void Variant3_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            variant3.Hide();
        }

        private void Variant4_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            variant4.Hide();
        }

        private void Variant5_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            variant5.Hide();
        }

        private void buttonVariant1_Click(object sender, EventArgs e)
        {
            variant1.Show();
        }

        private void buttonVariant2_Click(object sender, EventArgs e)
        {
            variant2.Show();
        }

        private void buttonVariant3_Click(object sender, EventArgs e)
        {
            variant3.Show();
        }

        private void buttonVariant4_Click(object sender, EventArgs e)
        {
            variant4.Show();
        }

        private void buttonVariant5_Click(object sender, EventArgs e)
        {
            variant5.Show();
        }
    }
}
