using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;

namespace Basic_Image_Processing
{
    public partial class ColorConvert : Form
    {
        public ColorConvert(Image image, string path)
        {
            InitializeComponent();
            pBox_cvtColor.Image = image;
            pBox_cvtColor.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
            img = Cv2.ImRead(path);
        }

        Mat[] RGB = new Mat[3];
        Mat img = new Mat();
        
        private void ColorConvert_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            pBox_cvtColor.Image = img.ToBitmap();
            RGB = Cv2.Split(img);
            if (cBoxColor.Text == "Red Channel")
                pBox_cvtColor.Image = RGB[0].ToBitmap();
            if (cBoxColor.Text == "Green Channel")
                pBox_cvtColor.Image = RGB[1].ToBitmap();
            if (cBoxColor.Text == "Blue Channel")
                pBox_cvtColor.Image = RGB[2].ToBitmap();
            if (cBoxColor.Text == "Gray Image")
            {
                Mat img_gray = new Mat();
                Cv2.CvtColor(img, img_gray, ColorConversionCodes.BGR2GRAY);
                pBox_cvtColor.Image = img_gray.ToBitmap();
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Color Convert";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_cvtColor.Image.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Activate();
            }
        }
    }
}
