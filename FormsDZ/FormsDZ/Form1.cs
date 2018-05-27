using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsDZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (e.KeyChar == '.') e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1) e.Handled = true;
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter) button1.Focus();
                return;
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double pnd;
            double kg;

            try
            {
                pnd = Convert.ToDouble(textBox1.Text);
                kg = pnd * 0.45359237;
                label2.Text = kg.ToString("n") + " килограмм";
            }
            catch
            {
                textBox1.Focus();
            }
        }
    }
}
