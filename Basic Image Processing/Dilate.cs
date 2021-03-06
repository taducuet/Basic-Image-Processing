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
    public partial class Dilate : Form
    {
        public Dilate(Image image ,string path)
        {
            InitializeComponent();
            pBox_Dilate.Image = image;
            pBox_Dilate.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void Dilate_Load(object sender, EventArgs e)
        {

        }

        private void tBar_gaussBlur_Scroll(object sender, EventArgs e)
        {
            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();

            OpenCvSharp.Point p = new OpenCvSharp.Point();
            p.X = -1;
            p.Y = -1;

            lB_blur.Text = tBar_gaussBlur.Value.ToString();
            Cv2.Dilate(src,dst,new Mat(), p, tBar_gaussBlur.Value);

            Bitmap bitmap = dst.ToBitmap();
            pBox_Dilate.Image = bitmap;
            Cv2.WaitKey(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Dilation";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_Dilate.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
