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
    public partial class SepiaFilter : Form
    {
        public SepiaFilter(Image image, string path)
        {
            InitializeComponent();
            pBox_SepiaFilter.Image = image;
            pBox_SepiaFilter.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void SepiaFilter_Load(object sender, EventArgs e)
        {

        }

        public static void Sepia(Mat src, Mat dst, float[] data)
        {
            Mat kernel = new Mat(rows: 3, cols: 3, type: MatType.CV_32FC1, data: data);
            Cv2.Transform(src, dst, kernel);
        }
        private void btnSepiaFilter_Click(object sender, EventArgs e)
        {
            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            Sepia(src, dst, new float[] { 0.272f, 0.534f, 0.131f, 0.349f, 0.686f, 0.168f, 0.393f, 0.769f, 0.189f });

            Bitmap bitmap = dst.ToBitmap();
            pBox_SepiaFilter.Image = bitmap;
            Cv2.WaitKey(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Sepia Filter";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_SepiaFilter.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
