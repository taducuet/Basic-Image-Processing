using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//accord library
using Accord.MachineLearning;
using Accord.Math;
using Accord.Statistics.Distributions.DensityKernels;
using Accord.Math.Distances;
using Accord.Imaging.Converters;
//opencv library
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Drawing.Imaging;
using System.Threading;

namespace Basic_Image_Processing
{
    public partial class MLmeanShift : Form
    {
        public MLmeanShift(Image image, string path)
        {
            InitializeComponent();
            pBox_mshift.Image = image;
            pBox_mshift.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;

        }

        private void MeanShift_Load(object sender, EventArgs e)
        {

        }

        private void runMeanShift()
        {
            int pixelSize = 3;

            // Retrieve the kernel bandwidth
            double sigma = (double)numBandwitdh.Value;
            Bitmap image = (Bitmap)pBox_mshift.Image;

            // Create converters
            ImageToArray imageToArray = new ImageToArray(min: -1, max: +1);
            ArrayToImage arrayToImage = new ArrayToImage(image.Width, image.Height, min: -1, max: +1);

            // Transform the image into an array of pixel values
            double[][] pixels; imageToArray.Convert(image, out pixels);


            // Create a MeanShift algorithm using the given bandwidth
            // and a Gaussian density kernel as the kernel function:

            var meanShift = new MeanShift()
            {
                Kernel = new GaussianKernel(pixelSize),
                Bandwidth = sigma,
                Tolerance = 0.05,
                MaxIterations = 10
            };


            // Compute the mean-shift algorithm until the difference 
            // in shift vectors between two iterations is below 0.05

            int[] idx = meanShift.Learn(pixels).Decide(pixels);


            // Replace every pixel with its corresponding centroid
            pixels.Apply((x, i) => meanShift.Clusters.Modes[idx[i]], result: pixels);

            // Show resulting image in the picture box
            Bitmap result; arrayToImage.Convert(pixels, out result);

            pBox_mshift.Image = result;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            runMeanShift();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "MeanShift";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_mshift.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
