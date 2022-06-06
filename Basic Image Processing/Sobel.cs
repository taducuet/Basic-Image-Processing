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
    public partial class Sobel : Form
    {
        public Sobel(Image image, string path)
        {
            InitializeComponent();
            pBox_Sobel.Image = image;
            pBox_Sobel.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void Sobel_Load(object sender, EventArgs e)
        {

        }

        private void btn_Sobel_Click(object sender, EventArgs e)
        {
            Mat img = Cv2.ImRead(tBox_path.Text);
            Mat imggray_sobel = new Mat();
            Cv2.CvtColor(img, imggray_sobel, ColorConversionCodes.BGR2GRAY);
            Mat imgsobel = new Mat();
            Cv2.Sobel(imggray_sobel, imgsobel, -1, 1, 0);
            pBox_Sobel.Image = imgsobel.ToBitmap();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Sobel";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_Sobel.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
