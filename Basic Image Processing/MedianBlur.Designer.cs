
namespace Basic_Image_Processing
{
    partial class MedianBlur
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
            this.pBox_MedianBlur = new System.Windows.Forms.PictureBox();
            this.tBar_blur = new System.Windows.Forms.TrackBar();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lB_blur = new System.Windows.Forms.Label();
            this.tBox_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_MedianBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_blur)).BeginInit();
            this.SuspendLayout();
            // 
            // pBox_MedianBlur
            // 
            this.pBox_MedianBlur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBox_MedianBlur.Location = new System.Drawing.Point(12, 12);
            this.pBox_MedianBlur.Name = "pBox_MedianBlur";
            this.pBox_MedianBlur.Size = new System.Drawing.Size(450, 450);
            this.pBox_MedianBlur.TabIndex = 0;
            this.pBox_MedianBlur.TabStop = false;
            // 
            // tBar_blur
            // 
            this.tBar_blur.Location = new System.Drawing.Point(12, 511);
            this.tBar_blur.Maximum = 50;
            this.tBar_blur.Minimum = 1;
            this.tBar_blur.Name = "tBar_blur";
            this.tBar_blur.Size = new System.Drawing.Size(459, 56);
            this.tBar_blur.TabIndex = 1;
            this.tBar_blur.Value = 1;
            this.tBar_blur.Scroll += new System.EventHandler(this.tBar_blur_Scroll);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.Location = new System.Drawing.Point(549, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(169, 75);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.Location = new System.Drawing.Point(549, 126);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 75);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lB_blur
            // 
            this.lB_blur.AutoSize = true;
            this.lB_blur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lB_blur.Location = new System.Drawing.Point(500, 511);
            this.lB_blur.Name = "lB_blur";
            this.lB_blur.Size = new System.Drawing.Size(18, 20);
            this.lB_blur.TabIndex = 4;
            this.lB_blur.Text = "1";
            // 
            // tBox_path
            // 
            this.tBox_path.Location = new System.Drawing.Point(12, 428);
            this.tBox_path.Multiline = true;
            this.tBox_path.Name = "tBox_path";
            this.tBox_path.Size = new System.Drawing.Size(450, 34);
            this.tBox_path.TabIndex = 5;
            this.tBox_path.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(212, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "KSize";
            // 
            // MedianBlur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBox_path);
            this.Controls.Add(this.lB_blur);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tBar_blur);
            this.Controls.Add(this.pBox_MedianBlur);
            this.Name = "MedianBlur";
            this.Text = "Median Blur";
            this.Load += new System.EventHandler(this.MedianBlur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_MedianBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar_blur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox_MedianBlur;
        private System.Windows.Forms.TrackBar tBar_blur;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lB_blur;
        private System.Windows.Forms.TextBox tBox_path;
        private System.Windows.Forms.Label label1;
    }
}