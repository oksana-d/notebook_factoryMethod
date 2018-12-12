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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = Form1.text;
            if (checkBox1.Checked)
            {
                string regex = @"[а-я]{2,3}\.\s[А-Я]{1}[а-я]{1,15}\,\s{0,1}[а-я]{0,1}\.{0,1}\s[0-9]{1,4}\,\s[а-я]{0,2}\.{0,1}\s{0,1}[0-9]{0,4}\,{0,1}\s[а-я]{1}\.\s[А-Я]{1}[а-я]{2,15}\,\s[0-9]{5}";
                string result = "";
                foreach (Match match in Regex.Matches(str, regex))
                {
                    result = result + match.Value + "\n";
                    match.NextMatch();
                }
                if (result.Length != 0)
                {
                    new Form8("Адреса в соответствии с правилами указания почтовых адресов в Украине:", result, 460, 124).ShowDialog();
                }
                else
                {
                    label2.Text = "Файл не содержит адреса в соответствии с правилами указания почтовых адресов в Украине";
                }
            }

            if (checkBox2.Checked)
            {
                string regex = @"\w*\.edu\.ua|\w*\.net\.ua|\w*\.com\.ua|\w*\.in\.ua|\w*\.org\.ua";
                string result = "";
                foreach (Match match in Regex.Matches(str, regex))
                {
                    result = result + match.Value + "\n";
                    match.NextMatch();
                }
                if (result.Length != 0)
                {
                    new Form8("Интернет адреса из доменных зон edu.ua, net.ua, com.ua, in.ua, org.ua:", result, 455, 124).ShowDialog();
                }
                else
                {
                    label2.Text = "Файл не содержит интернет адреса из доменных зон edu.ua, net.ua, com.ua, in.ua, org.ua";
                }
            }

            if (checkBox3.Checked)
            {
                string regex = @"\‘[0 - 9]{ 1,9}\’|\“[0-9]{1,9}\”";
                string result = "";
                foreach (Match match in Regex.Matches(str, regex))
                {
                    result = result + match.Value + "\n";
                    match.NextMatch();
                }
                if (result.Length != 0)
                {
                    new Form8("Целочисленные константы, заключенные в двойные или одинарные кавычки:", result, 460, 124).ShowDialog();
                }
                else
                {
                    label2.Text = "Файл не содержит целочисленные константы, заключенные в двойные или одинарные кавычки";
                }
            }

            if (checkBox4.Checked)
            {
                string regex = @"'[0-9]+\.[0-9]+'|\”[0-9]+\.[0-9]+\”";
                string result = "";
                foreach (Match match in Regex.Matches(str, regex))
                {
                    result = result + match.Value + "\n";
                    match.NextMatch();
                }
                if (result.Length != 0)
                { 
                    new Form8("Вещественные константы, заключенные в двойные или одинарные кавычки:", result, 450, 124).ShowDialog();
                }
                else
                {
                    label2.Text = "Файл не содержит вещественные константы, заключенные в двойные или одинарные кавычки";
                }
            }

            if (checkBox5.Checked)
            {
                string regex = @"‘[0-9]{1,9}\+?-?[0-9]?\*?[i,I]’|”[0-9]{1,9}\+?-?[0-9]?\*?[i,I]”";
                string result = "";
                foreach (Match match in Regex.Matches(str, regex))
                {
                    result = result + match.Value + "\n";
                    match.NextMatch();
                }
                if (result.Length != 0)
                {
                    new Form8("Комплексные константы, заключенные в двойные или одинарные кавычки:", result, 450, 124).ShowDialog();
                }
                else
                { 
                    label2.Text = "Файл не содержит комплексные константы, заключенные в двойные или одинарные кавычки";
                }
            }

            if (checkBox6.Checked)
            {
                string regex = @"char|break|Char";
                string result = "";
                foreach (Match match in Regex.Matches(str, regex))
                {
                    result = result + match.Value + "\n";
                    match.NextMatch();
                }
                if (result.Length != 0)
                {
                    new Form8("Ключевые слова C#:", result, 300, 125).ShowDialog();
                }
                else
                {
                    label2.Text = "Файл не содержит ключевые слова C#";
                }

            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox1.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox1.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox1.Enabled = false;
            checkBox6.Enabled = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox1.Enabled = false;
            checkBox5.Enabled = false;
        }
    }
}
