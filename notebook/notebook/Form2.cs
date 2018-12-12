using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Размер файла: " + Form1.filesize;
            label2.Text = "Количество символов: " + Form1.ksymb;
            label3.Text = "Количество абзацев: " + Convert.ToString(Form1.kindent);
            label4.Text = "Количество авторских страниц: " + Form1.kas;
            label5.Text = "Количество гласных (латиница): " + Convert.ToString(Form1.kglasl);
            label6.Text = "Количество согласных (латиница): " + Convert.ToString(Form1.ksogll);
            label7.Text = "Количество гласных (кириллица): " + Convert.ToString(Form1.kglask);
            label8.Text = "Количество согласных (кириллица): " + Convert.ToString(Form1.ksoglk);
            label9.Text = "Количество цифр: " + Convert.ToString(Form1.knum);
            label10.Text = "Количество специальных символов: " + Convert.ToString(Form1.kspecsymb);
            label11.Text = "Количество знаков пунктуации: " + Convert.ToString(Form1.punctsymb);
            label12.Text = "Количество кириллических символов: " + Convert.ToString(Form1.kirsymb);
            label13.Text = "Количество латинских символов: " + Convert.ToString(Form1.latsymb);
        }
    }
}
