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
using Point = OpenCvSharp.Point;

namespace Basic_Image_Processing
{
    public partial class Crop : Form
    {
        public Crop(Image image, string path)
        {
            InitializeComponent();
            pBox_notCrop.Image = image;
            pBox_notCrop.SizeMode = PictureBoxSizeMode.Zoom;
            tBox_path.Text = path;
        }

        int crpX, crpY, rectW, rectH;
        public Pen crpPen = new Pen(Color.White);

        private void pBox_notCrop_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                crpX = e.X;
                crpY = e.Y;
            }
        }

        private void pBox_notCrop_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }

        private void pBox_notCrop_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pBox_notCrop.Refresh();
                //set width and height for crop rectangle.
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = pBox_notCrop.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG (.jpeg)|*.jpeg|Bitmap (.bmp)|*.bmp|GIF (.gif)|*.gif|PNG (.png)|*.png|TIFF (.tiff)|*.tiff|WMF (.wmf)|*.wmf";
            sfd.FileName = "Cropped";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pBox_cropped.Image.Save(sfd.FileName, ImageFormat.Jpeg);
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

        private void Crop_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectArea_Click(object sender, EventArgs e)
        {
            pBox_notCrop.MouseDown += new MouseEventHandler(pBox_notCrop_MouseDown);

            pBox_notCrop.MouseMove += new MouseEventHandler(pBox_notCrop_MouseMove);

            pBox_notCrop.MouseEnter += new EventHandler(pBox_notCrop_MouseEnter);
            Controls.Add(pBox_notCrop);
        }
        private void btnCrop_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            //Now we will draw the cropped image into pictureBox2
            Bitmap bitmap = new Bitmap(pBox_notCrop.Width, pBox_notCrop.Height);
            pBox_notCrop.DrawToBitmap(bitmap, pBox_notCrop.ClientRectangle);

            Bitmap crpImg = new Bitmap(rectW, rectH);

            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bitmap.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }

            pBox_cropped.Image = (Image)crpImg;
            pBox_cropped.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
