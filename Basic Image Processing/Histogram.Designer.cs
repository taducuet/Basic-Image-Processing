
namespace Basic_Image_Processing
{
    partial class Histogram
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
            this.tBox_path = new System.Windows.Forms.TextBox();
            this.pBox_Image = new System.Windows.Forms.PictureBox();
            this.pBox_Histogram = new System.Windows.Forms.PictureBox();
            this.btnHistogram = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(12, 428);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 39;
            this.tBox_path.Visible = false;
            // 
            // pBox_Image
            // 
            this.pBox_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Image.Location = new System.Drawing.Point(12, 12);
            this.pBox_Image.Name = "pBox_Image";
            this.pBox_Image.Size = new System.Drawing.Size(450, 450);
            this.pBox_Image.TabIndex = 38;
            this.pBox_Image.TabStop = false;
            // 
            // pBox_Histogram
            // 
            this.pBox_Histogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_Histogram.Location = new System.Drawing.Point(500, 12);
            this.pBox_Histogram.Name = "pBox_Histogram";
            this.pBox_Histogram.Size = new System.Drawing.Size(450, 450);
            this.pBox_Histogram.TabIndex = 38;
            this.pBox_Histogram.TabStop = false;
            // 
            // btnHistogram
            // 
            this.btnHistogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHistogram.Location = new System.Drawing.Point(12, 468);
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.Size = new System.Drawing.Size(450, 75);
            this.btnHistogram.TabIndex = 43;
            this.btnHistogram.Text = "Create Histogram";
            this.btnHistogram.UseVisualStyleBackColor = true;
            this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(781, 468);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 42;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(500, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Histogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 588);
            this.Controls.Add(this.btnHistogram);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.pBox_Histogram);
            this.Controls.Add(this.pBox_Image);
            this.Name = "Histogram";
            this.Text = "Histogram";
            this.Load += new System.EventHandler(this.Histogram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Histogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.PictureBox pBox_Image;
        private System.Windows.Forms.PictureBox pBox_Histogram;
        private System.Windows.Forms.Button btnHistogram;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
    }
}