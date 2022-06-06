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
    public partial class Canny : Form
    {
        public Canny(Image image, string path)
        {
            InitializeComponent();
            pBox_Canny.Image = image;
            pBox_Canny.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void Canny_Load(object sender, EventArgs e)
        {

        }

        private void tBar_Gx_Scroll(object sender, EventArgs e)
        {
            float temp1 = tBar_Gx.Value;
            float temp2 = tBar_Gy.Value;

            lb_Gx.Text = tBar_Gx.Value.ToString();
            lb_Gy.Text = tBar_Gy.Value.ToString();

            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            Cv2.Canny(src, dst, temp1, temp2);

            Bitmap _bitmapImg = dst.ToBitmap();
            pBox_Canny.Image = _bitmapImg;
            Cv2.WaitKey(0);
        }

        private void tB_Gy_Scroll(object sender, EventArgs e)
        {
            float temp1 = tBar_Gx.Value;
            float temp2 = tBar_Gy.Value;

            lb_Gx.Text = tBar_Gx.Value.ToString();
            lb_Gy.Text = tBar_Gy.Value.ToString();

            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            Cv2.Canny(src, dst, temp1, temp2);

            Bitmap _bitmapImg = dst.ToBitmap();
            pBox_Canny.Image = _bitmapImg;
            Cv2.WaitKey(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Canny";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_Canny.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
