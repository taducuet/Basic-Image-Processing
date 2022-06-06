
namespace Basic_Image_Processing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preprocessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gausianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qualityEnhancementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gauseFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilateralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.machineLearningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kMeansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lBox_Image = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pBox_Initial = new System.Windows.Forms.PictureBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Initial)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preprocessingToolStripMenuItem,
            this.machineLearningToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openFolderToolStripMenuItem.Text = "Open Folder";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
            // 
            // preprocessingToolStripMenuItem
            // 
            this.preprocessingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.convertColorToolStripMenuItem,
            this.cropToolStripMenuItem,
            this.dilateToolStripMenuItem,
            this.edgeDetectionToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.qualityEnhancementToolStripMenuItem,
            this.thresholdToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.preprocessingToolStripMenuItem.Name = "preprocessingToolStripMenuItem";
            this.preprocessingToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.preprocessingToolStripMenuItem.Text = "Processing";
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem1,
            this.medianToolStripMenuItem,
            this.gausianToolStripMenuItem});
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.blurToolStripMenuItem.Text = "Blur";
            // 
            // blurToolStripMenuItem1
            // 
            this.blurToolStripMenuItem1.Name = "blurToolStripMenuItem1";
            this.blurToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.blurToolStripMenuItem1.Text = "Blur";
            this.blurToolStripMenuItem1.Click += new System.EventHandler(this.blurToolStripMenuItem1_Click);
            // 
            // medianToolStripMenuItem
            // 
            this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
            this.medianToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.medianToolStripMenuItem.Text = "Median";
            this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
            // 
            // gausianToolStripMenuItem
            // 
            this.gausianToolStripMenuItem.Name = "gausianToolStripMenuItem";
            this.gausianToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.gausianToolStripMenuItem.Text = "Gaussian";
            this.gausianToolStripMenuItem.Click += new System.EventHandler(this.gausianToolStripMenuItem_Click);
            // 
            // convertColorToolStripMenuItem
            // 
            this.convertColorToolStripMenuItem.Name = "convertColorToolStripMenuItem";
            this.convertColorToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.convertColorToolStripMenuItem.Text = "Convert Color";
            this.convertColorToolStripMenuItem.Click += new System.EventHandler(this.convertColorToolStripMenuItem_Click);
            // 
            // cropToolStripMenuItem
            // 
            this.cropToolStripMenuItem.Name = "cropToolStripMenuItem";
            this.cropToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.cropToolStripMenuItem.Text = "Crop";
            this.cropToolStripMenuItem.Click += new System.EventHandler(this.cropToolStripMenuItem_Click);
            // 
            // dilateToolStripMenuItem
            // 
            this.dilateToolStripMenuItem.Name = "dilateToolStripMenuItem";
            this.dilateToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.dilateToolStripMenuItem.Text = "Dilate";
            this.dilateToolStripMenuItem.Click += new System.EventHandler(this.dilateToolStripMenuItem_Click);
            // 
            // edgeDetectionToolStripMenuItem
            // 
            this.edgeDetectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cannyToolStripMenuItem,
            this.sobelToolStripMenuItem});
            this.edgeDetectionToolStripMenuItem.Name = "edgeDetectionToolStripMenuItem";
            this.edgeDetectionToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.edgeDetectionToolStripMenuItem.Text = "Edge Detection";
            // 
            // cannyToolStripMenuItem
            // 
            this.cannyToolStripMenuItem.Name = "cannyToolStripMenuItem";
            this.cannyToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.cannyToolStripMenuItem.Text = "Canny";
            this.cannyToolStripMenuItem.Click += new System.EventHandler(this.cannyToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.erosionToolStripMenuItem.Text = "Erosion";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // qualityEnhancementToolStripMenuItem
            // 
            this.qualityEnhancementToolStripMenuItem.Name = "qualityEnhancementToolStripMenuItem";
            this.qualityEnhancementToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.qualityEnhancementToolStripMenuItem.Text = "Quality Enhancement";
            this.qualityEnhancementToolStripMenuItem.Click += new System.EventHandler(this.qualityEnhancementToolStripMenuItem_Click);
            // 
            // thresholdToolStripMenuItem
            // 
            this.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            this.thresholdToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.thresholdToolStripMenuItem.Text = "Threshold";
            this.thresholdToolStripMenuItem.Click += new System.EventHandler(this.thresholdToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gauseFilterToolStripMenuItem,
            this.sepiaFilterToolStripMenuItem,
            this.bilateralToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // gauseFilterToolStripMenuItem
            // 
            this.gauseFilterToolStripMenuItem.Name = "gauseFilterToolStripMenuItem";
            this.gauseFilterToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.gauseFilterToolStripMenuItem.Text = "Gause";
            this.gauseFilterToolStripMenuItem.Click += new System.EventHandler(this.gauseFilterToolStripMenuItem_Click);
            // 
            // sepiaFilterToolStripMenuItem
            // 
            this.sepiaFilterToolStripMenuItem.Name = "sepiaFilterToolStripMenuItem";
            this.sepiaFilterToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.sepiaFilterToolStripMenuItem.Text = "Sepia";
            this.sepiaFilterToolStripMenuItem.Click += new System.EventHandler(this.sepiaFilterToolStripMenuItem_Click);
            // 
            // bilateralToolStripMenuItem
            // 
            this.bilateralToolStripMenuItem.Name = "bilateralToolStripMenuItem";
            this.bilateralToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.bilateralToolStripMenuItem.Text = "Bilateral";
            this.bilateralToolStripMenuItem.Click += new System.EventHandler(this.bilateralToolStripMenuItem_Click);
            // 
            // machineLearningToolStripMenuItem
            // 
            this.machineLearningToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kMeansToolStripMenuItem,
            this.meanShiftToolStripMenuItem});
            this.machineLearningToolStripMenuItem.Name = "machineLearningToolStripMenuItem";
            this.machineLearningToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.machineLearningToolStripMenuItem.Text = "Machine Learning";
            // 
            // kMeansToolStripMenuItem
            // 
            this.kMeansToolStripMenuItem.Name = "kMeansToolStripMenuItem";
            this.kMeansToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.kMeansToolStripMenuItem.Text = "KMeans";
            this.kMeansToolStripMenuItem.Click += new System.EventHandler(this.kMeansToolStripMenuItem_Click);
            // 
            // meanShiftToolStripMenuItem
            // 
            this.meanShiftToolStripMenuItem.Name = "meanShiftToolStripMenuItem";
            this.meanShiftToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.meanShiftToolStripMenuItem.Text = "Mean Shift";
            this.meanShiftToolStripMenuItem.Click += new System.EventHandler(this.meanShiftToolStripMenuItem_Click);
            // 
            // lBox_Image
            // 
            this.lBox_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lBox_Image.FormattingEnabled = true;
            this.lBox_Image.ItemHeight = 16;
            this.lBox_Image.Location = new System.Drawing.Point(12, 63);
            this.lBox_Image.Name = "lBox_Image";
            this.lBox_Image.Size = new System.Drawing.Size(198, 500);
            this.lBox_Image.TabIndex = 2;
            this.lBox_Image.SelectedIndexChanged += new System.EventHandler(this.lBox_Image_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Images List";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutUsToolStripMenuItem.Text = "About";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click_1);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // pBox_Initial
            // 
            this.pBox_Initial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBox_Initial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Initial.InitialImage = global::Basic_Image_Processing.Properties.Resources.initial_image;
            this.pBox_Initial.Location = new System.Drawing.Point(259, 63);
            this.pBox_Initial.Name = "pBox_Initial";
            this.pBox_Initial.Size = new System.Drawing.Size(500, 500);
            this.pBox_Initial.TabIndex = 1;
            this.pBox_Initial.TabStop = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBox_Image);
            this.Controls.Add(this.pBox_Initial);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Initial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preprocessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qualityEnhancementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gauseFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gausianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilateralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem machineLearningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kMeansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cropToolStripMenuItem;
        private System.Windows.Forms.ListBox lBox_Image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pBox_Initial;
    }
}

