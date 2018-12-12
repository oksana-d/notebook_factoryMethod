using System.Windows.Forms;
using System.Drawing;
namespace notebook
{

   public class Document: Form { }//abstract product

    abstract class Creator
    {
        public abstract Document FactoryMethod();
    }

    class ConcreteCreatorA : Creator
    {
        public override Document FactoryMethod()
        {
            return Form1.getInstance();
        }
    }

    class ConcreteCreatorB : Creator
    {
        public override Document FactoryMethod()
        {
            return new ImageForm();
        }
    }
}

//public override ImageDocument operation(ImageDocument imgDoc)
//{
//    imgDoc.pBox.Image = null;
//    return imgDoc;
//}

//public override ImageDocument operation(ImageDocument imgDoc)
//{
//    OpenFileDialog openDialog = new OpenFileDialog();
//    openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";

//    if (openDialog.ShowDialog() == DialogResult.OK)
//    {
//        System.IO.FileStream fs = new System.IO.FileStream(openDialog.FileName, System.IO.FileMode.Open);
//        System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
//        fs.Close();
//        imgDoc.pBox.Image = img;
//    }
//    return imgDoc;
//}

//class ImageDocument : Document
//{
//    public PictureBox pBox;
//}