using FilmsApp.Forms.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmsApp.Forms.SelectedFilmForms
{
    public partial class PrintOrSavePosterForm : BaseForm
    {
        string path = Application.StartupPath + @"\Resources\Images\Default.jpg";
        public PrintOrSavePosterForm()
        {
            InitializeComponent();

        }

        private void buttonPrintPrinter_Click(object sender, EventArgs e)
        {
            printPoster.PrintPage += printDocument1_PrintPage;
            printPosterDialog.Document = printPoster;
            if(printPosterDialog.ShowDialog()== DialogResult.OK)
            {
                printPoster.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image img = Image.FromFile(path);
            Bitmap printImage= new Bitmap(img);
            
            e.Graphics.DrawImage(printImage,0,0);
            printImage.Dispose();
        }

        private void buttonSaveOnDisk_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(path);
            Bitmap printImage = new Bitmap(img);
            savePosterDialog.Filter = "PNG|*.png |JPEG|*.jpg";

            if (savePosterDialog.ShowDialog() == DialogResult.OK)
            {
                img.Save(savePosterDialog.FileName);

            }
        }
    }
}
