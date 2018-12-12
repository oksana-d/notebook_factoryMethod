using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notebook
{
    public partial class Form7 : Form
    {
        public Form7(string resultstr)
        {
            InitializeComponent();
            textBox1.Text = resultstr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.text = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
