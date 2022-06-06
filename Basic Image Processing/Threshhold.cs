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
    public partial class Threshhold : Form
    {
        public Threshhold(Image image, string path)
        {
            InitializeComponent();
            pBox_threshold.Image = image;
            pBox_threshold.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void Threshhold_Load(object sender, EventArgs e)
        {
            
        }

        private void tBar_threshold_Scroll(object sender, EventArgs e)
        {
            double temp1 = tBar_threshold.Value;

            lB_threshold.Text = tBar_threshold.Value.ToString();

            Mat src = new Mat(tBox_path.Text, ImreadModes.AnyColor);
            Mat dst = new Mat();
            Cv2.Threshold(src, dst, temp1, 255, ThresholdTypes.Binary);

            Bitmap bitmap = dst.ToBitmap();
            pBox_threshold.Image = bitmap;
            Cv2.WaitKey(0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Threhold";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_threshold.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
