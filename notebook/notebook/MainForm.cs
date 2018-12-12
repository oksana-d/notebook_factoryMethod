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
    public partial class MainForm : Form
    {
        //Document document;
        public MainForm()
        {
            InitializeComponent();
        }

        private void текстовыйРедакторToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Document mdiChild = Form1.getInstance();
                mdiChild.MdiParent = this;
                mdiChild.Show();
        }

        private void изображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Document mdiChild = new ImageForm();
                mdiChild.MdiParent = this;
                mdiChild.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form[] form = MdiChildren;
                foreach (Form f in form)
                {
                    f.Close();
                }
        }
    }
}
