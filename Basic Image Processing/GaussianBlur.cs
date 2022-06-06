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
    public partial class GaussianBlur : Form
    {
        public GaussianBlur(Image image, string path)
        {
            InitializeComponent();
            pBox_gaussBlur.Image = image;
            pBox_gaussBlur.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void GaussianBlur_Load(object sender, EventArgs e)
        {

        }

        private void tBar_gaussBlur_Scroll(object sender, EventArgs e)
        {
            double temp = tBar_gaussBlur.Value;
            lB_blur.Text = tBar_gaussBlur.Value.ToString();

            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();

            Cv2.GaussianBlur(src, dst, new OpenCvSharp.Size(15, 15), temp);
            Bitmap bitmap = dst.ToBitmap();
            pBox_gaussBlur.Image = bitmap;
            Cv2.WaitKey(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Gaussian Blur";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_gaussBlur.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
