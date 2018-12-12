using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace notebook
{
    public partial class Form1 : Document
    {
        private static Form1 instance; //ссылка на конкретный экземпляр
        private static int MaxCountWindow = 10; //максимальное число экземпляров
        private static int countWindow = 0; //текущее число экземпляров
        protected Form1() //защищенный конструктор
        {
            InitializeComponent();
        }
        public static Form1 getInstance() //метод, позволяющий создать экземпляр
        {
            if (countWindow < MaxCountWindow)
            {
                instance = new Form1();
                countWindow++;
            } else MessageBox.Show("Достигнуто максимальное число внутренних форм: " + MaxCountWindow, "Ошибка");
            return instance;
        }
        

        public static string filesize;
        public static string ksymb;
        public static int kindent;
        public static string kas;
        public static int kglasl;
        public static int ksogll;
        public static int kglask;
        public static int ksoglk;
        public static int knum;
        public static int kspecsymb;
        public static int punctsymb;
        public static int latsymb;
        public static int kirsymb;
        public static string resultstring;
        public static string text;

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                DialogResult rez = MessageBox.Show("Блокнот содержит текст. Сохранить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rez == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.FileName = "Безымянный";
                    sfd.Filter = "Текстовый документ|.*txt";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, textBox1.Text);
                        textBox1.Clear();
                    }
                }

                if (rez == DialogResult.No)
                {
                    textBox1.Clear();
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовые документы|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(Path.GetFullPath(ofd.FileName));
                filesize = getfilesize(new System.IO.FileInfo(ofd.FileName));
            }
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовые документы|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, textBox1.Text);
            }
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                DialogResult rez = MessageBox.Show("Блокнот содержит текст. Сохранить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rez == DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.FileName = "Безымянный";
                    sfd.Filter = "Текстовый документ|.*txt";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, textBox1.Text);
                        textBox1.Clear();
                    }
                }

                if (rez == DialogResult.No)
                {
                    textBox1.Clear();
                }
            }
        }

        private string getfilesize(System.IO.FileInfo file)
        {
            try
            {
                double sizeinbytes = file.Length;
                double sizeinkbytes = Math.Round((sizeinbytes / 1024));
                return string.Format("{0} KB", sizeinkbytes);
            }
            catch { return "Ошибка получения размера файла"; }
        }

        private void statistic()
        {
            kindent = 0;
            kglasl = 0;
            kglask = 0;
            ksoglk = 0;
            ksogll = 0;
            knum = 0;
            kirsymb = 0;
            latsymb = 0;
            punctsymb = 0;
            kspecsymb = 0;
            string str = textBox1.Text;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '\n')
                {
                    kindent++;
                }
                else if (str[i] == 'e' || str[i] == 'y' || str[i] == 'u' || str[i] == 'i' || str[i] == 'o' || str[i] == 'a')
                {
                    kglasl++;
                    latsymb++;
                }
                else if (str[i] == 'у' || str[i] == 'е' || str[i] == 'ы' || str[i] == 'а' || str[i] == 'о' || str[i] == 'я' || str[i] == 'и' || str[i] == 'ю' || str[i] == 'э')
                {
                    kglask++;
                    kirsymb++;
                }
                else if (str[i] == 'q' || str[i] == 'w' || str[i] == 'r' || str[i] == 't' || str[i] == 'p' || str[i] == 's' || str[i] == 'd' || str[i] == 'f' || str[i] == 'g' || str[i] == 'h' || str[i] == 'k' || str[i] == 'l' || str[i] == 'z' || str[i] == 'x' || str[i] == 'c' || str[i] == 'v' || str[i] == 'b' || str[i] == 'n' || str[i] == 'm')
                {
                    ksogll++;
                    latsymb++;
                }
                else if (str[i] == 'й' || str[i] == 'ц' || str[i] == 'к' || str[i] == 'н' || str[i] == 'г' || str[i] == 'ш' || str[i] == 'щ' || str[i] == 'з' || str[i] == 'х' || str[i] == 'ъ' || str[i] == 'ф' || str[i] == 'в' || str[i] == 'п' || str[i] == 'р' || str[i] == 'л' || str[i] == 'д' || str[i] == 'ж' || str[i] == 'ч' || str[i] == 'с' || str[i] == 'м' || str[i] == 'т' || str[i] == 'ь' || str[i] == 'б')
                {
                    ksoglk++;
                    kirsymb++;
                }
                else if (char.IsNumber(str[i]))
                {
                    knum++;
                }
                else if (char.IsPunctuation(str[i]))
                {
                    punctsymb++;
                }
                else kspecsymb++;
            }
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statistic();
            ksymb = textBox1.Text.Length.ToString();
            kas = Convert.ToString((Convert.ToInt32(ksymb) / 1800) + 1);
            new Form2().ShowDialog();
        }

        private void RemoveTab(string str)
        {
            resultstring = str.Replace("\t", " ");
            if (resultstring.Contains("\t"))
            {
                RemoveTab(resultstring);
            }
        }

        private void RemoveSpaces(string str)
        {
            resultstring = str.Replace("  ", " ");
            if (resultstring.Contains("  "))
            {
                RemoveSpaces(resultstring);
            }
        }

        private void BeginStringRemoveSpaces(string str)
        {
            resultstring = str.Replace("\n ", "\n");
            if (resultstring.Contains("\n "))
            {
                RemoveSpaces(resultstring);
            }
        }

        private void RemoveEnter(string str)
        {
            resultstring = str.Replace("\n\r", "\n");
            if (resultstring.Contains("\n\r") || resultstring.Contains("\n\n\r\r"))
            {
                RemoveEnter(resultstring);
            }
        }


        private void обработкаТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            string str = textBox1.Text;
            RemoveTab(str);
            RemoveEnter(resultstring);
            RemoveSpaces(resultstring);
            BeginStringRemoveSpaces(resultstring);
            new Form7(resultstring).Show();
            textBox1.Text = text;
        }

        private void поискПервогоВхожденияДвухСловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            new Form3(text).ShowDialog();
        }

        private void поискПервогоВхожденияФамилииСИнициаламиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            new Form4(text).ShowDialog();
        }

        private void проверкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            new Form5().ShowDialog();
        }

        private void поискВсехКорректныхЭлектронныхАдресовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            new Form6(text).ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            countWindow--;
        }
    }
}
