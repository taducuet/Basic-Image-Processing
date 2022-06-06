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
    public partial class GaussianFilter : Form
    {
        public GaussianFilter(Image image, string path)
        {
            InitializeComponent();
            pBox_GaussianFilter.Image = image;
            pBox_GaussianFilter.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void GaussianFilter_Load(object sender, EventArgs e)
        {

        }

        private void btnGaussFilter_Click(object sender, EventArgs e)
        {
            Mat img = new Mat();
            img = Cv2.ImRead(tBox_path.Text);
            Mat imggray_gause = new Mat();
            Cv2.CvtColor(img, imggray_gause, ColorConversionCodes.BGR2GRAY);
            Mat imgGause = new Mat();
            Cv2.GaussianBlur(imggray_gause, imgGause, new OpenCvSharp.Size(3, 3), 1);
            pBox_GaussianFilter.Image = imgGause.ToBitmap();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Gaussian Filter";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_GaussianFilter.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
