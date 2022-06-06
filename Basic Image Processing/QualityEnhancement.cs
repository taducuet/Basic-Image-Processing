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
    public partial class QualityEnhancement : Form
    {
        public QualityEnhancement(Image image, string path)
        {
            InitializeComponent();
            pBox_Enhance.Image = image;
            pBox_Enhance.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        Mat img = new Mat();
        Mat img_brightness = new Mat();
        Mat img_constrast = new Mat();

        private void tBar_alpha_Scroll(object sender, EventArgs e)
        {
            img = Cv2.ImRead(tBox_path.Text);
            lb_alpha.Text = tBar_alpha.Value.ToString();
            img.ConvertTo(img_brightness, -1, tBar_alpha.Value, tBar_beta.Value);
            pBox_Enhance.Image = img_brightness.ToBitmap();
        }

        private void tBar_beta_Scroll(object sender, EventArgs e)
        {
            img = Cv2.ImRead(tBox_path.Text);
            lb_beta.Text = tBar_beta.Value.ToString();
            img.ConvertTo(img_constrast, -1, tBar_alpha.Value, tBar_beta.Value);
            pBox_Enhance.Image = img_constrast.ToBitmap();
            
        }

        float gma = 0;
        private void tBar_gamma_Scroll(object sender, EventArgs e)
        {
            img = Cv2.ImRead(tBox_path.Text);
            lb_gamma.Text = tBar_gamma.Value.ToString();
            float value1 = 0.4f;
            gma = value1 * tBar_gamma.Value / 10;
            Bitmap bm = img.ToBitmap();
            Graphics g = Graphics.FromImage(bm);
            ImageAttributes ia = new ImageAttributes();

            ia.SetGamma(gma);
            Bitmap newbitmap = img.ToBitmap();
            g.DrawImage(newbitmap, new Rectangle(0, 0, newbitmap.Width, newbitmap.Height), 0, 0, newbitmap.Width, newbitmap.Height, GraphicsUnit.Pixel, ia);

            pBox_Enhance.Image = bm;
        }
    }
}
