using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace Basic_Image_Processing
{
    public partial class Form1 : Form
    {
        Image image;
        string path;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(Basic_Image_Processing.Properties.Resources.initial_image);
            pBox_Initial.Image = bmp;
        }
        ///// File
        //Choose Image 
        Mat imgInitial = new Mat();
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            if (file.ShowDialog() == DialogResult.OK)
            {
                imgInitial = Cv2.ImRead(file.FileName);
                pBox_Initial.Image = imgInitial.ToBitmap();
                pBox_Initial.SizeMode = PictureBoxSizeMode.Zoom;
                image = pBox_Initial.Image;
                path = file.FileName;
            }
        }

        //Choose Folder
        class images
        {
            public string filename { get; set; }
            public string fullpath { get; set; }
        }
        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderImg = new FolderBrowserDialog();
            folderImg.ShowNewFolderButton = true;
            DialogResult result = folderImg.ShowDialog();
            if (result == DialogResult.OK)
            {
                lBox_Image.Items.Clear();
                string[] files = Directory.GetFiles(folderImg.SelectedPath);
                string[] dirs = Directory.GetDirectories(folderImg.SelectedPath);
                List<images> imageList = new List<images>();
                foreach (string file in files)
                {
                    images img = new images();
                    img.fullpath = Path.GetFullPath(file);
                    img.filename = Path.GetFileName(file);
                    imageList.Add(img);
                }

                lBox_Image.DisplayMember = "filename";
                lBox_Image.ValueMember = "fullpath";
                lBox_Image.DataSource = imageList;
            }
        }

        Mat imgList = new Mat();
        private void lBox_Image_SelectedIndexChanged(object sender, EventArgs e)
        {
            imgList = Cv2.ImRead(((images)lBox_Image.SelectedItem).fullpath);
            pBox_Initial.Image = imgList.ToBitmap();
            pBox_Initial.SizeMode = PictureBoxSizeMode.Zoom;
            image = pBox_Initial.Image;
            path = ((images)lBox_Image.SelectedItem).fullpath;
        }

        /////Processing
        ///Blur
        //Median Blur

        private void medianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedianBlur medianBlur = new MedianBlur(image,path);
            medianBlur.Show();
        }

        private void blurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur(image, path);
            blur.Show();

        }

        private void gausianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaussianBlur gaussianBlur = new GaussianBlur(image, path);
            gaussianBlur.Show();
        }

        private void convertColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorConvert colorConvert = new ColorConvert(image, path);
            colorConvert.Show();
        }

        private void cropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crop crop = new Crop(image, path);
            crop.Show();
        }

        private void dilateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dilate dilate = new Dilate(image, path);
            dilate.Show();
        }

        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canny canny = new Canny(image, path);
            canny.Show();
                 
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobel sobel = new Sobel(image, path);
            sobel.Show();
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Erosion erosion = new Erosion(image, path);
            erosion.Show();

        }

        private void qualityEnhancementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QualityEnhancement qualityEnhancement = new QualityEnhancement(image, path);
            qualityEnhancement.Show();
        }

        private void thresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Threshhold threshhold = new Threshhold(image, path);
            threshhold.Show();
        }

        private void gauseFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GaussianFilter gaussianFilter = new GaussianFilter(image, path);
            gaussianFilter.Show();
        }

        private void sepiaFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SepiaFilter sepiaFilter = new SepiaFilter(image, path);
            sepiaFilter.Show();
        }

        private void bilateralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bilateral bilateral = new Bilateral(image, path);
            bilateral.Show();
        }

        private void kMeansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kmeans kmeans = new Kmeans(image, path);
            kmeans.Show();
        }

        private void meanShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MLmeanShift mLmeanShift = new MLmeanShift(image, path);
            mLmeanShift.Show();
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histogram histogram = new Histogram(image, path);
            histogram.Show();
        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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
