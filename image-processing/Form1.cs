using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image File (*.png, *.jpg)|*.png;*.jpg";
            if (DialogResult.OK == openFile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(openFile.FileName);
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Processing.ConvertToGray(copy);
            this.picResult.Image = copy;
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            Processing.ConvertToNegative(copy);
            this.picResult.Image = copy;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "JPEG Files(*.jpeg)|*.jpeg";
            if (DialogResult.OK==saveFile.ShowDialog())
            {
                this.picResult.Image.Save(saveFile.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
