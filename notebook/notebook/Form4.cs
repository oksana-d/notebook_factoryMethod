using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace notebook
{
    public partial class Form4 : Form
    {
        public Form4(string str)
        {
            InitializeComponent();
            Regex regex = new Regex(@"[А-ЯA-Z][а-яa-z]+ [А-ЯA-Z]\.[А-ЯA-Z]\.");
            Match match = regex.Match(str);
            if (match.Value != "0")
            {
                label3.Text = match.Value;
            }
            else
            {
                MessageBox.Show("Совпадения не найдены!", "Сообщение");
                this.Close();
            }
        }
    }
}
