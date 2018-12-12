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
    public partial class Form3 : Form
    {
        public Form3(string str)
        {
            InitializeComponent();
            Regex regex = new Regex(@"[А-ЯA-Z][а-яa-z]+ [А-ЯA-Z][а-яa-z]+");
            Match match = regex.Match(str);
            if (match.Value != "0")
            {
                label4.Text = match.Value;
            }
            else
            {
                MessageBox.Show("Совпадения не найдены!", "Сообщение");
                this.Close();
            }
        }
    }
}
