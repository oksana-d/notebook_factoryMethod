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
    public partial class ImageForm : Document
    {
        //ImageDocument img = new ImageDocument();
        public ImageForm()
        {
            InitializeComponent();
            //img.pBox = pictureBox1;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = new System.IO.FileStream(openDialog.FileName, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                pictureBox1.Image = img;
            }
            //OperationWithImage operations = new OpenImage();
            //operations.operation(img);
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            //    return imgDoc;
            //OperationWithImage operations = new ClearImage();
            //operations.operation(img);
        }
    }
}
