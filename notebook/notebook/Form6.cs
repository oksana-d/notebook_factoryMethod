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
    public partial class Form6 : Form
    {
        public Form6(string str)
        {
            InitializeComponent();

            string regex = @"\s([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}";
            string result = "";
            foreach (Match match in Regex.Matches(str, regex))
            {
                result = result + match.Value + "\n";
                match.NextMatch();
            }
            if (result.Length != 0)
            {
                label2.Text = result;
            }
            else
            {
                MessageBox.Show("Корректные электронные адреса не найдены!", "Сообщение");
                this.Close();
            }
        }
    }
}
