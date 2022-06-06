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
    public partial class MedianBlur : Form
    {
        public MedianBlur(Image image, string path)
        {
            InitializeComponent();
            pBox_MedianBlur.Image = image;
            pBox_MedianBlur.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void MedianBlur_Load(object sender, EventArgs e)
        {
            
        }
        
        private void tBar_blur_Scroll(object sender, EventArgs e)
        {
            if (tBar_blur.Value % 2 == 0)
            {
                tBar_blur.Value++;
            }
            else
                tBar_blur.Value = tBar_blur.Value;

            lB_blur.Text = tBar_blur.Value.ToString();

            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();

            Cv2.MedianBlur(src, dst, tBar_blur.Value);
            Bitmap bitmap = dst.ToBitmap();
            pBox_MedianBlur.Image = bitmap;
            Cv2.WaitKey(0);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Median Blur";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_MedianBlur.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
