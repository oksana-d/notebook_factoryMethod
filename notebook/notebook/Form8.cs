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
    public partial class Form8 : Form
    {
        public Form8(string str, string s, int sizew, int sizeh)
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(sizew , sizeh);
            label1.Text = str;
            label2.Text = s;
        }
    }
}
