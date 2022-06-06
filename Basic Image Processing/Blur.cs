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
    public partial class Blur : Form
    {
        public Blur(Image image, string path)
        {
            InitializeComponent();
            pBox_Blur.Image = image;
            pBox_Blur.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void Blur_Load(object sender, EventArgs e)
        {

        }

        private void tBar_blur_Scroll(object sender, EventArgs e)
        {
            double temp = tBar_blur.Value;
            lB_blur.Text = tBar_blur.Value.ToString();

            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();

            Cv2.Blur(src, dst, new OpenCvSharp.Size(temp, temp));
            Bitmap bitmap = dst.ToBitmap();
            pBox_Blur.Image = bitmap;
            Cv2.WaitKey(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Blur";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_Blur.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
