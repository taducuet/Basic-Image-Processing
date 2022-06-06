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
    public partial class Kmeans : Form
    {
        public Kmeans(Image image, string path)
        {
            InitializeComponent();
            pBox_kmeans.Image = image;
            pBox_kmeans.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        private void Kmeans_Load(object sender, EventArgs e)
        {

        }

        public void runKMeans()
        {
            int k = (int)numClusters.Value;
            Bitmap image = (Bitmap)pBox_kmeans.Image;
            ImageToArray imageToArray = new ImageToArray(min: -1, max: +1);
            ArrayToImage arrayToImage = new ArrayToImage(image.Width, image.Height, min: -1, max: +1);
            double[][] pixels; imageToArray.Convert(image, out pixels);
            KMeans kmeans = new KMeans(k, new SquareEuclidean())
            {
                Tolerance = 0.05
            };
            int[] idx = kmeans.Learn(pixels).Decide(pixels);
            pixels.Apply((x, i) => kmeans.Clusters.Centroids[idx[i]], result: pixels);
            Bitmap result; arrayToImage.Convert(pixels, out result);
            pBox_kmeans.Image = result;
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            runKMeans();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "KMeans";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_kmeans.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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
