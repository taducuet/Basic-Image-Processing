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
    public partial class Bilateral : Form
    {
        public Bilateral(Image image, string path)
        {
            InitializeComponent();
            pBox_Bilateral.Image = image;
            pBox_Bilateral.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void Bilateral_Load(object sender, EventArgs e)
        {

        }

        private void tBar_gaussBlur_Scroll(object sender, EventArgs e)
        {
            double temp1 = Convert.ToDouble(numSigmaColor.Text.ToString());
            double temp2 = Convert.ToDouble(numSigmaSpace.Text.ToString());

            lB_Bilateral.Text = tBar_Bilateral.Value.ToString();

            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            Cv2.BilateralFilter(src, dst, tBar_Bilateral.Value, temp1, temp2);

            Bitmap bitmap = dst.ToBitmap();
            pBox_Bilateral.Image = bitmap;
            Cv2.WaitKey(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Bilateral Filter";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_Bilateral.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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

        private void numSigmaColor_ValueChanged(object sender, EventArgs e)
        {
            double temp1 = Convert.ToDouble(numSigmaColor.Text.ToString());
            double temp2 = Convert.ToDouble(numSigmaSpace.Text.ToString());

            lB_Bilateral.Text = tBar_Bilateral.Value.ToString();

            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            Cv2.BilateralFilter(src, dst, tBar_Bilateral.Value, temp1, temp2);

            Bitmap bitmap = dst.ToBitmap();
            pBox_Bilateral.Image = bitmap;
            Cv2.WaitKey(0);
        }

        private void numSigmaSpace_ValueChanged(object sender, EventArgs e)
        {
            double temp1 = Convert.ToDouble(numSigmaColor.Text.ToString());
            double temp2 = Convert.ToDouble(numSigmaSpace.Text.ToString());

            lB_Bilateral.Text = tBar_Bilateral.Value.ToString();

            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            Cv2.BilateralFilter(src, dst, tBar_Bilateral.Value, temp1, temp2);

            Bitmap bitmap = dst.ToBitmap();
            pBox_Bilateral.Image = bitmap;
            Cv2.WaitKey(0);
        }
    }
}
